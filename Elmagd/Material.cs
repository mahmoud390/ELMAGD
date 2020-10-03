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
    public partial class Material : Form
    {
        int id, store, cat, quantitytype;
        double enter_quantity, quantity;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Material()
        {
            InitializeComponent();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            TempBindGrid();
            Loadcategory();
            Loadquantity_type();
            Loadstore();
            MaterialBindGrid();
        }
        #region TEMP_BINDGRID
        private void TempBindGrid()
        {
            try
            {
                conn.Open();
                cmd.CommandText = @"select TEMP_MATERIAL.id as م,STORE.name as المخزن,CATEGORY.name as الصنف,TEMP_MATERIAL.quantity as الكمية,QUANTITY_TYPE.name as 'نوع الكمية',TEMP_MATERIAL.notes as الملاحظات from TEMP_MATERIAL inner join STORE on STORE.id =TEMP_MATERIAL.store_id inner join CATEGORY on CATEGORY.id = TEMP_MATERIAL.cat_id inner join QUANTITY_TYPE on QUANTITY_TYPE.id = TEMP_MATERIAL.quantitytype_id ";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Tempmaterialgrid.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }
        #endregion

        #region MATERIALBINDGRID
        private void MaterialBindGrid()
        {
            conn.Close();
            conn.Open();
            cmd.CommandText = @"select MATERIAL.id as م,STORE.name as المخزن,CATEGORY.name as الصنف,MATERIAL.quantity as الكمية,QUANTITY_TYPE.name as 'نوع الكمية' ,MATERIAL.notes as  الملاحظات from MATERIAL inner join STORE on STORE.id =MATERIAL.store_id inner join CATEGORY on CATEGORY.id = MATERIAL.cat_id inner join QUANTITY_TYPE on QUANTITY_TYPE.id = MATERIAL.quantitytype_id ";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Materialgrid.DataSource = dt;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int quntytypetemp =0,quntytypestore=0;
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
                    cmd.CommandText = @" select quantity,quantitytype_id from MAIN_STORE where store_id ='" + (int)combostore.SelectedValue + "'and cat_id='" + (int)combocategory.SelectedValue + "'and quantitytype_id= 1 ";
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
                            quntytypestore = int.Parse(reader[1].ToString());
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
                            cmd.CommandText = @"insert into TEMP_MATERIAL (store_id,cat_id,quantity,quantitytype_id,date_start,notes) values(@store_id,@cat_id,@quantity,@quantitytype_id,@date_start,@notes)";
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                            cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
                            cmd.Parameters.AddWithValue("@quantity", txtquantity.Text);
                            cmd.Parameters.AddWithValue("@quantitytype_id", comboquantitytype.SelectedValue);
                            cmd.Parameters.AddWithValue("@date_start", dateStart.Value.Date.ToShortDateString());
                            cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            conn.Close();
                            TempBindGrid();
                            MessageBox.Show("تمت عمليه الاضافه");
                            //----------------------------------------
                            //select quntity ,store, quantity type,category
                            conn.Open();
                            cmd.CommandText = @" select quantity, quantitytype_id from TEMP_MATERIAL where store_id ='" + (int)combostore.SelectedValue + "'and cat_id='" + (int)combocategory.SelectedValue + "'";//and quantitytype_id='" + (int)comboquantitytype.SelectedValue + "' ";
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                quantity = double.Parse(reader[0].ToString());
                                quntytypetemp =int.Parse(reader[1].ToString());
                            }
                            conn.Close();
                            //---------------------------------
                            //update mainstore
                              if (quntytypetemp == quntytypestore)
                                    quantity = quantity;
                                else if (quntytypestore == 1 && quntytypetemp == 2)
                                {
                                    quantity = quantity * 1000;
                                }
                                else if (quntytypestore == 2 && quntytypetemp == 1)
                                {
                                    quantity = quantity / 1000;
                                }
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
                    conn.Open();
                    cmd.CommandText = @" select store_id,cat_id,quantity,quantitytype_id from TEMP_MATERIAL where id='" + id + "' ";
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
                    foreach (DataGridViewRow row in Tempmaterialgrid.SelectedRows)
                    {

                        Tempmaterialgrid.Rows.RemoveAt(row.Index);
                        conn.Open();
                        cmd.CommandText = @"delete from TEMP_MATERIAL where id = '" + id + "'";
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

        private void Tempmaterialgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Tempmaterialgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    Tempmaterialgrid.CurrentRow.Selected = true;
                    id = int.Parse(Tempmaterialgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    btnadd.Enabled = false;
                }
            }
            catch (Exception ex) { }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.CommandText = @"select id from TEMP_MATERIAL  ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("لاتوجد اي بيانات للحفظ");
                    conn.Close();
                }
                else
                {
                    //add MATIRAL

                    conn.Close();
                    conn.Open();
                    cmd.CommandText = @"insert into MATERIAL (store_id,cat_id,quantity,quantitytype_id,date_start,notes) select  store_id,cat_id,quantity,quantitytype_id,date_start,notes from TEMP_MATERIAL ";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    MaterialBindGrid();
                    conn.Close();
                    //-----------
                    conn.Open();
                    cmd.CommandText = @"delete from TEMP_MATERIAL ";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    TempBindGrid();

                }
            }
            catch (Exception ex) { }
        }

        private void combostore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
