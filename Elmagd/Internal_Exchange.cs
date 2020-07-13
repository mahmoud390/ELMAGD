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
    public partial class Internal_Exchange : Form
    {
        int id;
        double quantity;
        int fromstore, quantity_type, tostore, cat_id;
        double quantityfrom_DB;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;User ID=test;Password=test;");
        SqlCommand cmd = new SqlCommand();

        public Internal_Exchange()
        {
            InitializeComponent();
        }

        private void Internal_Exchange_Load(object sender, EventArgs e)
        {
            exchangedate.Value = DateTime.Now;
            Loadcategory();
            Loadstore();
            Loadstore1();
            Loadquantity_type();
            BindGrid();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Close();
            conn.Open();
            cmd.CommandText = @"select INTERNAL_EXCHANGE.id,STORE.name as المخزن_المنقول_منه,TOSTORE.name as المخزن_المنقول_إليه,CATEGORY.name as الصنف,INTERNAL_EXCHANGE.quantity as الكمية,QUANTITY_TYPE.name as نوع_الكمية,INTERNAL_EXCHANGE.date as التاريخ from INTERNAL_EXCHANGE inner join STORE on INTERNAL_EXCHANGE.storeid =STORE.id inner join TOSTORE on INTERNAL_EXCHANGE.tostore = TOSTORE.id  inner join QUANTITY_TYPE on INTERNAL_EXCHANGE.quantitytype_id =QUANTITY_TYPE.id inner join CATEGORY on INTERNAL_EXCHANGE.cat_id =CATEGORY.id  ";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            exchangegrid.DataSource = dt;
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

        #region LOAD STORE1
        private void Loadstore1()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From STORE", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر المخزن---";
            dt.Rows.InsertAt(dr, 0);
            combotostore.ValueMember = "id";
            combotostore.DisplayMember = "name";
            combotostore.DataSource = dt;
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

        private void btnadd1_Click(object sender, EventArgs e)
        {
            if ((int)combostore.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار المخزن المنقول منه");
            else if ((int)combotostore.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار المخزن المنقل اليه");
            else if ((int)combocategory.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار نوع الكمية");
            else if (txtquantity.Text.Equals(""))
                MessageBox.Show("برجاء ادخال الكمية المراد نقلها");
            else if ((int)comboquantitytype.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار نوع الكمية");
            else if ((int)combostore.SelectedIndex == (int)combotostore.SelectedIndex)
                MessageBox.Show("لا يمكن نقل البضاعه من مخزن الي نفس المخزن برجاء اختيار مخزن اخر ");
            else
            {
                double enter_quantity;
                int storeToID;
                enter_quantity = double.Parse(txtquantity.Text);
                //----------------------
                conn.Open();
                cmd.CommandText = @"select  quantity from MAIN_STORE where store_id = '" + (int)combostore.SelectedValue + "' and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id ='" + (int)comboquantitytype.SelectedValue + "'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        quantityfrom_DB = 0;

                    else
                        quantityfrom_DB = double.Parse(reader[0].ToString());
                }
                conn.Close();
                if (enter_quantity > quantityfrom_DB)
                {
                    MessageBox.Show("لايمكنك نقل هذه الكمية حيث ان المخزن لا يوجد به هذه الكمية");
                   
                }
                else
                {
                conn.Open();
                cmd.CommandText = @"select  store_id from MAIN_STORE where store_id = '" + (int)combotostore.SelectedValue + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        storeToID = (int)combotostore.SelectedValue;

                    else
                        storeToID = int.Parse(reader[0].ToString());
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into INTERNAL_EXCHANGE (storeid,quantity,quantitytype_id,date,tostore,cat_id) values(@storeid,@quantity,@quantitytype_id,@date,@tostore,@cat_id)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@storeid", (int)combostore.SelectedValue);
                cmd.Parameters.AddWithValue("@quantity", enter_quantity);
                cmd.Parameters.AddWithValue("@quantitytype_id", (int)comboquantitytype.SelectedValue);
                cmd.Parameters.AddWithValue("@date", exchangedate.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@tostore", (int)combotostore.SelectedValue);
                cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                BindGrid();
                conn.Close();
                txtquantity.Text = "";
                MessageBox.Show("تمت عملية الصرف ");
                //--------------------------------------

                //double quantity_DB, quantityfrom_DB;
                //// الكمية الموجوده في المخزن المراد نقل البضاعه منه
                //conn.Open();
                //cmd.CommandText = @"select  sum (quantity) from MAIN_STORE where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id ='" + (int)comboquantitytype.SelectedValue + "' ";
                //reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    quantity_DB = double.Parse(reader[0].ToString());
                //}
                //conn.Close();
                ////------------------------------------
                //// الكمية الموجوده في المخزن المراد نقل البضاعه اليه
                //conn.Open();
                //cmd.CommandText = @"select sum (quantity) from MAIN_STORE where store_id = '" + (int)combotostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id ='" + (int)comboquantitytype.SelectedValue + "' ";
                //SqlDataReader reader2 = cmd.ExecuteReader();
                //while (reader2.Read())
                //{
                //    if (reader2[0].ToString() == "")
                //        quantityfrom_DB = 0;
                //    else
                //        quantityfrom_DB = double.Parse(reader2[0].ToString());
                //}
                //conn.Close();
                //----------------------------------------------
                // ابديت الكمية الموجوده في المخزن المنقول البضاعه منه
                conn.Open();
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + enter_quantity + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id ='" + (int)comboquantitytype.SelectedValue + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                //-----------------------------------------
                //ابديت الكمية الموجوده في المخزن المراد نقل البضاعه اليه
                conn.Open();
                cmd.CommandText = @"select  store_id from MAIN_STORE where store_id = '" + (int)combotostore.SelectedValue + "'and cat_id='" + (int)combocategory.SelectedValue + "'and quantitytype_id ='" + (int)comboquantitytype.SelectedValue + "' ";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    conn.Close();
                    conn.Open();
                    cmd.CommandText = @"insert into MAIN_STORE (store_id,quantity,quantitytype_id,cat_id) values(@store_id,@quantity,@quantitytype_id,@cat_id)";
                    cmd.Parameters.AddWithValue("@store_id", (int)combotostore.SelectedValue);
                    cmd.Parameters.AddWithValue("@quantity", enter_quantity);
                    cmd.Parameters.AddWithValue("@quantitytype_id", (int)comboquantitytype.SelectedValue);
                    cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity +'" + enter_quantity + "' where  store_id = '" + (int)combotostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id ='" + (int)comboquantitytype.SelectedValue + "'    ";
                }
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                combostore.SelectedIndex = 0;
                combotostore.SelectedIndex = 0;
                combocategory.SelectedIndex = 0;
                comboquantitytype.SelectedIndex = 0;
            }
                }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
               
                conn.Open();
                cmd.CommandText = @"select quantity,storeid,quantitytype_id,tostore,cat_id from INTERNAL_EXCHANGE where id='"+id+"' ";
                SqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    quantity = double.Parse(reader1[0].ToString());
                    fromstore = int.Parse(reader1[1].ToString());
                    quantity_type = int.Parse(reader1[2].ToString());
                    tostore = int.Parse(reader1[3].ToString());
                    cat_id = int.Parse(reader1[4].ToString());
                }
                conn.Close();
                //-----------------------------------------------------------
                conn.Open();
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + quantity + "' where store_id = '" + tostore + "'and cat_id ='" + cat_id + "'and quantitytype_id ='" + quantity_type + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                //----------------------------------------------
                conn.Open();
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + quantity + "' where store_id = '" + fromstore + "'and cat_id ='" + cat_id + "'and quantitytype_id ='" + quantity_type + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();

                foreach (DataGridViewRow row in exchangegrid.SelectedRows)
                {
                    exchangegrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from INTERNAL_EXCHANGE where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    MessageBox.Show("تم الحذف");
                    id = 0;
                    btnadd1.Enabled = true;
                }
            }
        }

        private void exchangegrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (exchangegrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
            else
            {
                exchangegrid.CurrentRow.Selected = true;
                id = int.Parse(exchangegrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                btnadd1.Enabled = false;
            }
        }

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select INTERNAL_EXCHANGE.id,STORE.name,tostore,INTERNAL_EXCHANGE.cat_id,INTERNAL_EXCHANGE.quantity,QUANTITY_TYPE.name,INTERNAL_EXCHANGE.date from INTERNAL_EXCHANGE inner join STORE on INTERNAL_EXCHANGE.storeid =STORE.id  inner join QUANTITY_TYPE on INTERNAL_EXCHANGE.quantitytype_id =QUANTITY_TYPE.id inner join CATEGORY on INTERNAL_EXCHANGE.cat_id =CATEGORY.id where STORE.name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            exchangegrid.DataSource = dt;
            conn.Close();
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtquantity.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtquantity.Text = txtquantity.Text.Remove(txtquantity.Text.Length - 1);
            }
        }
    }
}
