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
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public General_payments()
        {
            InitializeComponent();
        }

        private void General_payments_Load(object sender, EventArgs e)
        {
            generaldate.Value = DateTime.Now;
            BindGrid();
            Loadpaymentitem();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select GENERAL_PAYMENTS.id, GENERAL_PAYMENT_ITEMS.name as بند_المدفوعات_العامة  ,GENERAL_PAYMENTS.value as المبلغ,GENERAL_PAYMENTS.notes as الملاحظات ,GENERAL_PAYMENTS.date as التاريخ from GENERAL_PAYMENTS inner join GENERAL_PAYMENT_ITEMS on GENERAL_PAYMENT_ITEMS.id = GENERAL_PAYMENTS.paymentitems_id ";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            generalpaymentgrid.DataSource = dt;
            conn.Close();
        }
        #endregion
        private void Loadpaymentitem()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From GENERAL_PAYMENT_ITEMS", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر بند---";
            dt.Rows.InsertAt(dr, 0);
            combopaymentitem.ValueMember = "id";
            combopaymentitem.DisplayMember = "name";
            combopaymentitem.DataSource = dt;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if ((int)combopaymentitem.SelectedIndex==0)
            {
                MessageBox.Show("برجاء اختير بند المدفوعات العامة");
            }
            else if (txtvalue.Text.Equals(""))
            {
                MessageBox.Show("برجاء إدخال المبلغ");
            }
            else
            {
                conn.Open();
                cmd.CommandText = @"insert into GENERAL_PAYMENTS (paymentitems_id,value,date,notes) values(@paymentitems_id,@value,@date,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@paymentitems_id", (int)combopaymentitem.SelectedValue);
                cmd.Parameters.AddWithValue("@value", double.Parse(txtvalue.Text));
                cmd.Parameters.AddWithValue("@date", generaldate.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                combopaymentitem.SelectedIndex = 0;
                txtvalue.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تمت عمليه الاضافه");
                //----------------------------------------------------
                //حركات الخزنة
                conn.Open();
                cmd.CommandText = @"select id from GENERAL_PAYMENTS where GENERAL_PAYMENTS.date = '" + generaldate.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into CASHIER (generalpayments_id,date) values(@generalpayments_id,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@generalpayments_id", id);
                cmd.Parameters.AddWithValue("@date", generaldate.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
        }

        private void generalpaymentgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (generalpaymentgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    generalpaymentgrid.CurrentRow.Selected = true;
                    id = int.Parse(generalpaymentgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    combopaymentitem.Text = generalpaymentgrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtvalue.Text = generalpaymentgrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtnotes.Text = generalpaymentgrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    btnadd.Enabled = false;
                }
            }
            catch (Exception ex) { }
        }

        private void btnedite_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update GENERAL_PAYMENTS set paymentitems_id=@paymentitems_id,value=@value,notes =@notes where id = '" + id + "'", conn);
                cmd.Parameters.AddWithValue("@paymentitems_id", (int)combopaymentitem.SelectedValue);
                cmd.Parameters.AddWithValue("@value", double.Parse(txtvalue.Text));
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
                combopaymentitem.SelectedIndex = 0;
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
                    combopaymentitem.SelectedIndex = 0;
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
            SqlDataAdapter dataadapter = new SqlDataAdapter("select GENERAL_PAYMENTS.id, GENERAL_PAYMENT_ITEMS.name as بند_المدفوعات_العامة  ,GENERAL_PAYMENTS.value as المبلغ,GENERAL_PAYMENTS.notes as الملاحظات ,GENERAL_PAYMENTS.date as التاريخ from GENERAL_PAYMENTS inner join GENERAL_PAYMENT_ITEMS on GENERAL_PAYMENT_ITEMS.id = GENERAL_PAYMENTS.paymentitems_id  where GENERAL_PAYMENT_ITEMS.name LIKE N'%" + txtSarch.Text + "%'", conn);
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

        //private void txtname_TextChanged(object sender, EventArgs e)
        //{
        //    if (System.Text.RegularExpressions.Regex.IsMatch(txtname.Text, "[0-9.*]"))
        //    {
        //        MessageBox.Show("يجب ادخال حروف فقط");
        //        txtname.Text = txtname.Text.Remove(txtname.Text.Length - 1);
        //    }    
        //}

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
