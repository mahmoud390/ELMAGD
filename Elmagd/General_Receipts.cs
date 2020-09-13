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
    public partial class General_Receipts : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public General_Receipts()
        {
            InitializeComponent();
        }

        private void General_Receipts_Load(object sender, EventArgs e)
        {
            generaldate.Value = DateTime.Now;
            BindGrid();
            Loadrecepitsitem();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select GENERAL_RECEIPTS.id as م, GENERAL_RECEIPTS_ITEMS.name as 'بند المقبوضات العامة'  ,GENERAL_RECEIPTS.value as المبلغ,GENERAL_RECEIPTS.notes as الملاحظات ,GENERAL_RECEIPTS.date as التاريخ from GENERAL_RECEIPTS inner join GENERAL_RECEIPTS_ITEMS on GENERAL_RECEIPTS_ITEMS.id =GENERAL_RECEIPTS.recepitsitems_id ";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            generalgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void Loadrecepitsitem()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From GENERAL_RECEIPTS_ITEMS", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر بند---";
            dt.Rows.InsertAt(dr, 0);
            comborecepitsitem.ValueMember = "id";
            comborecepitsitem.DisplayMember = "name";
            comborecepitsitem.DataSource = dt;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if ((int)comborecepitsitem.SelectedIndex==0)
            {
                MessageBox.Show("برجاءاخيار بند المقبوضات العامة");
            }
            else if (txtvalue.Text.Equals(""))
            {
                MessageBox.Show("برجاء إدخال المبلغ");
            }
            else
            {
                conn.Open();
                cmd.CommandText = @"insert into GENERAL_RECEIPTS (recepitsitems_id,value,date,notes) values(@recepitsitems_id,@value,@date,@notes)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@recepitsitems_id", (int)comborecepitsitem.SelectedValue);
                cmd.Parameters.AddWithValue("@value", double.Parse(txtvalue.Text));
                cmd.Parameters.AddWithValue("@date", generaldate.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                comborecepitsitem.SelectedIndex = 0;
                txtvalue.Text = "";
                txtnotes.Text = "";
                MessageBox.Show("تمت عمليه الاضافه");
                //-------------------------------------
                conn.Open();
                cmd.CommandText = @"select id from GENERAL_RECEIPTS where GENERAL_RECEIPTS.date = '" + generaldate.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into CASHIER (generalreseipts_id,date) values(@generalreseipts_id,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@generalreseipts_id", id);
                cmd.Parameters.AddWithValue("@date", generaldate.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
        }

        private void generalgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (generalgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    generalgrid.CurrentRow.Selected = true;
                    id = int.Parse(generalgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    comborecepitsitem.Text = generalgrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtvalue.Text = generalgrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtnotes.Text = generalgrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
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
                SqlCommand cmd = new SqlCommand("update GENERAL_RECEIPTS set recepitsitems_id=@recepitsitems_id,value=@value,notes =@notes where id = '" + id + "'", conn);
                cmd.Parameters.AddWithValue("@recepitsitems_id",(int)comborecepitsitem.SelectedValue);
                cmd.Parameters.AddWithValue("@value", double.Parse(txtvalue.Text));
                cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
                comborecepitsitem.SelectedIndex = 0;
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
                foreach (DataGridViewRow row in generalgrid.SelectedRows)
                {
                    generalgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from GENERAL_RECEIPTS where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    comborecepitsitem.SelectedIndex = 0;
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
            SqlDataAdapter dataadapter = new SqlDataAdapter("select GENERAL_RECEIPTS.id, GENERAL_RECEIPTS_ITEMS.name as بند_المقبوضات_العامة  ,GENERAL_RECEIPTS.value as المبلغ,GENERAL_RECEIPTS.notes as الملاحظات ,GENERAL_RECEIPTS.date as التاريخ from GENERAL_RECEIPTS inner join GENERAL_RECEIPTS_ITEMS on GENERAL_RECEIPTS_ITEMS.id =GENERAL_RECEIPTS.recepitsitems_id  where GENERAL_RECEIPTS_ITEMS.name  LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            generalgrid.DataSource = dt;
            conn.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtvalue_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtvalue.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtvalue.Text = txtvalue.Text.Remove(txtvalue.Text.Length - 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void txtname_TextChanged(object sender, EventArgs e)
        //{
        //    if (System.Text.RegularExpressions.Regex.IsMatch(txtname.Text, "[0-9.*]"))
        //    {
        //        MessageBox.Show("يجب ادخال حروف فقط");
        //        txtname.Text = txtname.Text.Remove(txtname.Text.Length - 1);
        //    }    
        //}
    }
}

