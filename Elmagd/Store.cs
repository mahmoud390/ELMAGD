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
    public partial class Store : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Store()
        {
            InitializeComponent();
        }

        #region LOAD_PAGE
        private void Store_Load(object sender, EventArgs e)
        {
            BindGrid();
           
        }
        #endregion

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select STORE.id,STORE.name as اسم_المخزن,STORE.notes as ملاحظات from STORE ";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            storegrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        #region ADD_STORE__ADD_TOSTORE
        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("برجاء ادخال الاسم");
                txtname.Focus();
            }
           
            else
            {
                //-----------------------------
                conn.Open();
                cmd.CommandText = @"insert into TOSTORE (name,notes) values(@name,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                //-----------------------------------------------------
                conn.Open();
                cmd.CommandText = @"insert into STORE (name,notes) values(@name,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtname.Text = "";
                MessageBox.Show("تمت عمليه الاضافه");
               
                //------------------------------------------------
            
                
            }
        }
        #endregion

        #region GRID_CELLCLICK
        private void storegrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (storegrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    storegrid.CurrentRow.Selected = true;
                    id = int.Parse(storegrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    txtname.Text = storegrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtnotes.Text = storegrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    btnadd.Enabled = false;

                }
            }
            catch (Exception ex) { }
        }
        #endregion

        #region EDITE_STORE__TOSTORE
        private void btnedite_Click(object sender, EventArgs e)
        {

            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update TOSTORE set name=@name,notes =@notes where id = '" + id + "'", conn);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                //------------------------------------------------------------------------------------------
                conn.Open();
                cmd = new SqlCommand("update STORE set name=@name,notes =@notes where id = '" + id + "'", conn);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
                txtname.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تم التعديل");
                id = 0;
                btnadd.Enabled = true;
            }
        }
        #endregion

        #region DELET_STORE__TOSTORE
        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                foreach (DataGridViewRow row in storegrid.SelectedRows)
                {
                    storegrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from STORE where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    //---------------------------------------------
                    conn.Open();
                    cmd.CommandText = @"delete from TOSTORE where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    txtname.Text = "";
                    txtnotes.Text = "";
                    MessageBox.Show("تم الحذف");
                    id = 0;
                    btnadd.Enabled = true;
                }
            }
        }
        #endregion

        #region SEARCH
        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select STORE.id,STORE.name as اسم_المخزنfrom STORE  where STORE.name  LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            storegrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
