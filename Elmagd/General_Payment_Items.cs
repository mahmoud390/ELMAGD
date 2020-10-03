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
    public partial class General_Payment_Items : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public General_Payment_Items()
        {
            InitializeComponent();
        }

        private void General_Payment_Items_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select GENERAL_PAYMENT_ITEMS.id,GENERAL_PAYMENT_ITEMS.name as الإسم,GENERAL_PAYMENT_ITEMS.notes as الملاحظات from GENERAL_PAYMENT_ITEMS ";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            General_Payment_Items_grid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("برجاء إدخال الاسم");
            }
            else
            {
                conn.Open();
                cmd.CommandText = @"insert into GENERAL_PAYMENT_ITEMS (name,notes) values(@name,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtname.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تمت عمليه الاضافه");
            }
        }

        private void btnedite_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update GENERAL_PAYMENT_ITEMS set name=@name,notes =@notes where id = '" + id + "'", conn);
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

        private void General_Payment_Items_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (General_Payment_Items_grid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    General_Payment_Items_grid.CurrentRow.Selected = true;
                    id = int.Parse(General_Payment_Items_grid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    txtname.Text = General_Payment_Items_grid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtnotes.Text = General_Payment_Items_grid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    btnadd.Enabled = false;
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
                foreach (DataGridViewRow row in General_Payment_Items_grid.SelectedRows)
                {
                    General_Payment_Items_grid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from GENERAL_PAYMENT_ITEMS where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    txtnotes.Text = "";
                    MessageBox.Show("تم الحذف");
                    id = 0;
                    btnadd.Enabled = true;
                }
            }
        }
    }
}
