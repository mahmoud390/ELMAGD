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
    public partial class General_payments : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public General_payments()
        {
            InitializeComponent();
        }

        private void General_payments_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select GENERAL_PAYMENTS.id, GENERAL_PAYMENTS.name as الاسم  ,GENERAL_PAYMENTS.value as المبلغ,GENERAL_PAYMENTS.notes as الملاحظات ,GENERAL_PAYMENTS.date as التاريخ from GENERAL_PAYMENTS ";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            generalpaymentgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("برجاء إدخال الاسم");
            }
            else if (txtvalue.Text.Equals(""))
            {
                MessageBox.Show("برجاء إدخال المبلغ");
            }
            else
            {
                conn.Open();
                cmd.CommandText = @"insert into GENERAL_PAYMENTS (name,value,date,notes) values(@name,@value,@date,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@value", double.Parse(txtvalue.Text));
                cmd.Parameters.AddWithValue("@date", generaldate.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtvalue.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تمت عمليه الاضافه");
            }
        }

        private void generalpaymentgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (generalpaymentgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
            else
            {
                generalpaymentgrid.CurrentRow.Selected = true;
                id = int.Parse(generalpaymentgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtname.Text = generalpaymentgrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtvalue.Text = generalpaymentgrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtnotes.Text = generalpaymentgrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                btnadd.Enabled = false;
            }
        }

        private void btnedite_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update GENERAL_PAYMENTS set name=@name,value=@value,notes =@notes where id = '" + id + "'", conn);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@value", double.Parse(txtvalue.Text));
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
                txtname.Text = "";
                txtvalue.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تم التعديل");
                id = 0;
                btnadd.Enabled = true;
            }
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                foreach (DataGridViewRow row in generalpaymentgrid.SelectedRows)
                {
                    generalpaymentgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from GENERAL_PAYMENTS where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    txtvalue.Text = "";
                    txtnotes.Text = "";
                    MessageBox.Show("تم الحذف");
                    id = 0;
                    btnadd.Enabled = true;
                }
            }
        }

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select GENERAL_PAYMENTS.id, GENERAL_PAYMENTS.name as الاسم  ,GENERAL_PAYMENTS.value as المبلغ,GENERAL_PAYMENTS.notes as الملاحظات ,GENERAL_PAYMENTS.date as التاريخ from GENERAL_PAYMENTS  where GENERAL_PAYMENTS.name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            generalpaymentgrid.DataSource = dt;
            conn.Close();
        }

        private void txtvalue_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtvalue.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtvalue.Text = txtvalue.Text.Remove(txtvalue.Text.Length - 1);
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
