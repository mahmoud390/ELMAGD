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
    public partial class Clients : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select id as م, name as الإسم,phone as الهاتف,address as العنوان ,notes as ملاحظات from CLIENT";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clientgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        #region ADD_CLIENT
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
            else if (txtaddress.Text.Equals(""))
            {
                MessageBox.Show("برجاء ادخال العنوان");
                txtaddress.Focus();
            }
            else
            {
                conn.Open();
                cmd.CommandText = @"insert into CLIENT (name,phone,address,notes) values(@name,@phone,@address,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtname.Text = "";
                txtphone.Text = "";
                txtaddress.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تمت عمليه الاضافه");
            }
        }
        #endregion

        //cell click client gride
        private void clientgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (clientgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    clientgrid.CurrentRow.Selected = true;
                    id = int.Parse(clientgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    txtname.Text = clientgrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtphone.Text = clientgrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtaddress.Text = clientgrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtnotes.Text = clientgrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    btnadd.Enabled = false;
                }
            }
            catch (Exception ex) { }
        }

       #region UPDATE_CLIENT
        private void btnedite_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update CLIENT set name=@name,phone=@phone,address=@address,notes =@notes where id = '" + id + "'", conn);
                cmd.Parameters.AddWithValue("@name", txtname.Text.ToString());
                cmd.Parameters.AddWithValue("@phone", txtphone.Text.ToString());
                cmd.Parameters.AddWithValue("@address", txtaddress.Text.ToString());
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
                txtname.Text = "";
                txtphone.Text = "";
                txtaddress.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تم التعديل");
                id = 0;
                btnadd.Enabled = true;
            }
        }
         #endregion

        #region DELET_CLIENT
        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                foreach (DataGridViewRow row in clientgrid.SelectedRows)
                {
                    clientgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from CLIENT where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    txtname.Text = "";
                    txtphone.Text = "";
                    txtaddress.Text = "";
                    txtnotes.Text = "";
                    MessageBox.Show("تم الحذف");
                    id = 0;
                    btnadd.Enabled = true;
                }
            }
        }

        #endregion

        //txtname_ changed
        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtname.Text, "[0-9.*]"))
            {
                MessageBox.Show("يجب ادخال حروف فقط");
                txtname.Text = txtname.Text.Remove(txtname.Text.Length - 1);
            }     
        }
        // txtphone_changed
        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtphone.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtphone.Text = txtphone.Text.Remove(txtphone.Text.Length - 1);
            }
        }
        // txtsarch_changed
        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select id, name as الإسم,phone as الهاتف,address as العنوان ,notes as ملاحظات from CLIENT where name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            clientgrid.DataSource = dt;
            conn.Close();
        }

    }

}
