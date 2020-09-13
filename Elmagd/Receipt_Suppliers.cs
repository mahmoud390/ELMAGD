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
    public partial class Receipt_Suppliers : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public Receipt_Suppliers()
        {
            InitializeComponent();
        }

        #region LOAD_PAGE
        private void Receipt_Suppliers_Load(object sender, EventArgs e)
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
            cmd.CommandText = @"select RECEIPT_SUPPLIERS.id as م, RECEIPT_SUPPLIERS.date as التاريخ,SUPPLIERS.name as الإسم ,RECEIPT_SUPPLIERS.value as المبلغ,RECEIPT_SUPPLIERS.notes as الملاحظات from RECEIPT_SUPPLIERS inner join SUPPLIERS on RECEIPT_SUPPLIERS.suppliers_id =SUPPLIERS.id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sup_receiptsgrid.DataSource = dt;
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

        #region ADD_RECEIPT_SUPPLIERS
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
                cmd.CommandText = @"insert into RECEIPT_SUPPLIERS (suppliers_id,value,date,notes) values(@suppliers_id,@value,@date,@notes)";
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
            }
        }
        #endregion

        #region GRID_CELLCLICK
        private void sup_receiptsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (sup_receiptsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    sup_receiptsgrid.CurrentRow.Selected = true;
                    id = int.Parse(sup_receiptsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    txtvalue.Text = sup_receiptsgrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtnotes.Text = sup_receiptsgrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    btnadd.Enabled = false;
                }
            }
            catch (Exception ex) { }
        }
        #endregion

        #region EDITE_RECEIPT_SUPPLIERS
        private void btnedite_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update RECEIPT_SUPPLIERS set value=@value,notes =@notes where id = '" + id + "'", conn);
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

        #region DELET_RECEIPT_SUPPLIERS
        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                foreach (DataGridViewRow row in sup_receiptsgrid.SelectedRows)
                {
                    sup_receiptsgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from RECEIPT_SUPPLIERS where id = '" + id + "'";
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
            SqlDataAdapter dataadapter = new SqlDataAdapter("select RECEIPT_SUPPLIERS.id, RECEIPT_SUPPLIERS.date as التاريخ,SUPPLIERS.name as الإسم ,RECEIPT_SUPPLIERS.value as المبلغ,RECEIPT_SUPPLIERS.notes as الملاحظات from RECEIPT_SUPPLIERS inner join SUPPLIERS on RECEIPT_SUPPLIERS.suppliers_id =SUPPLIERS.id where SUPPLIERS.name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            sup_receiptsgrid.DataSource = dt;
            conn.Close();
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
    }
}
