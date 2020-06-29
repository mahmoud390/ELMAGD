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
    public partial class SuppliersInvoice : Form
    {
        int id, store, cat, quantitytype, catid_DB;
        double total, quantity, price, bskoul, mashal, commession, rest, enter_quantity;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public SuppliersInvoice()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #region LOADPAGE
        private void SuppliersInvoice_Load(object sender, EventArgs e)
        {
            suppliersinvoicedate.Value = DateTime.Now;
            BindGrid();
            Loadquantity_type();
            Loadsuppliers();
            Loadstore();
            Loadcategory();
        }
        #endregion

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select TEMP_SUPPLIERSINVOICE.id ,SUPPLIERS.name as المورد,STORE.name as المخزن,CATEGORY.name as الصنف,TEMP_SUPPLIERSINVOICE.quantity as الكمية,QUANTITY_TYPE.name as نوع_الكمية,TEMP_SUPPLIERSINVOICE.price as السعر,TEMP_SUPPLIERSINVOICE.total as الإجمالي,TEMP_SUPPLIERSINVOICE.biskoul as بسكول,TEMP_SUPPLIERSINVOICE.mashal as مشال,TEMP_SUPPLIERSINVOICE.commissions as عمولات,TEMP_SUPPLIERSINVOICE.rest as الإجمالي_بعدالخصومات,TEMP_SUPPLIERSINVOICE.paid as المدفوع,TEMP_SUPPLIERSINVOICE.baky as الباقي from TEMP_SUPPLIERSINVOICE inner join SUPPLIERS on TEMP_SUPPLIERSINVOICE.suppliers_id =SUPPLIERS.id inner join STORE on TEMP_SUPPLIERSINVOICE.store_id = STORE.id inner join CATEGORY on TEMP_SUPPLIERSINVOICE.cat_id = CATEGORY.id inner join QUANTITY_TYPE on TEMP_SUPPLIERSINVOICE.quantitytype_id =QUANTITY_TYPE.id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tempsuppliergrid.DataSource = dt;
            conn.Close();
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

        #region LOAD_SUPPLIERS
        private void Loadsuppliers()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From SUPPLIERS", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر المورد---";
            dt.Rows.InsertAt(dr, 0);
            combosuppliers.ValueMember = "id";
            combosuppliers.DisplayMember = "name";
            combosuppliers.DataSource = dt;
        }
        #endregion

        #region CALC_TOTAL
        // حساب الاجمالي قبل الخصم والاضافة
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
        #endregion

        #region CALC_REST
        //حساب الباقي 
        private void btncalc2_Click(object sender, EventArgs e)
        {
            if (txttotal.Text.Equals(""))
            {
                MessageBox.Show("يجب الضغط علي حساب الاجمالي اولا");
            }
            else
            {
                if (txtmashal.Text.Equals(""))
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
                rest = total - (bskoul + mashal + commession);
                txtrest.Text = rest.ToString();
            }
            
        }
        #endregion

        #region ADD_TEMP_SUPPLIERSINVOICE
        // إضافة في temp_supplierinvoice والجرداية
        //إضافة التوريدات في الجردايه
        private void radButton1_Click(object sender, EventArgs e)
        {
            if ((int)combosuppliers.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبارالمورد");
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
                enter_quantity = double.Parse(txtquantity.Text);
                int store = (int)combostore.SelectedValue;
                int cat = (int)combocategory.SelectedValue;
                int quantitytype = (int)comboquantitytype.SelectedValue;
                conn.Open();
                cmd.CommandText = @"insert into TEMP_SUPPLIERSINVOICE (suppliers_id,cat_id,quantity,quantitytype_id,price,total,biskoul,mashal,commissions,rest,paid,baky,store_id,date) values(@suppliers_id,@cat_id,@quantity,@quantitytype_id,@price,@total,@biskoul,@mashal,@commissions,@rest,@paid,@baky,@store_id,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@suppliers_id", (int)combosuppliers.SelectedValue);
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
                cmd.Parameters.AddWithValue("@date", suppliersinvoicedate.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtbskoul.Text = "";
                txtcommestion.Text = "";
                txtmashal.Text = "";
                txtprice.Text = "";
                txtquantity.Text = "";
                txtrest.Text = "";
                txttotal.Text = "";
                txtpaid.Text = "";
                txtbaky.Text = "";
                combosuppliers.SelectedIndex = 0;
                combocategory.SelectedIndex = 0;
                comboquantitytype.SelectedIndex = 0;
                combostore.SelectedIndex = 0;
                MessageBox.Show("تمت عمليه الاضافه");
            }
        }
        #endregion

        #region GRID_CELLCLICK
        private void tempsuppliergrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tempsuppliergrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
            else
            {
                tempsuppliergrid.CurrentRow.Selected = true;
                id = int.Parse(tempsuppliergrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            }
        }
        #endregion


        #region DELET_TEMP_SUPPLIERSINVOICE
        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                foreach (DataGridViewRow row in tempsuppliergrid.SelectedRows)
                {
                    tempsuppliergrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from TEMP_SUPPLIERSINVOICE where id = '" + id + "'";
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
        #endregion


        #region PRINT_ADDSUPLLIERINVOICE_ADDMAINSTORE_updatemainstore_delettempsuppliersinvoice
        //إضافة في supplier invoice
        private void btnadd_Click(object sender, EventArgs e)
        {

            conn.Open();
            cmd.CommandText = @"select id from TEMP_SUPPLIERSINVOICE  ";
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
                MessageBox.Show("لاتوجد اي بيانات للطباعه");
            else
            {
                conn.Close();
            //add to suppliers invoice
            conn.Open();
            cmd.CommandText = @"insert into SUPPLIERS_INVOICE (suppliers_id,catid,quantity,quantitytype_id,price,total,biskoul,mashal,commissions,rest,paid,baky,store_id,date) select suppliers_id,cat_id,quantity,quantitytype_id,price,total,biskoul,mashal,commissions,rest,paid,baky,store_id,date from TEMP_SUPPLIERSINVOICE ";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            //-------------------------------------------------------------------
            // add to main store
            conn.Open();
            cmd.CommandText = @"select cat_id  from TEMP_SUPPLIERSINVOICE ";
            SqlDataReader reader_cateid = cmd.ExecuteReader();
            while (reader_cateid.Read())
            {

                catid_DB = int.Parse(reader_cateid[0].ToString());
            }
            conn.Close();
            //----------------------------------------------
            //إضافة مخزن ومنتج داخلmainstore في حالة عدم وجود هذا المخزن
            conn.Open();
            cmd.CommandText = @"select id  from MAIN_STORE where cat_id ='" + catid_DB + "'  ";
            SqlDataReader reader_id = cmd.ExecuteReader();
            while (reader_id.Read())
            {
                if (reader_id[0].ToString() == "")
                    id = 0;
                else
                    id = int.Parse(reader_id[0].ToString());
            }
            conn.Close();
            if (id == 0)
            {
                conn.Open();
                cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) select store_id,cat_id,quantity,quantitytype_id from TEMP_SUPPLIERSINVOICE ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            else
            {
                // سليكت الكمية الموجودة داخل المخزن ونوع الكمية
                conn.Open();
                cmd.CommandText = @" select store_id,cat_id,quantity,quantitytype_id from TEMP_SUPPLIERSINVOICE ";
                 reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    store = int.Parse(reader[0].ToString());
                    cat = int.Parse(reader[1].ToString());
                    enter_quantity = double.Parse(reader[2].ToString());
                    quantitytype = int.Parse(reader[3].ToString());

                }
                conn.Close();
                //-------------------------------------
                // ابديت الكمية في المين استور في حالة إضافة توريد جديد
                conn.Open();
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + enter_quantity + "' where store_id = '" + store + "'and cat_id ='" + cat + "'and quantitytype_id ='" + quantitytype + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }

            // print

            //delet temp suppliers invoice
            conn.Open();
            cmd.CommandText = @"delete from TEMP_SUPPLIERSINVOICE ";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            BindGrid();
            }

        }
        #endregion

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        #region CALC_BAKY
        //حساب الباقي بعد المبلغ المدفوع من الإجمالي بعد الخصومات
        private void btnbaky_Click(object sender, EventArgs e)
        {
            double paid, baky;
            if (txtrest.Text.Equals(""))
            {
                MessageBox.Show("برجاء الضغط علي زر حساب الإجمالي بعد الخصومات");
            }
            else if (txtpaid.Text.Equals (""))
            {
                txtpaid.Text =" 0";
            }
             paid = double.Parse(txtpaid.Text);
             baky = rest - paid;
            txtbaky.Text = baky.ToString();
        }
        #endregion

        #region TEXTCHANGE_TXTCOMMESTION
        private void txtcommestion_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcommestion.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtcommestion.Text = txtcommestion.Text.Remove(txtcommestion.Text.Length - 1);
            }
        }
        #endregion

        #region TEXTCHANGE_TXTQUANTITY
        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtquantity.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtquantity.Text = txtquantity.Text.Remove(txtquantity.Text.Length - 1);
            }
        }
        #endregion

        #region TEXTCHANGE_TXTPRICE
        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            }
        }
        #endregion

        #region TEXTCHANGE_TXTBAKY
        private void txtbskoul_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbskoul.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtbskoul.Text = txtbskoul.Text.Remove(txtbskoul.Text.Length - 1);
            }
        }
        #endregion

        #region TEXTCHANGE_TXTMASHAL
        private void txtmashal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtmashal.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtmashal.Text = txtmashal.Text.Remove(txtmashal.Text.Length - 1);
            }
        }
        #endregion

        #region TEXTCHANGE_TXTPAID
        private void txtpaid_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtpaid.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("يجب إدخال أرقام فقط");
            //    txtpaid.Text = txtpaid.Text.Remove(txtpaid.Text.Length - 1);
            //}
        }
        #endregion


    }
}
