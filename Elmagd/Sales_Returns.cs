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
    public partial class Sales_Returns : Form
    {
        int id, quntity_type, id_store,store_fromdb,cat_fromdb,quantitytype_fromdb;
        double enter_quantity, enter_price, total, quantityconverttokilo, totalquantity,quantity_fromdb,totalquantity_db;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Sales_Returns()
        {
            InitializeComponent();
        }

        private void Sales_Returns_Load(object sender, EventArgs e)
        {
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
            cmd.CommandText = @"select SALES_RETURNS.id,CLIENT.name,CATEGORY.name,STORE.name,SALES_RETURNS.quantity,QUANTITY_TYPE.name,SALES_RETURNS.price,SALES_RETURNS.total ,SALES_RETURNS.date from SALES_RETURNS inner join CLIENT on CLIENT.id =SALES_RETURNS.client_id inner join CATEGORY on CATEGORY.id =SALES_RETURNS.category_id inner join STORE on STORE.id =SALES_RETURNS.store_id inner join QUANTITY_TYPE on QUANTITY_TYPE.id =SALES_RETURNS.quantitytype_id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            returnsgrid.DataSource = dt;
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
                MessageBox.Show("برجاء ادخال الكمية");
            else if ((int)comboquantitytype.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار نوع الكمية");
            else if (txtprice.Text.Equals(""))
                MessageBox.Show("برجاء ادخال السعر");
            else
            {
                enter_quantity = double.Parse(txtquantity.Text);
                enter_price = double.Parse(txtprice.Text);
                total = enter_quantity * enter_price;
                txttotal.Text = total.ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if ((int)comboclient.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار عميل");
            else if ((int)combocategory.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار الصنف");
            else if ((int)combostore.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار مخزن");
            else
            {
                enter_quantity = double.Parse(txtquantity.Text);
                quntity_type = (int)comboquantitytype.SelectedValue;
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into SALES_RETURNS (client_id,category_id,quantity,quantitytype_id,price,total,store_id,date) values(@client_id,@category_id,@quantity,@quantitytype_id,@price,@total,@store_id,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@client_id", (int)comboclient.SelectedValue);
                cmd.Parameters.AddWithValue("@category_id", (int)combocategory.SelectedValue);
                cmd.Parameters.AddWithValue("@quantity", txtquantity.Text);
                cmd.Parameters.AddWithValue("@quantitytype_id", (int)comboquantitytype.SelectedValue);
                cmd.Parameters.AddWithValue("@price", txtprice.Text);
                cmd.Parameters.AddWithValue("@total", txttotal.Text);
                cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                cmd.Parameters.AddWithValue("@date", clientinvoicedate.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                 BindGrid();
                //------------------------------------------------------
                conn.Open();
                cmd.CommandText = @"select id  from MAIN_STORE where cat_id ='" + (int)combocategory.SelectedValue + "' and store_id ='"+(int)combostore.SelectedValue+"' ";
                SqlDataReader reader_id = cmd.ExecuteReader();
                while (reader_id.Read())
                {
                    if (reader_id[0].ToString() == "")
                        id_store = 0;
                    else
                        id_store = int.Parse(reader_id[0].ToString());
                }
                conn.Close();
                if (id_store == 0)
                {

                    if (quntity_type == 2)
                    {

                        conn.Open();
                        quantityconverttokilo = enter_quantity * 1000;
                        cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) values (@store_id,@cat_id,@quantity,@quantitytype_id) ";
                        cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                        cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@quantity", quantityconverttokilo);
                        cmd.Parameters.AddWithValue("@quantitytype_id", 1);
                    }

                    else if (quntity_type == 3)
                    {

                        conn.Open();
                        quantityconverttokilo = enter_quantity * 150;
                        cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) values (@store_id,@cat_id,@quantity,@quantitytype_id) ";
                        cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                        cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@quantity", quantityconverttokilo);
                        cmd.Parameters.AddWithValue("@quantitytype_id", 1);
                    }
                    else if (quntity_type == 4)
                    {

                        conn.Open();
                        quantityconverttokilo = enter_quantity * 155;
                        cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) values (@store_id,@cat_id,@quantity,@quantitytype_id) ";
                        cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                        cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@quantity", quantityconverttokilo);
                        cmd.Parameters.AddWithValue("@quantitytype_id", 1);
                    }
                    else
                        cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) select store_id,category_id,quantity,quantitytype_id from SALES_RETURNS ";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    if (quntity_type == 2)
                    {
                        totalquantity = enter_quantity * 1000;
                        cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + totalquantity + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id =1   ";
                    }
                     else if (quntity_type == 3)
                    {
                        totalquantity = enter_quantity * 150;
                        cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + totalquantity + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id =1   ";
                    }
                    else  if (quntity_type == 4)
                    {
                        totalquantity = enter_quantity * 155;
                        cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + totalquantity + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id =1   ";
                    }
                    else
                        cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + enter_quantity + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id =1   ";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    conn.Close();
                    comboclient.SelectedIndex = 0;
                    combocategory.SelectedIndex = 0;
                    combostore.SelectedIndex = 0;
                    comboquantitytype.SelectedIndex = 0;
                    txtquantity.Text = "";
                    txtprice.Text = "";
                    txttotal.Text = "";
                }
            }
        }

        private void returnsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (returnsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    returnsgrid.CurrentRow.Selected = true;
                    id = int.Parse(returnsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                }
            }
            catch (Exception ex) { }
        }

        private void btndelet_Click(object sender, EventArgs e)
        {

              if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                cmd.CommandText = @" select store_id,category_id,quantity,quantitytype_id from SALES_RETURNS where id='" + id + "' ";
                SqlDataReader reader_temp = cmd.ExecuteReader();
                while (reader_temp.Read())
                {
                    store_fromdb = int.Parse(reader_temp[0].ToString());
                    cat_fromdb = int.Parse(reader_temp[1].ToString());
                    quantity_fromdb = double.Parse(reader_temp[2].ToString());
                    quantitytype_fromdb = int.Parse(reader_temp[3].ToString());

                }
                conn.Close();
                  
                //---------------------------------
                //update mainstore
                conn.Open();
                if (quantitytype_fromdb == 2)
                {
                    totalquantity_db = quantity_fromdb * 1000;
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + totalquantity_db + "' where store_id = '" + store_fromdb + "'and cat_id ='" + cat_fromdb + "'and quantitytype_id = 1  ";
                }
                else if (quantitytype_fromdb == 3)
                {
                    totalquantity_db = quantity_fromdb * 150;
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + totalquantity_db + "' where store_id = '" + store_fromdb + "'and cat_id ='" + cat_fromdb + "'and quantitytype_id = 1  ";
                }
                else if (quantitytype_fromdb == 4)
                {
                    totalquantity_db = quantity_fromdb * 155;
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + totalquantity_db + "' where store_id = '" + store_fromdb + "'and cat_id ='" + cat_fromdb + "'and quantitytype_id = 1  ";
                }
                else
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + quantity_fromdb + "' where store_id = '" + store_fromdb + "'and cat_id ='" + cat_fromdb + "'and quantitytype_id =1  ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                foreach (DataGridViewRow row in returnsgrid.SelectedRows)
                {

                    returnsgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from SALES_RETURNS where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    MessageBox.Show("تم الحذف");
                    id = 0;
                   
                }
            }
        }

    }
}
