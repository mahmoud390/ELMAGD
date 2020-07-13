using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elmagd
{
    public partial class ClientInvoice : Form
    {
        int id, store, cat, quantitytype;
        double total, quantity, price, bskoul, mashal, commession, rest, enterquantity;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;User ID=test;Password=test;");
        SqlCommand cmd = new SqlCommand();

        public ClientInvoice()
        {
            InitializeComponent();
        }

        private void ClientInvoice_Load(object sender, EventArgs e)
        {
            clientinvoicedate.Value = DateTime.Now;
            Loadquantity_type();
            Loadstore();
            Loadcategory();
            Loadclient();
            BindGrid();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select TEMP_CLIENT.id,CLIENT.name as إسم_العميل,CATEGORY.name as إسم_الصنف ,STORE.name as إسم_المخزن,TEMP_CLIENT.quantity as الكمية,QUANTITY_TYPE.name as نوع_الكميه,TEMP_CLIENT.price as السعر,TEMP_CLIENT.total as الإجمالي,TEMP_CLIENT.biskoul as بسكول,TEMP_CLIENT.mashal as مشال ,TEMP_CLIENT.commission as عمولات,TEMP_CLIENT.rest as الإجمالي_بعدالخصم,TEMP_CLIENT.paid as المدفوع,TEMP_CLIENT.baky as الباقي,TEMP_CLIENT.date as التاريخ from TEMP_CLIENT inner join CLIENT on TEMP_CLIENT.client_id =CLIENT.id inner join CATEGORY on TEMP_CLIENT.cat_id =CATEGORY.id inner join STORE on TEMP_CLIENT.store_id =STORE.id inner join QUANTITY_TYPE on TEMP_CLIENT.quantitytype_id =QUANTITY_TYPE.id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tempclientgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        #region  QUANTITY_TYPE
        private void Loadquantity_type()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From QUANTITY_TYPE", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر نوع الكمية---";
            dt.Rows.InsertAt(dr, 0);
            comboquantitytype.ValueMember = "id";
            comboquantitytype.DisplayMember = "name";
            comboquantitytype.DataSource = dt;
        }
        #endregion

        #region LOAD STORE
        private void Loadstore()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From STORE", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر المخزن---";
            dt.Rows.InsertAt(dr, 0);
            combostore.ValueMember = "id";
            combostore.DisplayMember = "name";
            combostore.DataSource = dt;
        }
        #endregion

        #region LOADCATRGORY
        private void Loadcategory()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From CATEGORY", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر الصنف---";
            dt.Rows.InsertAt(dr, 0);
            combocategory.ValueMember = "id";
            combocategory.DisplayMember = "name";
            combocategory.DataSource = dt;
        }
        #endregion

        #region LOAD_CLIENT
        private void Loadclient()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From CLIENT", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر عميل---";
            dt.Rows.InsertAt(dr, 0);
            comboclient.ValueMember = "id";
            comboclient.DisplayMember = "name";
            comboclient.DataSource = dt;
        }
        #endregion

        private void btncalc_Click(object sender, EventArgs e)
        {
            if (txtquantity.Text.Equals(""))
            {
                MessageBox.Show("برجاء إدخال الكمية");
            }
            else if ((int)comboquantitytype.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار نوع الكمية");
            else if (txtprice.Text.Equals(""))
                MessageBox.Show("برجاء إدخال السعر");
            else
            {
                quantity = double.Parse(txtquantity.Text);
                price = double.Parse(txtprice.Text);
                total = quantity * price;
                txttotal.Text = total.ToString();
            }
        }
        //حساب الإجمالي بعد الإضافات
        private void btncalc2_Click(object sender, EventArgs e)
        {

            if (txttotal.Text.Equals(""))
            {
                MessageBox.Show("يجب الضغط علي حساب الاجمالي اولا");
            }

            else
            {
                
                if (txtmashal.Text.Equals("") )
                {
                    txtmashal.Text = "0";
                }
                 if (txtcommestion.Text.Equals(""))
                {
                    txtcommestion.Text = "0";
                }
                 if (txtbskoul.Text.Equals(""))
                {
                    txtbskoul.Text = "0";
                }

                    bskoul = double.Parse(txtbskoul.Text);
                    mashal = double.Parse(txtmashal.Text);
                    commession = double.Parse(txtcommestion.Text);
                    rest = total + (bskoul + mashal + commession);
                    txtrest.Text = rest.ToString();
               
            }
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            if ((int)comboclient.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبارعميل");
            else if ((int)combocategory.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبارالصنف");
            else if ((int)comboquantitytype.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار نوع الكمية");
            else if ((int)combostore.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار المخزن");
            else if (txttotal.Text.Equals(""))
                MessageBox.Show("برجاء الضغط علي حساب الاجمالي اولا");
            else if (txtrest.Text.Equals(""))
                MessageBox.Show("برجاء الضغط علي حساب الباقي اولا");

            else
            {
                enterquantity = double.Parse(txtquantity.Text);
                conn.Open();
                cmd.CommandText = @" select quantity from MAIN_STORE where store_id ='" + (int)combostore.SelectedValue + "'and cat_id='" + (int)combocategory.SelectedValue + "'and quantitytype_id='" + (int)comboquantitytype.SelectedValue + "' ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("المخزن خالي");
                    conn.Close();
                }
                else
                {
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == "")
                        {
                            quantity = 0;
                        }
                        quantity = double.Parse(reader[0].ToString());
                    }

                    conn.Close();
                    //-------------------------------------
                    if (enterquantity > quantity)
                    {
                        MessageBox.Show("الكمية الموجودة في المخزن غير كافية لبيع هذه الكمية");
                    }
                    else
                    {
                        conn.Open();
                        cmd.CommandText = @"insert into TEMP_CLIENT (client_id,cat_id,quantity,quantitytype_id,price,total,biskoul,mashal,commission,rest,paid,baky,store_id,date) values(@client_id,@cat_id,@quantity,@quantitytype_id,@price,@total,@biskoul,@mashal,@commissions,@rest,@paid,@baky,@store_id,@date)";
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@client_id", (int)comboclient.SelectedValue);
                        cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@quantity", txtquantity.Text);
                        cmd.Parameters.AddWithValue("@quantitytype_id", (int)comboquantitytype.SelectedValue);
                        cmd.Parameters.AddWithValue("@price", txtprice.Text);
                        cmd.Parameters.AddWithValue("@total", txttotal.Text);
                        cmd.Parameters.AddWithValue("@biskoul", txtbskoul.Text);
                        cmd.Parameters.AddWithValue("@mashal", txtmashal.Text);
                        cmd.Parameters.AddWithValue("@commissions", txtcommestion.Text);
                        cmd.Parameters.AddWithValue("@rest", txtrest.Text);
                        cmd.Parameters.AddWithValue("@paid", txtpaid.Text);
                        cmd.Parameters.AddWithValue("@baky", txtbaky.Text);
                        cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                        cmd.Parameters.AddWithValue("@date", clientinvoicedate.Value.Date.ToShortDateString());
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        conn.Close();
                        BindGrid();

                        MessageBox.Show("تمت عمليه الاضافه");
                        //----------------------------------------
                        //select quntity ,store, quantity type,category
                        conn.Open();
                        cmd.CommandText = @" select quantity from TEMP_CLIENT where store_id ='" + (int)combostore.SelectedValue + "'and cat_id='" + (int)combocategory.SelectedValue + "'and quantitytype_id='" + (int)comboquantitytype.SelectedValue + "' ";
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            quantity = double.Parse(reader[0].ToString());
                        }
                        conn.Close();
                        //---------------------------------
                        //update mainstore
                        conn.Open();
                        cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + quantity + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id ='" + (int)comboquantitytype.SelectedValue + "'   ";
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        conn.Close();
                        txtbskoul.Text = "";
                        txtcommestion.Text = "";
                        txtmashal.Text = "";
                        txtprice.Text = "";
                        txtquantity.Text = "";
                        txtrest.Text = "";
                        txttotal.Text = "";
                        txtpaid.Text = "";
                        txtbaky.Text = "";
                        comboclient.SelectedIndex = 0;
                        combocategory.SelectedIndex = 0;
                        comboquantitytype.SelectedIndex = 0;
                        combostore.SelectedIndex = 0;
                    }
                }

            }
        }

        private void tempclientgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tempclientgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
            else
            {
                tempclientgrid.CurrentRow.Selected = true;
                id = int.Parse(tempclientgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                btnadd.Enabled = false;
            }
        }
        //delet temp
        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                cmd.CommandText = @" select store_id,cat_id,quantity,quantitytype_id from TEMP_CLIENT where id='" + id + "' ";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    store = int.Parse(reader[0].ToString());
                    cat = int.Parse(reader[1].ToString());
                    quantity = double.Parse(reader[2].ToString());
                    quantitytype = int.Parse(reader[3].ToString());

                }
                conn.Close();
                //---------------------------------
                //update mainstore
                conn.Open();
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + quantity + "' where store_id = '" + store + "'and cat_id ='" + cat + "'and quantitytype_id ='" + quantitytype + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                foreach (DataGridViewRow row in tempclientgrid.SelectedRows)
                {

                    tempclientgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from TEMP_CLIENT where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    MessageBox.Show("تم الحذف");
                    id = 0;
                    btnadd.Enabled = true;
                }


            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select id from TEMP_CLIENT  ";
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
                MessageBox.Show("لاتوجد اي بيانات للطباعه");
            else
            {
                //add client invoice
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into CLIENT_INVOICE (client_id,cat_id,quantity,quantitytype_id,price,total,biskoul,mashal,commission,rest,paid,baky,store_id,date) select  client_id,cat_id,quantity,quantitytype_id,price,total,biskoul,mashal,commission,rest,paid,baky,store_id,date from TEMP_CLIENT ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                //-------------------------------------------------------------------------------
                conn.Open();
                cmd.CommandText = @"select id from CLIENT_INVOICE where CLIENT_INVOICE.date = '" + clientinvoicedate.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into CASHIER (clientinvoice_id,date) values(@clientinvoice_id,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@clientinvoice_id", id);
                cmd.Parameters.AddWithValue("@date", clientinvoicedate.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                //-------------------------------------------------------------------------------
                ////addto sales
                conn.Open();
                cmd.CommandText = @"insert into SALES (client_id,cat_id,quantity,quantitytype_id,store_id,rest,paid,baky,date) select  client_id,cat_id,quantity,quantitytype_id,store_id,rest,paid,baky,date from TEMP_CLIENT ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                //-------------------------------------

                //print


                // delete temp client
                conn.Open();
                cmd.CommandText = @"delete from TEMP_CLIENT ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
            }
        }

        private void btnbaky_Click(object sender, EventArgs e)
        {
            double paid, baky;
            if (txtrest.Text.Equals(""))
            {
                MessageBox.Show("برجاء الضغط علي زر حساب الإجمالي بعد الخصومات");
            }
            else if (txtpaid.Text.Equals(""))
            {
                txtpaid.Text = " 0";
            }
            paid = double.Parse(txtpaid.Text);
            baky = rest - paid;
            txtbaky.Text = baky.ToString();
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtquantity.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtquantity.Text = txtquantity.Text.Remove(txtquantity.Text.Length - 1);
            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            }
        }

        private void txtbskoul_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbskoul.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtbskoul.Text = txtbskoul.Text.Remove(txtbskoul.Text.Length - 1);
            }
        }

        private void txtmashal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtmashal.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtmashal.Text = txtmashal.Text.Remove(txtmashal.Text.Length - 1);
            }
        }

        private void txtcommestion_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcommestion.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtcommestion.Text = txtcommestion.Text.Remove(txtcommestion.Text.Length - 1);
            }
        }

        private void txtpaid_TextChanged(object sender, EventArgs e)
        {

            //if (System.Text.RegularExpressions.Regex.IsMatch(txtpaid.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("يجب إدخال أرقام فقط");
            //    txtpaid.Text = txtpaid.Text.Remove(txtpaid.Text.Length - 1);
            //}
        }



    }
}
