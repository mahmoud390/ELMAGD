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
    public partial class Category : Form
    {
        int id;
        //SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select id as م, name as الإسم ,price as السعر ,notes as ملاحضات from CATEGORY";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            categorygrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        #region ADD_CATEGORY
        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("برجاء ادخال الاسم");
                txtname.Focus();
            }
            else if (txtprice.Text.Equals(""))
            {
                MessageBox.Show("برجاء ادخال السعر");
                txtprice.Focus();
            }
            else
            {
                conn.Open();
                cmd.CommandText = @"insert into CATEGORY (name,price,notes) values(@name,@price,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@price", double.Parse(txtprice.Text));
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtname.Text = "";
                txtprice.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تمت عمليه الاضافه");
            }
        }
        #endregion

        private void categorygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (categorygrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    categorygrid.CurrentRow.Selected = true;
                    id = int.Parse(categorygrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    txtname.Text = categorygrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtprice.Text = categorygrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtnotes.Text = categorygrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    btnadd.Enabled = false;
                }
            }
            catch (Exception ex) { }
        }

        #region EDITE_CATEGORY
        private void btnedite_Click(object sender, EventArgs e)
        {
                if (id == 0)
                        MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
                    else
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("update CATEGORY set name=@name,price =@price,notes =@notes where id = '" + id + "'", conn);
                        cmd.Parameters.AddWithValue("@name", txtname.Text.ToString());
                        cmd.Parameters.AddWithValue("@price", double.Parse(txtprice.Text));
                        cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        BindGrid();
                        txtname.Text = "";
                        txtprice.Text = "";
                        txtnotes.Text = "";
                        MessageBox.Show("تم التعديل");
                        id = 0;
                        btnadd.Enabled = true;
                    }
        
        }
        #endregion

        #region DELET_CATEGORY
        private void btndelet_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (id == 0)
                    MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
                else
                {
                    foreach (DataGridViewRow row in categorygrid.SelectedRows)
                    {
                        categorygrid.Rows.RemoveAt(row.Index);
                        conn.Open();
                        cmd.CommandText = @"delete from CATEGORY where id = '" + id + "'";
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        BindGrid();
                        txtname.Text = "";
                        txtprice.Text = "";
                        MessageBox.Show("تم الحذف");
                        id = 0;
                        btnadd.Enabled = true;
                    }
                }
            }
            catch (Exception ex) { }
        }
        #endregion

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtname.Text, "[0-9.*]"))
            {
                MessageBox.Show("يجب ادخال حروف فقط");
                txtname.Text = txtname.Text.Remove(txtname.Text.Length - 1);
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

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select id, name as الإسم ,price as السعر ,notes as ملاحضات from CATEGORY where name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            categorygrid.DataSource = dt;
            conn.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void categorygrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
