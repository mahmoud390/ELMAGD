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
    public partial class Cachier : Form
    {
        double resipt_client, general_receipt, client_invoice, totalsales, netprofit, payment_supplier, general_payments, suppliers_invoice, totalpaid;
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Cachier()
        {
            InitializeComponent();
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void radGroupBox2_Click(object sender, EventArgs e)
        {

        }

        #region SELECT_VALUE_RECEIPTS_CLIENT
        private void btnrecipts_client_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(value) from RESEIPTS_CLIENT where RESEIPTS_CLIENT.date between '" + datefromedaa.Value.Date.ToShortDateString() + "'" + " and '" + datetoedaa.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtreceiptsclient.Text = "0";
                else
                    txtreceiptsclient.Text = reader[0].ToString();
            }
            conn.Close();
        }
        #endregion

        #region SELECT_VALUE_GENERAL_RECEIPTS
        private void btngeneral_receptis_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(value) from GENERAL_RECEIPTS where GENERAL_RECEIPTS.date between '" + datefromedaa.Value.Date.ToShortDateString() + "'" + " and '" + datetoedaa.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtgeneralreceipts.Text = "0";
                else
                    txtgeneralreceipts.Text = reader[0].ToString();
            }
            conn.Close();
        }
        #endregion

        #region SELECT_PAID_CLIENTINVOICE
        private void btnclient_invoice_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(paid) from CLIENT_INVOICE where CLIENT_INVOICE.date between '" + datefromedaa.Value.Date.ToShortDateString() + "'" + " and '" + datetoedaa.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtclientinvoice.Text = "0";
                else
                    txtclientinvoice.Text = reader[0].ToString();
            }
            conn.Close();
        }
        #endregion


        #region SELECT_VALUE_PAYMENTS_SUPPLIERS
        private void btnpayments_supplier_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(value) from PAYMENTS_SUPPLIERS where PAYMENTS_SUPPLIERS.date between '" + datefromsahb.Value.Date.ToShortDateString() + "'" + " and '" + datetosahb.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtpaymentsuppliers.Text = "0";
                else
                    txtpaymentsuppliers.Text = reader[0].ToString();
            }
            conn.Close();
        }
        #endregion

        #region SELECT_VALUE_ GENERAL_PAYMENTS
        private void btngeneral_payments_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(value) from GENERAL_PAYMENTS where GENERAL_PAYMENTS.date between '" + datefromsahb.Value.Date.ToShortDateString() + "'" + " and '" + datetosahb.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtgeneralpaymentes.Text = "0";
                else
                    txtgeneralpaymentes.Text = reader[0].ToString();
            }
            conn.Close();
        }
        #endregion

        #region SELECT_PAID_ SUPPLIERS_INVOICE
        private void btnsuppliers_invoice_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(paid) from SUPPLIERS_INVOICE where SUPPLIERS_INVOICE.date between '" + datefromsahb.Value.Date.ToShortDateString() + "'" + " and '" + datetosahb.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtsuppliersinvoice.Text = "0";
                else
                    txtsuppliersinvoice.Text = reader[0].ToString();
            }
            conn.Close();
        }
        #endregion

        #region INSRET SAHB_CASHIER
        private void btnsahb_Click(object sender, EventArgs e)
        {
            if (txtadminsahb.Text.Equals(""))
            {
                MessageBox.Show("برجاء إدخال مبلغ السحب ");
            }
            else
            {
                conn.Open();
                cmd.CommandText = @"insert into CASHIER (sahb,date) values(@sahb,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@sahb", txtadminsahb.Text);
                cmd.Parameters.AddWithValue("@date", datesahb.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtadminsahb.Text = "";
                MessageBox.Show("تمت عمليه السحب");
            }
        }
        #endregion

        #region SELECT_SAHB_CASHIER
        private void btnadminsahb_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(sahb) from CASHIER where CASHIER.date between '" + datefromsahb.Value.Date.ToShortDateString() + "'" + " and '" + datetosahb.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtadminsahb.Text = "0";
                else
                    txtadminsahb.Text = reader[0].ToString();
            }
            conn.Close();
        }
        #endregion

        #region INSRET EXTERNAL_SOURES_CASHIER
        private void btnedaa_Click(object sender, EventArgs e)
        {
            if (txtedaa.Text.Equals(""))
            {
                MessageBox.Show("برجاء إدخال مبلغ الإيداع ");
            }
            else
            {
                conn.Open();
                cmd.CommandText = @"insert into CASHIER (external_soures,date) values(@external_soures,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@external_soures", txtedaa.Text);
                cmd.Parameters.AddWithValue("@date", dateedaa.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                BindGrid();
                txtedaa.Text = "";
                MessageBox.Show("تمت عمليه الايداع");
            }
        }
        #endregion

        #region SELECT_EXTERNAL_SOURES_CASHIER
        private void btnexternal_soures_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(external_soures) from CASHIER where CASHIER.date between '" + datefromedaa.Value.Date.ToShortDateString() + "'" + " and '" + datetoedaa.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtexternalsourses.Text = "0";
                else
                    txtexternalsourses.Text = reader[0].ToString();
            }
            conn.Close();
        }
        #endregion

        #region  NETPROFIT
        private void btn_netprofit_Click(object sender, EventArgs e)
        {


            conn.Open();
            cmd.CommandText = @"select sum(value) from RESEIPTS_CLIENT where RESEIPTS_CLIENT.date between '" + datefromedaa.Value.Date.ToShortDateString() + "'" + " and '" + datetoedaa.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    resipt_client = 0;
                else
                    resipt_client = double.Parse(reader[0].ToString());
            }
            conn.Close();
            //------------------------------------------------------------------------------
            conn.Open();
            cmd.CommandText = @"select sum(value) from GENERAL_RECEIPTS where GENERAL_RECEIPTS.date between '" + datefromedaa.Value.Date.ToShortDateString() + "'" + " and '" + datetoedaa.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    general_receipt = 0;
                else
                    general_receipt = double.Parse(reader[0].ToString());
            }
            conn.Close();
            //----------------------------------------
            conn.Open();
            cmd.CommandText = @"select sum(paid) from CLIENT_INVOICE where CLIENT_INVOICE.date between '" + datefromedaa.Value.Date.ToShortDateString() + "'" + " and '" + datetoedaa.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    client_invoice = 0;
                else
                    client_invoice = double.Parse(reader[0].ToString());
            }
            conn.Close();
            //------------------------------------------

            totalsales = resipt_client + general_receipt + client_invoice;
            //-----------------------------------------
            conn.Open();
            cmd.CommandText = @"select sum(value) from PAYMENTS_SUPPLIERS where PAYMENTS_SUPPLIERS.date between '" + datefromsahb.Value.Date.ToShortDateString() + "'" + " and '" + datetosahb.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    payment_supplier = 0;
                else
                    payment_supplier = double.Parse(reader[0].ToString());
            }
            conn.Close();
            //-----------------------------------------------
            conn.Open();
            cmd.CommandText = @"select sum(value) from GENERAL_PAYMENTS where GENERAL_PAYMENTS.date between '" + datefromsahb.Value.Date.ToShortDateString() + "'" + " and '" + datetosahb.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    general_payments = 0;
                else
                    general_payments = double.Parse(reader[0].ToString());
            }
            conn.Close();
            //------------------------------------------------
            conn.Open();
            cmd.CommandText = @"select sum(paid) from SUPPLIERS_INVOICE where SUPPLIERS_INVOICE.date between '" + datefromsahb.Value.Date.ToShortDateString() + "'" + " and '" + datetosahb.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    suppliers_invoice = 0;
                else
                    suppliers_invoice = double.Parse(reader[0].ToString());
            }
            conn.Close();
            //---------------------------------
            totalpaid = payment_supplier + general_payments + suppliers_invoice;
            //---------------------------------
            netprofit = totalsales - totalpaid;
            //------------------------
            txtnetprofit.Text = netprofit.ToString();



        }
        #endregion

        #region TOTAL_CASHIER
        private void btntotal_Click(object sender, EventArgs e)
        {
            if (datefromedaa.Value != datefromtotal.Value)
                MessageBox.Show("برجاء اختيار نفس الفتره التي تم اختيارها في الايداع والسحب");
            else if (datetoedaa.Value != datetototal.Value)
                MessageBox.Show("برجاء اختيار نفس الفتر هالتي تم اختيارها في الايداع والسحب");
            else if (datefromsahb.Value != datefromtotal.Value)
                MessageBox.Show("برجاء اختيار نفس الفتر هالتي تم اختيارها في الايداع والسحب");
            else if (datetosahb.Value != datetototal.Value)
                MessageBox.Show("برجاء اختيار نفس الفتر هالتي تم اختيارها في الايداع والسحب");
            else if (txtnetprofit.Text.Equals("") && txtexternalsourses.Text.Equals("") && txtadminsahb.Text.Equals(""))
                MessageBox.Show("برجاء حساب الايداع والسحب خلال فتره");
            else
            {
                double profit = double.Parse(txtnetprofit.Text);
                double external = double.Parse(txtexternalsourses.Text);
                double sahb = double.Parse(txtadminsahb.Text);
                txttotal.Text = ((profit + external) - sahb).ToString();
            }
        }
        #endregion

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select CASHIER.id,CASHIER.external_soures as المصدر_الخارجي,CASHIER.sahb as سحب_المالك,RESEIPTS_CLIENT.value as المقبوضات_من_عميل,PAYMENTS_SUPPLIERS.value as المدفوعات_لمورد,GENERAL_PAYMENTS.value as المدفوعات_العامة,GENERAL_RECEIPTS.value as المقبوضات_العامة,SUPPLIERS_INVOICE.paid as المدفوع_من_فواتير_المشتريات,CLIENT_INVOICE.paid as المقبوض_من_فواتير_المبيعات,CASHIER.date as التاريخ from CASHIER left join RESEIPTS_CLIENT on CASHIER.receiptsclient_id =RESEIPTS_CLIENT.id left join PAYMENTS_SUPPLIERS on CASHIER.paymentsuppliers_id =PAYMENTS_SUPPLIERS.id left join GENERAL_PAYMENTS on CASHIER.generalpayments_id =GENERAL_PAYMENTS.id left join GENERAL_RECEIPTS on CASHIER.generalreseipts_id =GENERAL_RECEIPTS.id left join SUPPLIERS_INVOICE on CASHIER.suplliersinvoice_id = SUPPLIERS_INVOICE.id left join CLIENT_INVOICE on CASHIER.clientinvoice_id =CLIENT_INVOICE.id  ";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cashiergrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void Cachier_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void cashiergrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cashiergrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
            else
            {
                cashiergrid.CurrentRow.Selected = true;
                id = int.Parse(cashiergrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtedaa.Text = cashiergrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtadminsahb.Text = cashiergrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            }
        }

        #region DELET EDAA
        private void btnedaadelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else  if (txtedaa.Text.Equals(""))
            {
                MessageBox.Show("اذاكنت تريد حذف الايداع برجاء اختيار صف يحتوي علي ايداع");
            }
            else
            {
                foreach (DataGridViewRow row in cashiergrid.SelectedRows)
                {
                    cashiergrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from CASHIER where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    txtedaa.Text = "";
                    MessageBox.Show("تم الحذف");
                    id = 0;
                }
            }
        }
        #endregion

        #region DELET SAHB
        private void btnsahbdelet_Click(object sender, EventArgs e)
        {

            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else if (txtadminsahb.Text.Equals(""))
            {
                MessageBox.Show("اذاكنت تريد حذف االسحب برجاء اختيار صف يحتوي علي سحب");
            }
            else
            {
                foreach (DataGridViewRow row in cashiergrid.SelectedRows)
                {
                    cashiergrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from CASHIER where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    txtadminsahb.Text = "";
                    MessageBox.Show("تم الحذف");
                    id = 0;
                }
            }
        }
        #endregion
    }
}
