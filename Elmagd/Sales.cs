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
    public partial class Sales : Form
    {
        int quantitytypefromclient, cat,id,store,updatequantitytype=0;
        double total, rest,updatequantity=0;
        double quantityfromclient=0;
        double quantityfrom_store=0;
        int quntitytype_store=0;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Sales()
        {
            InitializeComponent();
        }

        #region LOAD_PAGE
        private void Sales_Load(object sender, EventArgs e)
        {
            BindGrid();
            Loadquantity_type();
            Loadstore();
            Loadcategory();
            Loadclient();
        }
        #endregion

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select CLIENT_INVOICE.id as م,invoiceNo as 'رقم الفاتورة',CLIENT.name as 'إسم العميل',CATEGORY.name as 'الصنف',CLIENT_INVOICE.quantity as الكمية, STORE.name as المخزن,QUANTITY_TYPE.name as 'نوع الكمية',CLIENT_INVOICE.price as السعر,CLIENT_INVOICE.total as الإجمالي,CLIENT_INVOICE.biskoul as بسكول,CLIENT_INVOICE.mashal as مشال,CLIENT_INVOICE.commission as عمولات,CLIENT_INVOICE.rest as 'الإجمالي بعد الإضافات',CLIENT_INVOICE.paid as المدفوع,CLIENT_INVOICE.baky as الباقي,CLIENT_INVOICE.date as التاريخ from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id inner join CATEGORY on CLIENT_INVOICE.cat_id =CATEGORY.id inner join QUANTITY_TYPE on CLIENT_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on CLIENT_INVOICE.store_id =STORE.id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            salesgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        #region SEARCH
        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select CLIENT_INVOICE.id as م,invoiceNo as 'رقم الفاتورة',CLIENT.name as 'إسم العميل',CATEGORY.name as 'الصنف',CLIENT_INVOICE.quantity as الكمية, STORE.name as المخزن,QUANTITY_TYPE.name as 'نوع الكمية',CLIENT_INVOICE.price as السعر,CLIENT_INVOICE.total as الإجمالي,CLIENT_INVOICE.biskoul as بسكول,CLIENT_INVOICE.mashal as مشال,CLIENT_INVOICE.commission as عمولات,CLIENT_INVOICE.rest as 'الإجمالي بعد الإضافات',CLIENT_INVOICE.paid as المدفوع,CLIENT_INVOICE.baky as الباقي,CLIENT_INVOICE.date as التاريخ from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id inner join CATEGORY on CLIENT_INVOICE.cat_id =CATEGORY.id inner join QUANTITY_TYPE on CLIENT_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on CLIENT_INVOICE.store_id =STORE.id where CLIENT.name  LIKE N'%" + txtSarch.Text + "% '", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            salesgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void salesgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (salesgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    salesgrid.CurrentRow.Selected = true;
                    id = int.Parse(salesgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    txtInvoiceNo.Text = salesgrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    comboclient.Text = salesgrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    combocategory.Text = salesgrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    combostore.Text = salesgrid.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    txtquantity.Text = salesgrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    comboquantitytype.Text = salesgrid.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    txtprice.Text = salesgrid.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                    txttotal.Text = salesgrid.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                    txtbskoul.Text = salesgrid.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                    txtmashal.Text = salesgrid.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                    txtcommestion.Text = salesgrid.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
                    txtrest.Text = salesgrid.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
                    txtpaid.Text = salesgrid.Rows[e.RowIndex].Cells[13].FormattedValue.ToString();
                    txtbaky.Text = salesgrid.Rows[e.RowIndex].Cells[14].FormattedValue.ToString();


                }
            }
            catch (Exception ex) { }
        }

        private void btnupdat_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {

                //  شلكيت الكمية من فاتوره المبيعات علي حسب اي دي
                conn.Open();
                cmd.CommandText = @"select quantity,quantitytype_id,cat_id,store_id from CLIENT_INVOICE where CLIENT_INVOICE.id ='" + id + "' ";
                cmd.Connection = conn;
                SqlDataReader read_quantity = cmd.ExecuteReader();
                while (read_quantity.Read())
                {
                    quantityfromclient = double.Parse(read_quantity[0].ToString());
                    quantitytypefromclient = int.Parse(read_quantity[1].ToString());
                    cat = int.Parse(read_quantity[2].ToString());
                    store = int.Parse(read_quantity[3].ToString());
                }
                conn.Close();
                //-------------------------
                conn.Open();
                cmd.CommandText = @"select quantity,quantitytype_id from MAIN_STORE where store_id='" + store + "' and cat_id ='" + cat + "' ";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    quantityfrom_store = double.Parse(reader[0].ToString());
                    quntitytype_store = int.Parse(reader[1].ToString());
                }
                conn.Close();
                // ابديت الاستور

                if (quantitytypefromclient == quntitytype_store)
                    quantitytypefromclient = quantitytypefromclient;
                else if (quntitytype_store == 1 && quantitytypefromclient == 2)
                {
                    quantitytypefromclient = quantitytypefromclient * 1000;
                }
                else if (quntitytype_store == 2 && quantitytypefromclient == 1)
                {
                    quantitytypefromclient = quantitytypefromclient / 1000;
                }
                conn.Open();
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity +'" + quantitytypefromclient + "' where store_id = '" + store + "'and cat_id ='" + cat + "'";//and quantitytype_id ='" + quantitytype + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                //---------------------------------------------------------
                conn.Open();
                cmd.CommandText = @"update CLIENT_INVOICE set client_id=@client_id,store_id=@store_id,quantity=@quantity,quantitytype_id =@quantitytype_id,price=@price,total=@total,biskoul=@biskoul,mashal=@mashal,commission=@commission,cat_id=@cat_id,rest=@rest,paid=@paid,baky=@baky,invoiceNo=@invoiceNo where id = '" + id + "'";
                cmd.Parameters.AddWithValue("@client_id", (int)comboclient.SelectedValue);
                cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                cmd.Parameters.AddWithValue("@quantity", double.Parse(txtquantity.Text));
                cmd.Parameters.AddWithValue("@quantitytype_id", (int)comboquantitytype.SelectedValue);
                cmd.Parameters.AddWithValue("@price", double.Parse(txtprice.Text));
                cmd.Parameters.AddWithValue("@total", double.Parse(txttotal.Text));
                cmd.Parameters.AddWithValue("@biskoul", txtbskoul.Text);
                cmd.Parameters.AddWithValue("@mashal", txtmashal.Text);
                cmd.Parameters.AddWithValue("@commission", txtcommestion.Text);
                cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
                cmd.Parameters.AddWithValue("@rest", txtrest.Text);
                cmd.Parameters.AddWithValue("@paid", txtpaid.Text);
                cmd.Parameters.AddWithValue("@baky", txtbaky.Text);
                cmd.Parameters.AddWithValue("@invoiceNo", txtInvoiceNo.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
                //-----------------------------
                updatequantity = double.Parse(txtquantity.Text);
                updatequantitytype = (int)comboquantitytype.SelectedValue;
                conn.Open();
                cmd.CommandText = @"select quantity,quantitytype_id from MAIN_STORE where store_id='" + (int)combostore.SelectedValue + "' and cat_id ='" + (int)combocategory.SelectedValue + "' ";
                cmd.Connection = conn;
                SqlDataReader reader_store = cmd.ExecuteReader();
                while (reader_store.Read())
                {
                    quantityfrom_store = double.Parse(reader_store[0].ToString());
                    quntitytype_store = int.Parse(reader_store[1].ToString());
                }
                conn.Close();
                if (updatequantitytype == quntitytype_store)
                    updatequantity = updatequantity;
                else if (quntitytype_store == 1 && updatequantitytype == 2)
                {
                    updatequantity = updatequantity * 1000;
                }
                else if (quntitytype_store == 2 && updatequantitytype == 1)
                {
                    updatequantity = updatequantity / 1000;
                }
                conn.Open();
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity -'" + updatequantity + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'";//and quantitytype_id ='" + quantitytype + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                MessageBox.Show("تمت عملية التعديل بنجاح");

            }
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                cmd.CommandText = @"select quantity,quantitytype_id,cat_id,store_id from CLIENT_INVOICE where CLIENT_INVOICE.id ='" + id + "' ";
                cmd.Connection = conn;
                SqlDataReader read_quantity = cmd.ExecuteReader();
                while (read_quantity.Read())
                {
                    quantityfromclient = double.Parse(read_quantity[0].ToString());
                    quantitytypefromclient = int.Parse(read_quantity[1].ToString());
                    cat = int.Parse(read_quantity[2].ToString());
                    store = int.Parse(read_quantity[3].ToString());
                }
                conn.Close();
                //-------------------------
                conn.Open();
                cmd.CommandText = @"select quantity,quantitytype_id from MAIN_STORE where store_id='" + store + "' and cat_id ='" + cat + "' ";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    quantityfrom_store = double.Parse(reader[0].ToString());
                    quntitytype_store = int.Parse(reader[1].ToString());
                }
                conn.Close();
                // ابديت الاستور

                if (quantitytypefromclient == quntitytype_store)
                    quantitytypefromclient = quantitytypefromclient;
                else if (quntitytype_store == 1 && quantitytypefromclient == 2)
                {
                    quantitytypefromclient = quantitytypefromclient * 1000;
                }
                else if (quntitytype_store == 2 && quantitytypefromclient == 1)
                {
                    quantitytypefromclient = quantitytypefromclient / 1000;
                }
                conn.Open();
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity +'" + quantitytypefromclient + "' where store_id = '" + store + "'and cat_id ='" + cat + "'";//and quantitytype_id ='" + quantitytype + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                foreach (DataGridViewRow row in salesgrid.SelectedRows)
                {
                    //حذف حركة الخزنة
                    conn.Open();
                    cmd.CommandText = @"delete from CASHIER where clientinvoice_id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("تم الحذف");
                    //-------------------------
                    salesgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from CLIENT_INVOICE where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    //----------------------------
                   
                    

                }
            }
        }
        #region  QUANTITY_TYPE
        private void Loadquantity_type()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From QUANTITY_TYPE", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر نوع الكمية---";
            dt.Rows.InsertAt(dr, 0);
            comboquantitytype.ValueMember = "id";
            comboquantitytype.DisplayMember = "name";
            comboquantitytype.DataSource = dt;
        }
        #endregion

        #region LOAD STORE
        private void Loadstore()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From STORE", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر المخزن---";
            dt.Rows.InsertAt(dr, 0);
            combostore.ValueMember = "id";
            combostore.DisplayMember = "name";
            combostore.DataSource = dt;
        }
        #endregion

        #region LOADCATRGORY
        private void Loadcategory()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From CATEGORY", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر الصنف---";
            dt.Rows.InsertAt(dr, 0);
            combocategory.ValueMember = "id";
            combocategory.DisplayMember = "name";
            combocategory.DataSource = dt;
        }
        #endregion

        #region LOAD_CLIENT
        private void Loadclient()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From CLIENT", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر عميل---";
            dt.Rows.InsertAt(dr, 0);
            comboclient.ValueMember = "id";
            comboclient.DisplayMember = "name";
            comboclient.DataSource = dt;
        }
        #endregion

        private void btnsarch_Click(object sender, EventArgs e)
        {
            if ((int)comboclient.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار عميل");
            else
            {
                conn.Open();
                cmd.CommandText = @"select CLIENT_INVOICE.id as م,invoiceNo as 'رقم الفاتورة',CLIENT.name as 'إسم العميل',CATEGORY.name as 'الصنف',CLIENT_INVOICE.quantity as الكمية, STORE.name as المخزن,QUANTITY_TYPE.name as 'نوع الكمية',CLIENT_INVOICE.price as السعر,CLIENT_INVOICE.total as الإجمالي,CLIENT_INVOICE.biskoul as بسكول,CLIENT_INVOICE.mashal as مشال,CLIENT_INVOICE.commission as عمولات,CLIENT_INVOICE.rest as 'الإجمالي بعد الإضافات',CLIENT_INVOICE.paid as المدفوع,CLIENT_INVOICE.baky as الباقي,CLIENT_INVOICE.date as التاريخ from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id inner join CATEGORY on CLIENT_INVOICE.cat_id =CATEGORY.id inner join QUANTITY_TYPE on CLIENT_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on CLIENT_INVOICE.store_id =STORE.id where CLIENT_INVOICE.client_id ='" + (int)comboclient.SelectedValue + "' CLIENT_INVOICE.date between '" + datefrom.Value.Date.ToShortDateString() + "'" + " and '" + dateto.Value.Date.ToShortDateString() + "' ";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                salesgrid.DataSource = dt;
                conn.Close();
            }
        }
    }
}
