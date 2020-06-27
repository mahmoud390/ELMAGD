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
    public partial class Receipts_Client : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Receipts_Client()
        {
            InitializeComponent();
        }

        private void Receipts_Client_Load(object sender, EventArgs e)
        {
            BindGrid();
            Loadclient();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select RESEIPTS_CLIENT.id, RESEIPTS_CLIENT.date as التاريخ,CLIENT.name as الإسم ,RESEIPTS_CLIENT.value as المبلغ,RESEIPTS_CLIENT.notes as الملاحظات from RESEIPTS_CLIENT inner join CLIENT on RESEIPTS_CLIENT.client_id =CLIENT.id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            client_receiptsgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void Loadclient()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From CLIENT", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر العميل---";
            dt.Rows.InsertAt(dr, 0);
            comboclient.ValueMember = "id";
            comboclient.DisplayMember = "name";
            comboclient.DataSource = dt;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if ((int)comboclient.SelectedIndex == 0)
            {
                MessageBox.Show("اختر المورد");
            }
            else if (txtvalue.Text.Equals(""))
            {
                MessageBox.Show("برجاء ادخال المبلغ");
                txtvalue.Focus();
            }
            else
            {
                conn.Open();
                cmd.CommandText = @"insert into RESEIPTS_CLIENT (client_id,value,date,notes) values(@client_id,@value,@date,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@client_id", (int)comboclient.SelectedValue);
                cmd.Parameters.AddWithValue("@value", double.Parse(txtvalue.Text));
                cmd.Parameters.AddWithValue("@date", cllientreceiptdate.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtvalue.Text = "";
                txtnotes.Text = "";
                comboclient.SelectedIndex = 0;
                MessageBox.Show("تمت عمليه الاضافه");
            }
        }

        private void client_receiptsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (client_receiptsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
            else
            {
                client_receiptsgrid.CurrentRow.Selected = true;
                id = int.Parse(client_receiptsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtvalue.Text = client_receiptsgrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtnotes.Text = client_receiptsgrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
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
                SqlCommand cmd = new SqlCommand("update RESEIPTS_CLIENT set value=@value,notes =@notes where id = '" + id + "'", conn);
                cmd.Parameters.AddWithValue("@value", double.Parse(txtvalue.Text));
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
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
                foreach (DataGridViewRow row in client_receiptsgrid.SelectedRows)
                {
                    client_receiptsgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from RESEIPTS_CLIENT where id = '" + id + "'";
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

        private void txtvalue_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtvalue.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtvalue.Text = txtvalue.Text.Remove(txtvalue.Text.Length - 1);
            }
        }
    }
}
