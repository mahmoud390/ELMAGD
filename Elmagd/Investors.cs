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
    public partial class Investors : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;User ID=test;Password=test;");
        SqlCommand cmd = new SqlCommand();
        public Investors()
        {
            InitializeComponent();
        }

        #region ADD_INVESTORS
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("برجاء ادخال الاسم");
                txtname.Focus();
            }
            else if (txtphone.Text.Equals(""))
            {
                MessageBox.Show("برجاء ادخال الهاتف");
                txtphone.Focus();
            }
            else
            {
                conn.Open();
                cmd.CommandText = @"insert into INVESTORS (name,phone,notes) values(@name,@phone,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtname.Text = "";
                txtphone.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تمت عمليه الاضافه");
            }
        }
        #endregion

        private void Investors_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select id, name as الإسم,phone as الهاتف ,notes as ملاحضات from INVESTORS";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Investorsgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void Investorsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Investorsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
            else
            {
                Investorsgrid.CurrentRow.Selected = true;
                id = int.Parse(Investorsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtname.Text = Investorsgrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtphone.Text = Investorsgrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtnotes.Text = Investorsgrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                btnadd.Enabled = false;
            }
        }

        #region EDITE_INVESTORS
        private void btnedite_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update INVESTORS set name=@name,phone=@phone,notes =@notes where id = '" + id + "'", conn);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@phone",txtphone.Text);
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
                txtname.Text = "";
                txtphone.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تم التعديل");
                id = 0;
                btnadd.Enabled = true;
            }
        }
        #endregion

        #region DELET_INVESTORS
        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                foreach (DataGridViewRow row in Investorsgrid.SelectedRows)
                {
                    Investorsgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from INVESTORS where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    txtname.Text = "";
                    txtphone.Text = "";
                    txtnotes.Text = "";
                    MessageBox.Show("تم الحذف");
                    id = 0;
                    btnadd.Enabled = true;
                }
            }
        }
        #endregion

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select id, name as الإسم,phone as الهاتف ,notes as ملاحضات from INVESTORS where name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            Investorsgrid.DataSource = dt;
            conn.Close();
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtphone.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtphone.Text = txtphone.Text.Remove(txtphone.Text.Length - 1);
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtname.Text, "[0-9.*]"))
            {
                MessageBox.Show("يجب ادخال حروف فقط");
                txtname.Text = txtname.Text.Remove(txtname.Text.Length - 1);
            }    
        }
    }
}
