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
    public partial class Payments_Suppliers : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Payments_Suppliers()
        {
            InitializeComponent();
        }

        #region LOAD_PAGE
        private void Payments_Suppliers_Load(object sender, EventArgs e)
        {
            suppaymentdate.Value = DateTime.Now;
            BindGrid();
            Loadsuppliers();
        }
        #endregion

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select PAYMENTS_SUPPLIERS.id, PAYMENTS_SUPPLIERS.date as التاريخ,SUPPLIERS.name as الإسم ,PAYMENTS_SUPPLIERS.value as المبلغ,PAYMENTS_SUPPLIERS.notes as الملاحظات from PAYMENTS_SUPPLIERS inner join SUPPLIERS on PAYMENTS_SUPPLIERS.suppliers_id =SUPPLIERS.id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sup_paymentsgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        #region LOAD_SUPPLIERS
        private void Loadsuppliers()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From SUPPLIERS", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر المورد---";
            dt.Rows.InsertAt(dr, 0);
            combosuppliers.ValueMember = "id";
            combosuppliers.DisplayMember = "name";
            combosuppliers.DataSource = dt;
        }
        #endregion

        #region TEXTCHANGED_TXTVALUE
        private void txtvalue_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtvalue.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtvalue.Text = txtvalue.Text.Remove(txtvalue.Text.Length - 1);
            }
        }
        #endregion


        #region ADD_PAYMENTS_SUPPLIERS
        private void btnadd_Click(object sender, EventArgs e)
        {
            if ((int)combosuppliers.SelectedIndex == 0)
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
                cmd.CommandText = @"insert into PAYMENTS_SUPPLIERS (suppliers_id,value,date,notes) values(@suppliers_id,@value,@date,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@suppliers_id", (int)combosuppliers.SelectedValue);
                cmd.Parameters.AddWithValue("@value", double.Parse(txtvalue.Text));
                cmd.Parameters.AddWithValue("@date", suppaymentdate.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtvalue.Text = "";
                txtnotes.Text = "";
                combosuppliers.SelectedIndex = 0;
                MessageBox.Show("تمت عمليه الاضافه");
                //----------------------------------------------------
                conn.Open();
                cmd.CommandText = @"select id from PAYMENTS_SUPPLIERS where PAYMENTS_SUPPLIERS.date = '" + suppaymentdate.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into CASHIER (paymentsuppliers_id,date) values(@paymentsuppliers_id,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@paymentsuppliers_id", id);
                cmd.Parameters.AddWithValue("@date", suppaymentdate.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
        }
        #endregion

        #region GRID_CELLCLICK
        private void sup_paymentsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (sup_paymentsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    sup_paymentsgrid.CurrentRow.Selected = true;
                    id = int.Parse(sup_paymentsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    txtvalue.Text = sup_paymentsgrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtnotes.Text = sup_paymentsgrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    btnadd.Enabled = false;
                }
            }
            catch (Exception ex) { }

        }
        #endregion

        #region EDITE_PAYMENTS_SUPPLIERS
        private void btnedite_Click(object sender, EventArgs e)
        {

            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update PAYMENTS_SUPPLIERS set value=@value,notes =@notes where id = '" + id + "'", conn);
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
        #endregion

        #region DELET_PAYMENTS_SUPPLIERS
        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                foreach (DataGridViewRow row in sup_paymentsgrid.SelectedRows)
                {
                    sup_paymentsgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from PAYMENTS_SUPPLIERS where id = '" + id + "'";
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
        #endregion

        #region SEARCH
        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select PAYMENTS_SUPPLIERS.id, PAYMENTS_SUPPLIERS.date as التاريخ,SUPPLIERS.name as الإسم ,PAYMENTS_SUPPLIERS.value as المبلغ,PAYMENTS_SUPPLIERS.notes as الملاحظات from PAYMENTS_SUPPLIERS inner join SUPPLIERS on PAYMENTS_SUPPLIERS.suppliers_id =SUPPLIERS.id where SUPPLIERS.name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            sup_paymentsgrid.DataSource = dt;
            conn.Close();
        }
        #endregion
    }
}
