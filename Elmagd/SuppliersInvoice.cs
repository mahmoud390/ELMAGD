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
    public partial class SuppliersInvoice : Form
    {
        int id, id_store, store, cat, quantitytype, catid_DB, suppliersIndex, suppliersIndexAfterAdd, store_id;
        double total, quantity, price, bskoul, mashal, commession, rest, enter_quantity, tempquantity, quantityconverttokilo;
        string invoiceNo, invoiceDate, clientName;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public SuppliersInvoice()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #region LOADPAGE
        private void SuppliersInvoice_Load(object sender, EventArgs e)
        {
            
            suppliersinvoicedate.Value = DateTime.Now;
            BindGrid();
            Loadquantity_type();
            Loadsuppliers();
            Loadstore();
            Loadcategory();
        }
        #endregion

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select TEMP_SUPPLIERSINVOICE.id ,SUPPLIERS.name as المورد,STORE.name as المخزن,CATEGORY.name as الصنف,TEMP_SUPPLIERSINVOICE.quantity as الكمية,QUANTITY_TYPE.name as نوع_الكمية,TEMP_SUPPLIERSINVOICE.price as السعر,TEMP_SUPPLIERSINVOICE.total as الإجمالي,TEMP_SUPPLIERSINVOICE.biskoul as بسكول,TEMP_SUPPLIERSINVOICE.mashal as مشال,TEMP_SUPPLIERSINVOICE.commissions as عمولات,TEMP_SUPPLIERSINVOICE.rest as الإجمالي_بعدالخصومات,TEMP_SUPPLIERSINVOICE.paid as المدفوع,TEMP_SUPPLIERSINVOICE.baky as الباقي,TEMP_SUPPLIERSINVOICE.invoiceNo as رقم_الفاتوره from TEMP_SUPPLIERSINVOICE inner join SUPPLIERS on TEMP_SUPPLIERSINVOICE.suppliers_id =SUPPLIERS.id inner join STORE on TEMP_SUPPLIERSINVOICE.store_id = STORE.id inner join CATEGORY on TEMP_SUPPLIERSINVOICE.cat_id = CATEGORY.id inner join QUANTITY_TYPE on TEMP_SUPPLIERSINVOICE.quantitytype_id =QUANTITY_TYPE.id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tempsuppliergrid.DataSource = dt;
            conn.Close();
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

        #region CALC_TOTAL
        // حساب الاجمالي قبل الخصم والاضافة
        private void btncalc_Click(object sender, EventArgs e)
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
                quantity = double.Parse(txtquantity.Text);
                price = double.Parse(txtprice.Text);
                total = quantity * price;
                txttotal.Text = total.ToString();
            }

        }
        #endregion

        #region CALC_REST
        //حساب الباقي 
        private void btncalc2_Click(object sender, EventArgs e)
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
                bskoul = double.Parse(txtbskoul.Text);
                mashal = double.Parse(txtmashal.Text);
                commession = double.Parse(txtcommestion.Text);
                rest = total - (bskoul + mashal + commession);
                txtrest.Text = rest.ToString();
            }

        }
        #endregion

        #region ADD_TEMP_SUPPLIERSINVOICE
        // إضافة في temp_supplierinvoice والجرداية
        //إضافة التوريدات في الجردايه
        private void radButton1_Click(object sender, EventArgs e)//add btn
        {
            try
            {
                suppliersIndex = (int)combosuppliers.SelectedIndex;
                if ((int)combosuppliers.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختبارالمورد");
                else if ((int)combocategory.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختبارالصنف");
                else if ((int)comboquantitytype.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختبار نوع الكمية");
                else if ((int)combostore.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختبار المخزن");
                else if (txttotal.Text.Equals(""))
                    MessageBox.Show("برجاء الضغط علي حساب الاجمالي اولا");
                else if (txtquantity.Text.Equals(""))
                    MessageBox.Show("برجاء إدخال الكمية");
                else if (txtrest.Text.Equals(""))
                    MessageBox.Show("برجاء الضغط علي حساب الباقي اولا");
                else if (txtInvoiceNo.Text.Equals(""))
                    MessageBox.Show("يجب إدخال رقم الفاتورة أولا");

                else
                {
                    enter_quantity = double.Parse(txtquantity.Text);
                    int store = (int)combostore.SelectedValue;
                    int cat = (int)combocategory.SelectedValue;
                    int quantitytype = (int)comboquantitytype.SelectedValue;
                    conn.Close();
                    conn.Open();
                    cmd.CommandText = @"select invoiceNo from SUPPLIERS_INVOICE where invoiceNo ='" + txtInvoiceNo.Text + "'";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows || (suppliersIndexAfterAdd != suppliersIndex && suppliersIndexAfterAdd != 0))
                    {
                        MessageBox.Show("رقم الفاتورة موجود بالفعل");
                        conn.Close();
                    }
                    else if (suppliersIndexAfterAdd != suppliersIndex && suppliersIndexAfterAdd != 0)
                        MessageBox.Show("يجب إختيار نفس العميل لنفس الفاتورة");
                    else
                    {
                        conn.Close();
                        conn.Open();
                        cmd.CommandText = @"insert into TEMP_SUPPLIERSINVOICE (suppliers_id,cat_id,quantity,quantitytype_id,price,total,biskoul,mashal,commissions,rest,paid,baky,store_id,date,invoiceNo) values(@suppliers_id,@cat_id,@quantity,@quantitytype_id,@price,@total,@biskoul,@mashal,@commissions,@rest,@paid,@baky,@store_id,@date,@invoiceNo)";
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@suppliers_id", (int)combosuppliers.SelectedValue);
                        cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
                        //if ((int)comboquantitytype.SelectedValue == 2)
                        //{
                        //    quantity = enter_quantity * 1000;
                        //    cmd.Parameters.AddWithValue("@quantity", quantity);
                        //}
                        //else if ((int)comboquantitytype.SelectedValue == 3)
                        //{
                        //    quantity = enter_quantity * 150;
                        //    cmd.Parameters.AddWithValue("@quantity", quantity);
                        //}
                        //else if ((int)comboquantitytype.SelectedValue == 4)
                        //{
                        //    quantity = enter_quantity * 155;
                        //    cmd.Parameters.AddWithValue("@quantity", quantity);
                        //}

                        //else
                        cmd.Parameters.AddWithValue("@quantity", txtquantity.Text);
                        cmd.Parameters.AddWithValue("@quantitytype_id", (int)comboquantitytype.SelectedValue);
                        cmd.Parameters.AddWithValue("@price", txtprice.Text);
                        cmd.Parameters.AddWithValue("@total", txttotal.Text);
                        cmd.Parameters.AddWithValue("@biskoul", txtbskoul.Text);
                        cmd.Parameters.AddWithValue("@mashal", txtmashal.Text);
                        cmd.Parameters.AddWithValue("@commissions", txtcommestion.Text);
                        cmd.Parameters.AddWithValue("@rest", txtrest.Text);
                        cmd.Parameters.AddWithValue("@paid", txtpaid.Text);
                        cmd.Parameters.AddWithValue("@baky", txtbaky.Text);
                        cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                        cmd.Parameters.AddWithValue("@date", suppliersinvoicedate.Value.Date.ToShortDateString());
                        cmd.Parameters.AddWithValue("@invoiceNo", txtInvoiceNo.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        conn.Close();
                        BindGrid();
                        txtbskoul.Text = "";
                        txtcommestion.Text = "";
                        txtmashal.Text = "";
                        txtprice.Text = "";
                        txtquantity.Text = "";
                        txtrest.Text = "";
                        txttotal.Text = "";
                        txtpaid.Text = "";
                        txtbaky.Text = "";
                        combosuppliers.SelectedIndex = 0;
                        combocategory.SelectedIndex = 0;
                        comboquantitytype.SelectedIndex = 0;
                        combostore.SelectedIndex = 0;
                        MessageBox.Show("تمت عمليه الاضافه");
                        suppliersIndexAfterAdd = suppliersIndex;
                    }
                }
            }
            catch (Exception ex) { }
        }
        #endregion

        #region GRID_CELLCLICK
        private void tempsuppliergrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tempsuppliergrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    tempsuppliergrid.CurrentRow.Selected = true;
                    id = int.Parse(tempsuppliergrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                }
            }
            catch (Exception ex) { }
        }
        #endregion


        #region DELET_TEMP_SUPPLIERSINVOICE
        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                foreach (DataGridViewRow row in tempsuppliergrid.SelectedRows)
                {
                    tempsuppliergrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from TEMP_SUPPLIERSINVOICE where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    MessageBox.Show("تم الحذف");
                    id = 0;
                    btnadd.Enabled = true;
                }
            }
        }
        #endregion


        #region PRINT_ADDSUPLLIERINVOICE_ADDMAINSTORE_updatemainstore_delettempsuppliersinvoice
        //إضافة في supplier invoice
        private void btnadd_Click(object sender, EventArgs e)//print btn
        {
            conn.Close();
            conn.Open();
            cmd.CommandText = @"select id from TEMP_SUPPLIERSINVOICE  ";
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
                MessageBox.Show("لاتوجد اي بيانات للطباعه");
            else
            {
                suppliersIndexAfterAdd = 0;
                conn.Close();
                //add to suppliers invoice
                conn.Open();
                cmd.CommandText = @"insert into SUPPLIERS_INVOICE (suppliers_id,catid,quantity,quantitytype_id,price,total,biskoul,mashal,commissions,rest,paid,baky,store_id,date,invoiceNo) select suppliers_id,cat_id,quantity,quantitytype_id,price,total,biskoul,mashal,commissions,rest,paid,baky,store_id,date,invoiceNo from TEMP_SUPPLIERSINVOICE ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                //---------------------------------------------
                //حركات الخزنه
                conn.Open();
                cmd.CommandText = @"select id from SUPPLIERS_INVOICE where SUPPLIERS_INVOICE.date = '" + suppliersinvoicedate.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into CASHIER (suplliersinvoice_id,date) values(@suplliersinvoice_id,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@suplliersinvoice_id", id);
                cmd.Parameters.AddWithValue("@date", suppliersinvoicedate.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();

                //-------------------------------------------------------------------
                // add to main store
                conn.Open();
                cmd.CommandText = @"select cat_id,quantitytype_id,quantity  from TEMP_SUPPLIERSINVOICE ";
                SqlDataReader reader_cateid = cmd.ExecuteReader();
                while (reader_cateid.Read())
                {

                    catid_DB = int.Parse(reader_cateid[0].ToString());
                    quantitytype = int.Parse(reader_cateid[1].ToString());

                }
                conn.Close();
                //----------------------------------------------
                //إضافة مخزن ومنتج داخلmainstore في حالة عدم وجود هذا المخزن
                conn.Open();
                cmd.CommandText = @"select id  from MAIN_STORE where cat_id ='" + catid_DB + "'and quantitytype_id= '" + quantitytype + "'  ";
                SqlDataReader reader_id = cmd.ExecuteReader();
                while (reader_id.Read())
                {
                    if (reader_id[0].ToString() == "")
                        id_store = 0;
                    else
                        id_store = int.Parse(reader_id[0].ToString());
                }
                conn.Close();
                if (id_store == 0)
                {

                    if (quantitytype == 2)
                    {
                        select_temp();
                        conn.Open();
                        quantityconverttokilo = tempquantity * 1000;
                        cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) values (@store_id,@cat_id,@quantity,@quantitytype_id) ";
                        cmd.Parameters.AddWithValue("@store_id", store_id);
                        cmd.Parameters.AddWithValue("@cat_id", catid_DB);
                        cmd.Parameters.AddWithValue("@quantity", quantityconverttokilo);
                        cmd.Parameters.AddWithValue("@quantitytype_id", 1);
                    }

                    else if (quantitytype == 3)
                    {
                        select_temp();
                        conn.Open();
                        quantityconverttokilo = tempquantity * 150;
                        cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) values (@store_id,@cat_id,@quantity,@quantitytype_id) ";
                        cmd.Parameters.AddWithValue("@store_id", store_id);
                        cmd.Parameters.AddWithValue("@cat_id", catid_DB);
                        cmd.Parameters.AddWithValue("@quantity", quantityconverttokilo);
                        cmd.Parameters.AddWithValue("@quantitytype_id", 1);
                    }
                    else if (quantitytype == 4)
                    {
                        select_temp();
                        conn.Open();
                        quantityconverttokilo = tempquantity * 155;
                        cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) values (@store_id,@cat_id,@quantity,@quantitytype_id) ";
                        cmd.Parameters.AddWithValue("@store_id", store_id);
                        cmd.Parameters.AddWithValue("@cat_id", catid_DB);
                        cmd.Parameters.AddWithValue("@quantity", quantityconverttokilo);
                        cmd.Parameters.AddWithValue("@quantitytype_id", 1);
                    }
                    else
                        conn.Open();
                        cmd.CommandText = @"insert into MAIN_STORE (store_id,cat_id,quantity,quantitytype_id) select store_id,cat_id,quantity,quantitytype_id from TEMP_SUPPLIERSINVOICE ";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    // سليكت الكمية الموجودة داخل المخزن ونوع الكمية
                    conn.Open();
                    cmd.CommandText = @" select store_id,cat_id,quantity,quantitytype_id from TEMP_SUPPLIERSINVOICE ";
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        store = int.Parse(reader[0].ToString());
                        cat = int.Parse(reader[1].ToString());
                        enter_quantity = double.Parse(reader[2].ToString());
                        quantitytype = int.Parse(reader[3].ToString());


                    }
                    conn.Close();
                    //-------------------------------------
                    // ابديت الكمية في المين استور في حالة إضافة توريد جديد
                    conn.Open();
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + enter_quantity + "' where store_id = '" + store + "'and cat_id ='" + cat + "'and quantitytype_id ='" + quantitytype + "'   ";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    conn.Close();
                }

                // print
                ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }

                // delet temp suppliers invoice
                conn.Open();
                cmd.CommandText = @"delete from TEMP_SUPPLIERSINVOICE ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
            }

        }
        #endregion

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        #region CALC_BAKY
        //حساب الباقي بعد المبلغ المدفوع من الإجمالي بعد الخصومات
        private void btnbaky_Click(object sender, EventArgs e)
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
        #endregion

        #region TEXTCHANGE_TXTCOMMESTION
        private void txtcommestion_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcommestion.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtcommestion.Text = txtcommestion.Text.Remove(txtcommestion.Text.Length - 1);
            }
        }
        #endregion

        #region TEXTCHANGE_TXTQUANTITY
        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtquantity.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtquantity.Text = txtquantity.Text.Remove(txtquantity.Text.Length - 1);
            }
        }
        #endregion

        #region TEXTCHANGE_TXTPRICE
        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            }
        }
        #endregion

        #region TEXTCHANGE_TXTBAKY
        private void txtbskoul_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbskoul.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtbskoul.Text = txtbskoul.Text.Remove(txtbskoul.Text.Length - 1);
            }
        }
        #endregion

        #region TEXTCHANGE_TXTMASHAL
        private void txtmashal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtmashal.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtmashal.Text = txtmashal.Text.Remove(txtmashal.Text.Length - 1);
            }
        }
        #endregion

        #region TEXTCHANGE_TXTPAID
        private void txtpaid_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtpaid.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("يجب إدخال أرقام فقط");
            //    txtpaid.Text = txtpaid.Text.Remove(txtpaid.Text.Length - 1);
            //}
        }
        #endregion

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 40;
            Font font = new Font("Arial", 18, FontStyle.Bold);
            string title = "شركة المجد - فاتورة مورد";
            invoiceNo = "رقم الفاتورة" + " : " + tempsuppliergrid.Rows[0].Cells[14].Value.ToString();
            invoiceDate = "تاريخ الفاتورة : " + suppliersinvoicedate.Value.Date.ToShortDateString();
            clientName = "اسم المورد : " + tempsuppliergrid.Rows[0].Cells[1].Value.ToString();
            SizeF fontTitle = e.Graphics.MeasureString(title, font);
            SizeF fontInvoiceNo = e.Graphics.MeasureString(invoiceNo, font);
            SizeF fontInvoiceDate = e.Graphics.MeasureString(invoiceDate, font);
            SizeF fontClientName = e.Graphics.MeasureString(clientName, font);
            e.Graphics.DrawImage(Properties.Resources._0000000011111111111111111, 5, 5, 200, 200);
            e.Graphics.DrawString(title, font, Brushes.Red, (e.PageBounds.Width - fontTitle.Width) / 2, margin);
            e.Graphics.DrawString(invoiceNo, font, Brushes.Red, e.PageBounds.Width - fontInvoiceNo.Width - margin, margin + fontTitle.Height);
            e.Graphics.DrawString(invoiceDate, font, Brushes.Black, e.PageBounds.Width - fontInvoiceDate.Width - margin, margin + fontTitle.Height + fontInvoiceNo.Height);
            e.Graphics.DrawString(clientName, font, Brushes.Blue, e.PageBounds.Width - fontClientName.Width - margin, margin + fontTitle.Height + fontInvoiceNo.Height + fontInvoiceDate.Height);
            float preHieght = margin + fontTitle.Height + fontInvoiceNo.Height + fontInvoiceDate.Height + fontClientName.Height;
            e.Graphics.DrawRectangle(Pens.Black, 5, preHieght, e.PageBounds.Width - 5 * 2, e.PageBounds.Height - 5 - preHieght);
            float colHieght = 50, col1width = 330, col2width = 60 + col1width, col3width = 100 + col2width, col4width = 100 + col3width, col5width = 100 + col4width, col6width = 100 + col5width, col7width = 10 + col6width;
            e.Graphics.DrawLine(Pens.Black, 5, preHieght + colHieght, e.PageBounds.Width - 5, preHieght + colHieght);
            e.Graphics.DrawString("الصنف", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col1width + 200, preHieght);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col1width, preHieght, e.PageBounds.Width - margin * 2 - col1width, e.PageBounds.Height - margin);
            e.Graphics.DrawString("الكمية", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHieght);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col2width, preHieght, e.PageBounds.Width - margin * 2 - col2width, e.PageBounds.Height - margin);
            e.Graphics.DrawString("نوع الكمية", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHieght);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col3width, preHieght, e.PageBounds.Width - margin * 2 - col3width, e.PageBounds.Height - margin);
            e.Graphics.DrawString("سعر الوحدة", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHieght);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col4width, preHieght, e.PageBounds.Width - margin * 2 - col4width, e.PageBounds.Height - margin);
            e.Graphics.DrawString("الإجمالى", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col5width, preHieght);
            float rowsHieght = 55;
            double totalAll = 0.0, totalPayment = 0.0, totalRemain = 0.0;
            for (int i = 0; i < tempsuppliergrid.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(tempsuppliergrid.Rows[i].Cells[3].Value.ToString(), font, Brushes.Navy, e.PageBounds.Width - margin * 2 - col1width, preHieght + rowsHieght);
                e.Graphics.DrawString(tempsuppliergrid.Rows[i].Cells[4].Value.ToString(), font, Brushes.Blue, e.PageBounds.Width - margin * 2 - col2width, preHieght + rowsHieght);
                e.Graphics.DrawString(tempsuppliergrid.Rows[i].Cells[5].Value.ToString(), font, Brushes.Blue, e.PageBounds.Width - margin * 2 - col3width, preHieght + rowsHieght);
                e.Graphics.DrawString(tempsuppliergrid.Rows[i].Cells[6].Value.ToString(), font, Brushes.Blue, e.PageBounds.Width - margin * 2 - col4width, preHieght + rowsHieght);
                e.Graphics.DrawString(tempsuppliergrid.Rows[i].Cells[7].Value.ToString(), font, Brushes.DeepPink, e.PageBounds.Width - margin * 2 - col5width, preHieght + rowsHieght);
                e.Graphics.DrawLine(Pens.Black, 5, preHieght + rowsHieght + colHieght, e.PageBounds.Width - 5, preHieght + rowsHieght + colHieght);
                rowsHieght += 55;
                totalAll += double.Parse(tempsuppliergrid.Rows[i].Cells[11].Value.ToString());
                totalPayment += double.Parse(tempsuppliergrid.Rows[i].Cells[12].Value.ToString());
                totalRemain += double.Parse(tempsuppliergrid.Rows[i].Cells[13].Value.ToString());
            }
            e.Graphics.DrawString("الإجمالى الكلى", font, Brushes.Green, e.PageBounds.Width - margin * 2 - col1width, preHieght + rowsHieght);
            e.Graphics.DrawString("<<<<", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHieght + rowsHieght);
            e.Graphics.DrawString("<<<<<<", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHieght + rowsHieght);
            e.Graphics.DrawString("<<<<<<", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHieght + rowsHieght);
            e.Graphics.DrawLine(Pens.Black, 5, preHieght + rowsHieght + colHieght, e.PageBounds.Width - 5, preHieght + rowsHieght + colHieght);
            e.Graphics.DrawString("إجمالى المدفوعات", font, Brushes.Green, e.PageBounds.Width - margin * 2 - col1width, preHieght + rowsHieght + 55);
            e.Graphics.DrawString("<<<<", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHieght + rowsHieght + 55);
            e.Graphics.DrawString("<<<<<<", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHieght + rowsHieght + 55);
            e.Graphics.DrawString("<<<<<<", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHieght + rowsHieght + 55);
            e.Graphics.DrawLine(Pens.Black, 5, preHieght + rowsHieght + colHieght + 55, e.PageBounds.Width - 5, preHieght + rowsHieght + colHieght + 55);
            e.Graphics.DrawString("إجمالى المتبقى", font, Brushes.Green, e.PageBounds.Width - margin * 2 - col1width, preHieght + rowsHieght + 110);
            e.Graphics.DrawString("<<<<", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHieght + rowsHieght + 110);
            e.Graphics.DrawString("<<<<<<", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHieght + rowsHieght + 110);
            e.Graphics.DrawString("<<<<<<", font, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHieght + rowsHieght + 110);
            e.Graphics.DrawLine(Pens.Black, 5, preHieght + rowsHieght + colHieght + 110, e.PageBounds.Width - 5, preHieght + rowsHieght + colHieght + 110);
            e.Graphics.DrawString(totalAll.ToString(), font, Brushes.Green, e.PageBounds.Width - margin * 2 - col5width, preHieght + rowsHieght);
            e.Graphics.DrawString(totalPayment.ToString(), font, Brushes.Green, e.PageBounds.Width - margin * 2 - col5width, preHieght + rowsHieght + 55);
            e.Graphics.DrawString(totalRemain.ToString(), font, Brushes.Green, e.PageBounds.Width - margin * 2 - col5width, preHieght + rowsHieght + 110);
        }
        private void select_temp()
        {
            conn.Open();
            cmd.CommandText = @"select store_id,cat_id,quantity from TEMP_SUPPLIERSINVOICE ";
            SqlDataReader reader_tmep = cmd.ExecuteReader();
            while (reader_tmep.Read())
            {
                store_id = int.Parse(reader_tmep[0].ToString());
                catid_DB = int.Parse(reader_tmep[1].ToString());
                tempquantity = int.Parse(reader_tmep[2].ToString());

            }
            conn.Close();
        }


    }
}
