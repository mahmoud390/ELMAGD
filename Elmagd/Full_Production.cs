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
    public partial class Full_Production : Form
    {
        int id, store, cat, quantitytype, id_store,catid_DB;
        double enter_quantity, quantity;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Full_Production()
        {
            InitializeComponent();
        }

        private void Full_Production_Load(object sender, EventArgs e)
        {
            TempBindGrid();
            FullProductionBindGrid();
            Loadcategory();
            Loadquantity_type();
            Loadstore();
        }
        #region TEMP_BINDGRID
        private void TempBindGrid()
        {
            try
            {
                conn.Open();
                cmd.CommandText = @"select TEMP_FULLPRODUCTION.id as م ,STORE.name as المخزن,CATEGORY.name as الصنف,TEMP_FULLPRODUCTION.quantity as الكمية,QUANTITY_TYPE.name as 'نوع الكمية',TEMP_FULLPRODUCTION.notes as الملاحظات from TEMP_FULLPRODUCTION inner join STORE on STORE.id =TEMP_FULLPRODUCTION.store_id inner join CATEGORY on CATEGORY.id = TEMP_FULLPRODUCTION.cat_id inner join QUANTITY_TYPE on QUANTITY_TYPE.id = TEMP_FULLPRODUCTION.quantitytype_id ";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Temfullproductiongrid.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }
        #endregion

        #region FULLPRODUCTION BINDGRID
        private void FullProductionBindGrid()
        {
            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = @"select FULLPRODUCTION.id as م,STORE.name as المخزن,CATEGORY.name as الصنف,FULLPRODUCTION.quantity as الكمية,QUANTITY_TYPE.name as 'نوع الكمية' ,FULLPRODUCTION.notes as الملاحظات from FULLPRODUCTION inner join STORE on STORE.id =FULLPRODUCTION.store_id inner join CATEGORY on CATEGORY.id = FULLPRODUCTION.cat_id inner join QUANTITY_TYPE on QUANTITY_TYPE.id = FULLPRODUCTION.quantitytype_id ";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                fullproductiongrid.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
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
                    cmd.CommandText = @"insert into TEMP_FULLPRODUCTION (store_id,cat_id,quantity,quantitytype_id,date_end,notes) values(@store_id,@cat_id,@quantity,@quantitytype_id,@date_end,@notes)";
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
                    cmd.Parameters.AddWithValue("@date_end", dateEnd.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    conn.Close();
                    TempBindGrid();
                    combocategory.SelectedIndex = 0;
                    comboquantitytype.SelectedIndex = 0;
                    combostore.SelectedIndex = 0;
                    txtquantity.Text = "";
                    MessageBox.Show("تمت عمليه الاضافه");
                }
            }
            catch (Exception ex) { }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.CommandText = @"select id from TEMP_FULLPRODUCTION  ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                    MessageBox.Show("لاتوجد اي بيانات للحفظ");
                else
                {
                    conn.Close();
                    conn.Open();
                    cmd.CommandText = @"insert into FULLPRODUCTION (store_id,cat_id,quantity,quantitytype_id,date_end,notes) select  store_id,cat_id,quantity,quantitytype_id,date_end,notes from TEMP_FULLPRODUCTION ";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    FullProductionBindGrid();
                    conn.Close();
                    //---------------------------------------------------------------
                    // add to main store
                    conn.Open();
                    cmd.CommandText = @"select cat_id,quantitytype_id  from TEMP_FULLPRODUCTION ";
                    SqlDataReader reader_cateid = cmd.ExecuteReader();
                    while (reader_cateid.Read())
                    {

                        catid_DB = int.Parse(reader_cateid[0].ToString());
                        quantitytype = int.Parse(reader_cateid[1].ToString());
                    }
                    conn.Close();
                    //----------------------------------------------
                    //إضافة مخزن ومنتج داخلmainstore في حالة عدم وجود هذا المخزن
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
                        cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) select store_id,cat_id,quantity,quantitytype_id from TEMP_FULLPRODUCTION ";
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                    else
                    {
                        // سليكت الكمية الموجودة داخل المخزن ونوع الكمية
                        conn.Open();
                        cmd.CommandText = @" select store_id,cat_id,quantity,quantitytype_id from TEMP_FULLPRODUCTION ";
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
                        //----------------------
                        conn.Open();
                        cmd.CommandText = @"delete from TEMP_FULLPRODUCTION ";
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        TempBindGrid();
                    }

                }
            }
            catch (Exception ex) { }
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
                else
                {
                    foreach (DataGridViewRow row in Temfullproductiongrid.SelectedRows)
                    {
                        Temfullproductiongrid.Rows.RemoveAt(row.Index);
                        conn.Open();
                        cmd.CommandText = @"delete from TEMP_FULLPRODUCTION where id = '" + id + "'";
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        TempBindGrid();
                        MessageBox.Show("تم الحذف");
                        id = 0;
                        btnadd.Enabled = true;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void Temfullproductiongrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Temfullproductiongrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    Temfullproductiongrid.CurrentRow.Selected = true;
                    id = int.Parse(Temfullproductiongrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    btnadd.Enabled = false;
                }
            }
            catch (Exception ex) { }
        }
    }
}
