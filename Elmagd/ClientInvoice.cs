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
    public partial class ClientInvoice : Form
    {

        int id, store, cat, quantitytype, clientIndex, clientIndexAfterAdd, enter_quantity, tempqunqtitytype;
        double total, quantity, price, bskoul, mashal, commession, rest, enterquantity, teenquantoty, tempquantity, quantity_db;
        string invoiceNo, invoiceDate, clientName;

        //SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public ClientInvoice()
        {
            InitializeComponent();
        }

        private void ClientInvoice_Load(object sender, EventArgs e)
        {
            clientinvoicedate.Value = DateTime.Now;
            Loadquantity_type();
            Loadstore();
            Loadcategory();
            Loadclient();
            BindGrid();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select TEMP_CLIENT.id as م,TEMP_CLIENT.invoiceNo 'رقم الفاتورة',CLIENT.name as 'إسم العميل',CATEGORY.name as 'إسم الصنف' ,STORE.name as 'إسم المخزن',TEMP_CLIENT.quantity as الكمية,QUANTITY_TYPE.name as 'نوع الكمية',TEMP_CLIENT.price as السعر,TEMP_CLIENT.total as الإجمالي,TEMP_CLIENT.biskoul as بسكول,TEMP_CLIENT.mashal as مشال ,TEMP_CLIENT.commission as عمولات,TEMP_CLIENT.rest as 'الإجمالي بعد الإضافات',TEMP_CLIENT.paid as المدفوع,TEMP_CLIENT.baky as الباقي,TEMP_CLIENT.date as التاريخ from TEMP_CLIENT inner join CLIENT on TEMP_CLIENT.client_id =CLIENT.id inner join CATEGORY on TEMP_CLIENT.cat_id =CATEGORY.id inner join STORE on TEMP_CLIENT.store_id =STORE.id inner join QUANTITY_TYPE on TEMP_CLIENT.quantitytype_id =QUANTITY_TYPE.id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tempclientgrid.DataSource = dt;
            conn.Close();
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
                if ((int)comboquantitytype.SelectedIndex == 2)
                    teenquantoty = quantity * 1000;
                else
                    quantity = double.Parse(txtquantity.Text);
                price = double.Parse(txtprice.Text);
                if ((int)comboquantitytype.SelectedIndex == 2)
                {
                    total = teenquantoty * price;
                    txttotal.Text = total.ToString();
                }
                else
                {
                    total = quantity * price;
                    txttotal.Text = total.ToString();
                }
            }
        }
        //حساب الإجمالي بعد الإضافات
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
                rest = total + (bskoul + mashal + commession);
                txtrest.Text = rest.ToString();

            }
        }

        private void btnadd1_Click(object sender, EventArgs e)//add button
        {
            clientIndex = (int)comboclient.SelectedIndex;
            if ((int)comboclient.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبارعميل");
            else if ((int)combocategory.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبارالصنف");
            else if ((int)comboquantitytype.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار نوع الكمية");
            else if ((int)combostore.SelectedIndex == 0)
                MessageBox.Show("برجاء اختبار المخزن");
            else if (txttotal.Text.Equals(""))
                MessageBox.Show("برجاء الضغط علي حساب الاجمالي اولا");
            else if (txtrest.Text.Equals(""))
                MessageBox.Show("برجاء الضغط علي حساب الباقي اولا");
            else if (txtInvoiceNo.Text.Equals(""))
                MessageBox.Show("يجب إدخال رقم الفاتورة أولا");
            else
            {
                enterquantity = double.Parse(txtquantity.Text);
                conn.Open();
                cmd.CommandText = @" select quantity from MAIN_STORE where store_id ='" + (int)combostore.SelectedValue + "'and cat_id='" + (int)combocategory.SelectedValue + "'and quantitytype_id= 1 ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("المخزن خالي");
                    conn.Close();
                }
                else
                {
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == "")
                        {
                            quantity = 0;
                        }
                        quantity = double.Parse(reader[0].ToString());
                    }

                    conn.Close();
                    //-------------------------------------
                    if (enterquantity > quantity)
                    {
                        MessageBox.Show("الكمية الموجودة في المخزن غير كافية لبيع هذه الكمية");
                    }
                    else
                    {
                        //check invoice number is exist or not
                        conn.Open();
                        cmd.CommandText = @"select invoiceNo from CLIENT_INVOICE where invoiceNo ='" + txtInvoiceNo.Text + "'";
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows || (clientIndexAfterAdd != clientIndex && clientIndexAfterAdd != 0))
                        {
                            MessageBox.Show("رقم الفاتورة موجود بالفعل");
                            conn.Close();
                        }
                        else if (clientIndexAfterAdd != clientIndex && clientIndexAfterAdd != 0)
                            MessageBox.Show("يجب إختيار نفس العميل لنفس الفاتورة");
                        else
                        {
                            conn.Close();
                            conn.Open();
                            cmd.CommandText = @"insert into TEMP_CLIENT (client_id,cat_id,quantity,quantitytype_id,price,total,biskoul,mashal,commission,rest,paid,baky,store_id,date,invoiceNo) values(@client_id,@cat_id,@quantity,@quantitytype_id,@price,@total,@biskoul,@mashal,@commissions,@rest,@paid,@baky,@store_id,@date,@invoiceNo)";
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@client_id", (int)comboclient.SelectedValue);
                            cmd.Parameters.AddWithValue("@cat_id", (int)combocategory.SelectedValue);
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
                            cmd.Parameters.AddWithValue("@date", clientinvoicedate.Value.Date.ToShortDateString());
                            cmd.Parameters.AddWithValue("@invoiceNo", txtInvoiceNo.Text);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            conn.Close();
                            BindGrid();
                            MessageBox.Show("تمت عمليه الاضافه");
                            clientIndexAfterAdd = clientIndex;
                            //----------------------------------------
                            //select quntity ,store, quantity type,category
                            conn.Open();
                            cmd.CommandText = @" select quantity,quantitytype_id from TEMP_CLIENT where store_id ='" + (int)combostore.SelectedValue + "'and cat_id='" + (int)combocategory.SelectedValue + "'and quantitytype_id= '" + (int)comboquantitytype.SelectedValue + "' ";
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                tempquantity = double.Parse(reader[0].ToString());
                                tempqunqtitytype = int.Parse(reader[1].ToString());
                            }
                            conn.Close();
                            //---------------------------------
                            //update mainstore
                            conn.Open();
                            if (tempqunqtitytype == 2)
                            {
                                quantity_db = tempquantity * 1000;
                                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + quantity_db + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id = 1  ";
                            }
                            else if (tempqunqtitytype == 3)
                            {
                                quantity_db = tempquantity * 150;
                                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + quantity_db + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id = 1  ";
                            }
                            else if (tempqunqtitytype == 4)
                            {
                                quantity_db = tempquantity * 155;
                                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + quantity_db + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id = 1  ";
                            }
                            else
                                cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + tempquantity + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'and quantitytype_id = 1  ";
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            conn.Close();
                            txtbskoul.Text = "";
                            txtcommestion.Text = "";
                            txtmashal.Text = "";
                            txtprice.Text = "";
                            txtquantity.Text = "";
                            txtrest.Text = "";
                            txttotal.Text = "";
                            txtpaid.Text = "";
                            txtbaky.Text = "";
                            comboclient.SelectedIndex = 0;
                            combocategory.SelectedIndex = 0;
                            comboquantitytype.SelectedIndex = 0;
                            combostore.SelectedIndex = 0;
                        }
                    }
                }

            }
        }

        private void tempclientgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tempclientgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    tempclientgrid.CurrentRow.Selected = true;
                    id = int.Parse(tempclientgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    btnadd.Enabled = false;
                }
            }
            catch (Exception ex) { }
        }
        //delet temp
        private void btndelet_Click(object sender, EventArgs e)
        {

            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                cmd.CommandText = @" select store_id,cat_id,quantity,quantitytype_id from TEMP_CLIENT where id='" + id + "' ";
                SqlDataReader reader_temp = cmd.ExecuteReader();
                while (reader_temp.Read())
                {
                    store = int.Parse(reader_temp[0].ToString());
                    cat = int.Parse(reader_temp[1].ToString());
                    quantity = double.Parse(reader_temp[2].ToString());
                    quantitytype = int.Parse(reader_temp[3].ToString());

                }
                conn.Close();

                //---------------------------------
                //update mainstore
                conn.Open();
                if (quantitytype == 2)
                {
                    quantity_db = quantity * 1000;
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + quantity_db + "' where store_id = '" + store + "'and cat_id ='" + cat + "'and quantitytype_id = 1  ";
                }
                else if (quantitytype == 3)
                {
                    quantity_db = quantity * 150;
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + quantity_db + "' where store_id = '" + store + "'and cat_id ='" + cat + "'and quantitytype_id = 1  ";
                }
                else if (quantitytype == 4)
                {
                    quantity_db = quantity * 155;
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + quantity_db + "' where store_id = '" + store + "'and cat_id ='" + cat + "'and quantitytype_id = 1  ";
                }
                else
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + quantity + "' where store_id = '" + store + "'and cat_id ='" + cat + "'and quantitytype_id =1  ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                foreach (DataGridViewRow row in tempclientgrid.SelectedRows)
                {

                    tempclientgrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from TEMP_CLIENT where id = '" + id + "'";
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

        private void btnadd_Click(object sender, EventArgs e)//print button
        {
            conn.Open();
            cmd.CommandText = @"select id from TEMP_CLIENT  ";
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
                MessageBox.Show("لاتوجد اي بيانات للطباعه");
            else
            {
                //add client invoice
                clientIndexAfterAdd = 0;
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into CLIENT_INVOICE (client_id,cat_id,quantity,quantitytype_id,price,total,biskoul,mashal,commission,rest,paid,baky,store_id,date,invoiceNo) select  client_id,cat_id,quantity,quantitytype_id,price,total,biskoul,mashal,commission,rest,paid,baky,store_id,date,invoiceNo from TEMP_CLIENT ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                //-------------------------------------------------------------------------------
                conn.Open();
                cmd.CommandText = @"select id from CLIENT_INVOICE where CLIENT_INVOICE.date = '" + clientinvoicedate.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into CASHIER (clientinvoice_id,date) values(@clientinvoice_id,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@clientinvoice_id", id);
                cmd.Parameters.AddWithValue("@date", clientinvoicedate.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                //-------------------------------------------------------------------------------
                //////addto sales
                //conn.Open();
                //cmd.CommandText = @"insert into SALES (client_id,cat_id,quantity,quantitytype_id,store_id,rest,paid,baky,date) select  client_id,cat_id,quantity,quantitytype_id,store_id,rest,paid,baky,date from TEMP_CLIENT ";
                //cmd.Connection = conn;
                //cmd.ExecuteNonQuery();
                //conn.Close();
                //-------------------------------------

                //print client invoice
                ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                // delete temp client
                conn.Open();
                cmd.CommandText = @"delete from TEMP_CLIENT ";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
                txtInvoiceNo.Text = "";
            }
        }

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

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtquantity.Text, "[^0-9.]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtquantity.Text = txtquantity.Text.Remove(txtquantity.Text.Length - 1);
            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            }
        }

        private void txtbskoul_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbskoul.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtbskoul.Text = txtbskoul.Text.Remove(txtbskoul.Text.Length - 1);
            }
        }

        private void txtmashal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtmashal.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtmashal.Text = txtmashal.Text.Remove(txtmashal.Text.Length - 1);
            }
        }

        private void txtcommestion_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcommestion.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtcommestion.Text = txtcommestion.Text.Remove(txtcommestion.Text.Length - 1);
            }
        }

        private void txtpaid_TextChanged(object sender, EventArgs e)
        {
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 40;
            Font font = new Font("Arial", 18, FontStyle.Bold);
            string title = "شركة المجد - فاتورة عميل";
            invoiceNo = "رقم الفاتورة" + " : " + tempclientgrid.Rows[0].Cells[1].Value.ToString();
            invoiceDate = "تاريخ الفاتورة : " + clientinvoicedate.Value.Date.ToShortDateString();
            clientName = "اسم العميل : " + tempclientgrid.Rows[0].Cells[2].Value.ToString();
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
            for (int i = 0; i < tempclientgrid.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(tempclientgrid.Rows[i].Cells[3].Value.ToString(), font, Brushes.Navy, e.PageBounds.Width - margin * 2 - col1width, preHieght + rowsHieght);
                e.Graphics.DrawString(tempclientgrid.Rows[i].Cells[5].Value.ToString(), font, Brushes.Blue, e.PageBounds.Width - margin * 2 - col2width, preHieght + rowsHieght);
                e.Graphics.DrawString(tempclientgrid.Rows[i].Cells[6].Value.ToString(), font, Brushes.Blue, e.PageBounds.Width - margin * 2 - col3width, preHieght + rowsHieght);
                e.Graphics.DrawString(tempclientgrid.Rows[i].Cells[7].Value.ToString(), font, Brushes.Blue, e.PageBounds.Width - margin * 2 - col4width, preHieght + rowsHieght);
                e.Graphics.DrawString(tempclientgrid.Rows[i].Cells[12].Value.ToString(), font, Brushes.DeepPink, e.PageBounds.Width - margin * 2 - col5width, preHieght + rowsHieght);
                e.Graphics.DrawLine(Pens.Black, 5, preHieght + rowsHieght + colHieght, e.PageBounds.Width - 5, preHieght + rowsHieght + colHieght);
                rowsHieght += 55;
                totalAll += double.Parse(tempclientgrid.Rows[i].Cells[8].Value.ToString());
                totalPayment += double.Parse(tempclientgrid.Rows[i].Cells[13].Value.ToString());
                totalRemain += double.Parse(tempclientgrid.Rows[i].Cells[14].Value.ToString());
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

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
