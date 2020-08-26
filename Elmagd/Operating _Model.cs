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
    public partial class Operating__Model : Form
    {
        int id, store, cat, quantitytype, catid_DB, id_store;
        double enter_quantity, quantity, Enter_quantity;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Operating__Model()
        {
            InitializeComponent();
        }

        private void radGroupBox2_Click(object sender, EventArgs e)
        {

        }
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

        private void Operating__Model_Load(object sender, EventArgs e)
        {
            Loadcategory();
            Loadstore();
            Loadquantity_type();
            Loadcategoryfinal();
            Loadquantity_type_final();
            Loadstorefinal();
        }
        #region LOADCATRGORY
        private void Loadcategoryfinal()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From CATEGORY", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر الصنف---";
            dt.Rows.InsertAt(dr, 0);
            combofinalcat.ValueMember = "id";
            combofinalcat.DisplayMember = "name";
            combofinalcat.DataSource = dt;
        }
        #endregion

        #region  QUANTITY_TYPE
        private void Loadquantity_type_final()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From QUANTITY_TYPE", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر نوع الكمية---";
            dt.Rows.InsertAt(dr, 0);
            combofinalquantitytype.ValueMember = "id";
            combofinalquantitytype.DisplayMember = "name";
            combofinalquantitytype.DataSource = dt;
        }
        #endregion

        #region LOAD STORE
        private void Loadstorefinal()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From STORE", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر المخزن---";
            dt.Rows.InsertAt(dr, 0);
            combofinalstore.ValueMember = "id";
            combofinalstore.DisplayMember = "name";
            combofinalstore.DataSource = dt;
        }
        #endregion

        private void btnadd_Click(object sender, EventArgs e)
        {
            enter_quantity = double.Parse(txtquantity.Text);
            if ((int)combostore.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار المخزن");
            else if ((int)combocategory.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبارالصنف");
            else if (txtquantity.Text.Equals(""))
                MessageBox.Show("برجاء إدخال الكمية");
            else if ((int)comboquantitytype.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار نوع الكمية");
            else
            {

                conn.Open();
                cmd.CommandText = @" select quantity from MAIN_STORE where store_id ='" + (int)combostore.SelectedValue + "'and cat_id='" + (int)combocategory.SelectedValue + "'and quantitytype_id= 1 ";
                cmd.Connection = conn;
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
                    if (enter_quantity > quantity)
                    {
                        MessageBox.Show("الكمية الموجودة في المخزن اقل من الكمية التي تم إدخالها ");
                    }
                    else
                    {
                        //add to temp material
                        conn.Open();
                        cmd.CommandText = @"insert into MATERIAL (store_id,cat_id,quantity,quantitytype_id,date_start,notes) values(@store_id,@cat_id,@quantity,@quantitytype_id,@date_start,@notes)";
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                        cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
                        if ((int)comboquantitytype.SelectedValue == 2)
                        {
                            quantity = enter_quantity * 1000;
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                        }
                        else
                            cmd.Parameters.AddWithValue("@quantity", txtquantity.Text);
                        cmd.Parameters.AddWithValue("@quantitytype_id", 1);
                        cmd.Parameters.AddWithValue("@date_start", dateStart.Value.Date.ToShortDateString());
                        cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        conn.Close();
                        MessageBox.Show("تمت عمليه الاضافه");
                        //----------------------------------------
                        //select quntity ,store, quantity type,category
                        conn.Open();
                        cmd.CommandText = @" select quantity from MATERIAL where store_id ='" + (int)combostore.SelectedValue + "'and cat_id='" + (int)combocategory.SelectedValue + "'and quantitytype_id='" + (int)comboquantitytype.SelectedValue + "' and date_start ='" + dateStart.Value.Date.ToShortDateString() + "' ";
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
                        txtquantity.Text = "";
                        combocategory.SelectedIndex = 0;
                        comboquantitytype.SelectedIndex = 0;
                        combostore.SelectedIndex = 0;
                    }
                }
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Enter_quantity = double.Parse(txtfinalquantity.Text);
            if ((int)combofinalstore.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار المخزن");
            else if ((int)combofinalcat.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبارالصنف");
            else if (txtfinalquantity.Text.Equals(""))
                MessageBox.Show("برجاء إدخال الكمية");
            else if ((int)combofinalquantitytype.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار نوع الكمية");
            else
            {
                //انسيرت في الانتاج التام full production
                conn.Open();
                cmd.CommandText = @"insert into FULLPRODUCTION (store_id,cat_id,quantity,quantitytype_id,date_end,notes) values(@store_id,@cat_id,@quantity,@quantitytype_id,@date_end,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@store_id", (int)combofinalstore.SelectedValue);
                cmd.Parameters.AddWithValue("@cat_id", (int)combofinalcat.SelectedValue);
                if ((int)combofinalquantitytype.SelectedValue == 2)
                {
                    quantity = Enter_quantity * 1000;
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                }
                else
                    cmd.Parameters.AddWithValue("@quantity", txtfinalquantity.Text);
                cmd.Parameters.AddWithValue("@quantitytype_id", 1);
                cmd.Parameters.AddWithValue("@date_end", dateEnd.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@notes", txtfnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                MessageBox.Show("تمت عمليه الاضافه");
                //----------------------------------------------------------
                conn.Open();
                cmd.CommandText = @"select cat_id,quantitytype_id  from FULLPRODUCTION where date_end ='" + dateEnd.Value.Date.ToShortDateString() + "'and cat_id'" + (int)combofinalcat.SelectedValue + "' ";
                SqlDataReader reader_cateid = cmd.ExecuteReader();
                while (reader_cateid.Read())
                {

                    catid_DB = int.Parse(reader_cateid[0].ToString());
                    quantitytype = int.Parse(reader_cateid[1].ToString());
                }
                conn.Close();
                //-----------------------------------------------------------
                conn.Open();
                cmd.CommandText = @"select id  from MAIN_STORE where cat_id ='" + catid_DB + "'and quantitytype_id= '" + quantitytype + "'  ";
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
                    conn.Open();
                    cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) select store_id,cat_id,quantity,quantitytype_id from FULLPRODUCTION where date_end ='" + dateEnd.Value.Date.ToShortDateString() + "'and cat_id'" + (int)combofinalcat.SelectedValue + "' ";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    // سليكت الكمية الموجودة داخل المخزن ونوع الكمية
                    conn.Open();
                    cmd.CommandText = @" select store_id,cat_id,quantity,quantitytype_id from FULLPRODUCTION where date_end ='" + dateEnd.Value.Date.ToShortDateString() + "'and cat_id'" + (int)combofinalcat.SelectedValue + "' ";
                    SqlDataReader reader = cmd.ExecuteReader();
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
            }

        }
    }
}

