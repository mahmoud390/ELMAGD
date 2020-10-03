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
    public partial class Incomes : Form
    {
        int quantitytypefromsupp, cat, id, store, updatequantitytype = 0;
        double total, rest, updatequantity = 0;
        double quantityfromsupp = 0;
        double quantityfrom_store = 0;
        int quntitytype_store = 0;


        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Incomes()
        {
            InitializeComponent();
        }

        private void Incomes_Load(object sender, EventArgs e)
        {
            BindGrid();
            Loadquantity_type();
            Loadsuppliers();
            Loadstore();
            Loadcategory();
        }
        #region BINDGRID
        private void BindGrid()
        {
            try
            {
                conn.Open();
                cmd.CommandText = @"select SUPPLIERS_INVOICE.id as م , SUPPLIERS_INVOICE.invoiceNo as 'رقم الفاتورة',SUPPLIERS.name as 'المورد',CATEGORY.name as الصنف,STORE.name as المخزن,SUPPLIERS_INVOICE.quantity as الكمية,QUANTITY_TYPE.name as 'نوع الكمية',SUPPLIERS_INVOICE.price as السعر,SUPPLIERS_INVOICE.total as الإجمالي,SUPPLIERS_INVOICE.biskoul as بسكول,SUPPLIERS_INVOICE.mashal as مشال,SUPPLIERS_INVOICE.commissions as عمولات,SUPPLIERS_INVOICE.rest as 'الإجمالي بعد الخصومات',SUPPLIERS_INVOICE.paid as المدفوع,SUPPLIERS_INVOICE.baky as الباقي,SUPPLIERS_INVOICE.date as التاريخ from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id =SUPPLIERS.id inner join CATEGORY on SUPPLIERS_INVOICE.catid =CATEGORY.id inner join QUANTITY_TYPE on SUPPLIERS_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on SUPPLIERS_INVOICE.store_id =STORE.id";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                incomesgrid.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }
        #endregion

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
           SqlDataAdapter dataadapter = new SqlDataAdapter("select SUPPLIERS_INVOICE.id,SUPPLIERS.name,CATEGORY.name,SUPPLIERS_INVOICE.quantity,QUANTITY_TYPE.name,SUPPLIERS_INVOICE.price,SUPPLIERS_INVOICE.total,SUPPLIERS_INVOICE.biskoul,SUPPLIERS_INVOICE.mashal,SUPPLIERS_INVOICE.commissions,SUPPLIERS_INVOICE.rest,SUPPLIERS_INVOICE.paid,SUPPLIERS_INVOICE.baky from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id =SUPPLIERS.id inner join CATEGORY on SUPPLIERS_INVOICE.catid =CATEGORY.id inner join QUANTITY_TYPE on SUPPLIERS_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on SUPPLIERS_INVOICE.store_id =STORE.id where SUPPLIERS.name  LIKE N'%" + txtSarch.Text + "% '", conn);
           // SqlDataAdapter dataadapter = new SqlDataAdapter("select SUPPLIERS_INVOICE.id,SUPPLIERS.name,CATEGORY.name,SUPPLIERS_INVOICE.quantity,QUANTITY_TYPE.name,SUPPLIERS_INVOICE.price,SUPPLIERS_INVOICE.total,SUPPLIERS_INVOICE.biskoul,SUPPLIERS_INVOICE.mashal,SUPPLIERS_INVOICE.commissions,SUPPLIERS_INVOICE.rest,SUPPLIERS_INVOICE.paid,SUPPLIERS_INVOICE.baky from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id =SUPPLIERS.id inner join CATEGORY on SUPPLIERS_INVOICE.catid =CATEGORY.id inner join QUANTITY_TYPE on SUPPLIERS_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on SUPPLIERS_INVOICE.store_id =STORE.id where SUPPLIERS.name  ='" + txtSarch.Text + "' and SUPPLIERS_INVOICE.date between '" + datefrom.Value.Date.ToShortDateString() + "'" + " and '" + dateto.Value.Date.ToShortDateString() + "' ", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            incomesgrid.DataSource = dt;
            conn.Close();
        }

        private void incomesgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (incomesgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    incomesgrid.CurrentRow.Selected = true;
                    id = int.Parse(incomesgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    txtInvoiceNo.Text = incomesgrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    combosuppliers.Text = incomesgrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    combocategory.Text = incomesgrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    combostore.Text = incomesgrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    txtquantity.Text = incomesgrid.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    comboquantitytype.Text = incomesgrid.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    txtprice.Text = incomesgrid.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                    txttotal.Text = incomesgrid.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                    txtbskoul.Text = incomesgrid.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                    txtmashal.Text = incomesgrid.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                    txtcommestion.Text = incomesgrid.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
                    txtrest.Text = incomesgrid.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
                    txtpaid.Text = incomesgrid.Rows[e.RowIndex].Cells[13].FormattedValue.ToString();
                    txtbaky.Text = incomesgrid.Rows[e.RowIndex].Cells[14].FormattedValue.ToString();


                }
            }
            catch (Exception ex) { }
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtquantity.Text.Equals(""))
                {
                    MessageBox.Show("برجاء إدخال الكمية");
                }
                else if ((int)comboquantitytype.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختبار نوع الكمية");
                else if (txtprice.Text.Equals(""))
                    MessageBox.Show("برجاء إدخال السعر");
                else
                {
                    double quantity = double.Parse(txtquantity.Text);
                    double price = double.Parse(txtprice.Text);
                    total = quantity * price;
                    txttotal.Text = total.ToString();
                }

            }
            catch (Exception ex) { }
        }

        private void btncalc2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttotal.Text.Equals(""))
                {
                    MessageBox.Show("يجب الضغط علي حساب الاجمالي اولا");
                }
                else
                {
                    if (txtmashal.Text.Equals(""))
                    {
                        txtmashal.Text = "0";
                    }
                    if (txtcommestion.Text.Equals(""))
                    {
                        txtcommestion.Text = "0";
                    }
                    if (txtbskoul.Text.Equals(""))
                    {
                        txtbskoul.Text = "0";
                    }
                    double bskoul = double.Parse(txtbskoul.Text);
                    double mashal = double.Parse(txtmashal.Text);
                    double commession = double.Parse(txtcommestion.Text);
                    rest = total - (bskoul + mashal + commession);
                    txtrest.Text = rest.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void btnbaky_Click(object sender, EventArgs e)
        {
            try
            {
                double paid, baky;
                if (txtrest.Text.Equals(""))
                {
                    MessageBox.Show("برجاء الضغط علي زر حساب الإجمالي بعد الخصومات");
                }
                else if (txtpaid.Text.Equals(""))
                {
                    txtpaid.Text = " 0";
                }
                paid = double.Parse(txtpaid.Text);
                baky = rest - paid;
                txtbaky.Text = baky.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {

                //  شلكيت الكمية من فاتوره المشريات علي حسب اي دي
                conn.Open();
                cmd.CommandText = @"select quantity,quantitytype_id,catid,store_id from SUPPLIERS_INVOICE where SUPPLIERS_INVOICE.id ='" + id + "' ";
                cmd.Connection = conn;
                SqlDataReader read_quantity = cmd.ExecuteReader();
                while (read_quantity.Read())
                {
                    quantityfromsupp = double.Parse(read_quantity[0].ToString());
                    quantitytypefromsupp = int.Parse(read_quantity[1].ToString());
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

                if (quantitytypefromsupp == quntitytype_store)
                    quantityfromsupp = quantityfromsupp;
                else if (quntitytype_store == 1 && quantitytypefromsupp == 2)
                {
                    quantityfromsupp = quantityfromsupp * 1000;
                }
                else if (quntitytype_store == 2 && quantitytypefromsupp == 1)
                {
                    quantityfromsupp = quantityfromsupp / 1000;
                }
                conn.Open();
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity -'" + quantityfromsupp + "' where store_id = '" + store + "'and cat_id ='" + cat + "'";//and quantitytype_id ='" + quantitytype + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();

                //--------------------------------------------------------------------------
                // ابديت  فاتورة المشتريات
                conn.Open();
                cmd.CommandText = @"update SUPPLIERS_INVOICE set suppliers_id=@suppliers_id,store_id=@store_id,quantity=@quantity,quantitytype_id =@quantitytype_id,price=@price,total=@total,biskoul=@biskoul,mashal=@mashal,commissions=@commissions,catid=@catid,rest=@rest,paid=@paid,baky=@baky,invoiceNo=@invoiceNo where id = '" + id + "'";
                cmd.Parameters.AddWithValue("@suppliers_id", (int)combosuppliers.SelectedValue);
                cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                cmd.Parameters.AddWithValue("@quantity", double.Parse(txtquantity.Text));
                cmd.Parameters.AddWithValue("@quantitytype_id", (int)comboquantitytype.SelectedValue);
                cmd.Parameters.AddWithValue("@price", double.Parse(txtprice.Text));
                cmd.Parameters.AddWithValue("@total", double.Parse(txttotal.Text));
                cmd.Parameters.AddWithValue("@biskoul", txtbskoul.Text);
                cmd.Parameters.AddWithValue("@mashal", txtmashal.Text);
                cmd.Parameters.AddWithValue("@commissions", txtcommestion.Text);
                cmd.Parameters.AddWithValue("@catid", (int)combocategory.SelectedValue);
                cmd.Parameters.AddWithValue("@rest", txtrest.Text);
                cmd.Parameters.AddWithValue("@paid", txtpaid.Text);
                cmd.Parameters.AddWithValue("@baky", txtbaky.Text);
                cmd.Parameters.AddWithValue("@invoiceNo", txtInvoiceNo.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
                // -------------------------------------------
                // ابديت الاستور
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
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity +'" + updatequantity + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'";//and quantitytype_id ='" + quantitytype + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();

                MessageBox.Show("تمت عملية التعديل بنجاح");
                clear();
            }
        }

        private void clear()
        {
            txtbskoul.Text = "";
            txtcommestion.Text = "";
            txtmashal.Text = "";
            txtprice.Text = "";
            txtquantity.Text = "";
            txtrest.Text = "";
            txttotal.Text = "";
            txtpaid.Text = "";
            txtbaky.Text = "";
            txtInvoiceNo.Text = "";
            combosuppliers.SelectedIndex = 0;
            combocategory.SelectedIndex = 0;
            comboquantitytype.SelectedIndex = 0;
            combostore.SelectedIndex = 0;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                cmd.CommandText = @"select quantity,quantitytype_id,catid,store_id from SUPPLIERS_INVOICE where SUPPLIERS_INVOICE.id ='" + id + "' ";
                cmd.Connection = conn;
                SqlDataReader read_quantity = cmd.ExecuteReader();
                while (read_quantity.Read())
                {
                    quantityfromsupp = double.Parse(read_quantity[0].ToString());
                    quantitytypefromsupp = int.Parse(read_quantity[1].ToString());
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

                if (quantitytypefromsupp == quntitytype_store)
                    quantityfromsupp = quantityfromsupp;
                else if (quntitytype_store == 1 && quantitytypefromsupp == 2)
                {
                    quantityfromsupp = quantityfromsupp * 1000;
                }
                else if (quntitytype_store == 2 && quantitytypefromsupp == 1)
                {
                    quantityfromsupp = quantityfromsupp / 1000;
                }
                conn.Open();
                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity -'" + quantityfromsupp + "' where store_id = '" + store + "'and cat_id ='" + cat + "'";//and quantitytype_id ='" + quantitytype + "'   ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                //-------------------
                foreach (DataGridViewRow row in incomesgrid.SelectedRows)
                {
                    // حذف الخزنة
                    conn.Open();
                    cmd.CommandText = @"delete from CASHIER where suplliersinvoice_id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    //-----------------------------
                    incomesgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from SUPPLIERS_INVOICE where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    MessageBox.Show("تم الحذف");
                    clear();
                   
                  
                }
            }
        }


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

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsarch_Click(object sender, EventArgs e)
        {
            if ((int)combosuppliers.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبارالمورد");
            else
            {
               
               // SqlDataAdapter dataadapter = new SqlDataAdapter(" select SUPPLIERS_INVOICE.id as م , SUPPLIERS_INVOICE.invoiceNo as 'رقم الفاتورة',SUPPLIERS.name as 'المورد',CATEGORY.name as الصنف,STORE.name as المخزن,SUPPLIERS_INVOICE.quantity as الكمية,QUANTITY_TYPE.name as 'نوع الكمية',SUPPLIERS_INVOICE.price as السعر,SUPPLIERS_INVOICE.total as الإجمالي,SUPPLIERS_INVOICE.biskoul as بسكول,SUPPLIERS_INVOICE.mashal as مشال,SUPPLIERS_INVOICE.commissions as عمولات,SUPPLIERS_INVOICE.rest as 'الإجمالي بعد الخصومات',SUPPLIERS_INVOICE.paid as المدفوع,SUPPLIERS_INVOICE.baky as الباقي,SUPPLIERS_INVOICE.date as التاريخ from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id =SUPPLIERS.id inner join CATEGORY on SUPPLIERS_INVOICE.catid =CATEGORY.id inner join QUANTITY_TYPE on SUPPLIERS_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on SUPPLIERS_INVOICE.store_id =STORE.id where SUPPLIERS.name ='" + (int)combosuppliers.SelectedValue + "' and SUPPLIERS_INVOICE.date between '" + datefrom.Value.Date.ToShortDateString() + "'" + " and '" + dateto.Value.Date.ToShortDateString() + "'  ", conn);
                conn.Open();
                cmd.CommandText = @"select SUPPLIERS_INVOICE.id as م , SUPPLIERS_INVOICE.invoiceNo as 'رقم الفاتورة',SUPPLIERS.name as 'المورد',CATEGORY.name as الصنف,STORE.name as المخزن,SUPPLIERS_INVOICE.quantity as الكمية,QUANTITY_TYPE.name as 'نوع الكمية',SUPPLIERS_INVOICE.price as السعر,SUPPLIERS_INVOICE.total as الإجمالي,SUPPLIERS_INVOICE.biskoul as بسكول,SUPPLIERS_INVOICE.mashal as مشال,SUPPLIERS_INVOICE.commissions as عمولات,SUPPLIERS_INVOICE.rest as 'الإجمالي بعد الخصومات',SUPPLIERS_INVOICE.paid as المدفوع,SUPPLIERS_INVOICE.baky as الباقي,SUPPLIERS_INVOICE.date as التاريخ from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id =SUPPLIERS.id inner join CATEGORY on SUPPLIERS_INVOICE.catid =CATEGORY.id inner join QUANTITY_TYPE on SUPPLIERS_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on SUPPLIERS_INVOICE.store_id =STORE.id where SUPPLIERS_INVOICE.suppliers_id ='" + (int)combosuppliers.SelectedValue + "' and SUPPLIERS_INVOICE.date between '" + datefrom.Value.Date.ToShortDateString() + "'" + " and '" + dateto.Value.Date.ToShortDateString() + "' ";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                incomesgrid.DataSource = dt;
                conn.Close();
            }
        }

    }
}



