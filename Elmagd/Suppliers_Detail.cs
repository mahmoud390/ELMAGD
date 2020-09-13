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
    public partial class Suppliers_Detail : Form
    {
        string dateFromDummy = "", dateToDummy = "";
        int firstLoad = 0;
        double supplier_invoice_paid=0,payment_suppliers_value=0;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        
        public Suppliers_Detail()
        {
            InitializeComponent();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            firstLoad = 1;
            dateFromDummy = dateFrom.Value.Date.ToShortDateString();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            firstLoad = 1;
            dateToDummy = dateTo.Value.Date.ToShortDateString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (dateFromDummy == dateToDummy)
                    cmd.CommandText = @"select sum(paid) from SUPPLIERS_INVOICE";
                else
                    cmd.CommandText = @"select sum(paid) from SUPPLIERS_INVOICE where SUPPLIERS_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        supplier_invoice_paid = 0;
                    else
                        supplier_invoice_paid = double.Parse(reader[0].ToString());
                }
                conn.Close();
                //---------------------------
                conn.Open();
                if (dateFromDummy == dateToDummy)
                    cmd.CommandText = @"select sum(value) from PAYMENTS_SUPPLIERS";
                else
                    cmd.CommandText = @"select sum(value) from PAYMENTS_SUPPLIERS where PAYMENTS_SUPPLIERS.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'  ";
                cmd.Connection = conn;
                SqlDataReader reader_payment_sup = cmd.ExecuteReader();
                while (reader_payment_sup.Read())
                {
                    if (reader_payment_sup[0].ToString() == "")
                        payment_suppliers_value = 0;
                    else
                        payment_suppliers_value = double.Parse(reader_payment_sup[0].ToString());

                }
                conn.Close();
                txtValue.Text = (payment_suppliers_value + supplier_invoice_paid).ToString();
            }
            catch (Exception ex) { }
        }

        private void btnShowDuringPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (dateFromDummy == dateToDummy)
                    cmd.CommandText = @"select SUPPLIERS_INVOICE.paid 'المدفوع للمورد',SUPPLIERS_INVOICE.baky as 'الباقي من فواتير الموردين',SUPPLIERS_INVOICE.date التاريخ,SUPPLIERS.name المورد  from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id=SUPPLIERS.id ";
                else
                    cmd.CommandText = @"select SUPPLIERS_INVOICE.paid 'المدفوع للمورد',SUPPLIERS_INVOICE.baky as 'الباقي من فواتير الموردين',SUPPLIERS_INVOICE.date التاريخ,SUPPLIERS.name المورد from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id=SUPPLIERS.id  where SUPPLIERS_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridsuppliers.DataSource = dt;
                conn.Close();
                //---------------------------------------
                //المدفوع لمورد من المدفوعات للمورد
                conn.Open();
                if (dateFromDummy == dateToDummy)
                    cmd.CommandText = @"select PAYMENTS_SUPPLIERS.value 'المدفوع للمورد',PAYMENTS_SUPPLIERS.date التاريخ,SUPPLIERS.name المورد  from PAYMENTS_SUPPLIERS inner join SUPPLIERS on PAYMENTS_SUPPLIERS.suppliers_id=SUPPLIERS.id ";
                else
                    cmd.CommandText = @"select PAYMENTS_SUPPLIERS.value 'المدفوع للمورد',PAYMENTS_SUPPLIERS.date التاريخ,SUPPLIERS.name المورد  from PAYMENTS_SUPPLIERS inner join SUPPLIERS on PAYMENTS_SUPPLIERS.suppliers_id=SUPPLIERS.id  where PAYMENTS_SUPPLIERS.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataAdapter da_paymint_sup = new SqlDataAdapter(cmd);
                DataTable dt_payment_sup = new DataTable();
                da_paymint_sup.Fill(dt_payment_sup);
                gridsupplierspayments.DataSource = dt_payment_sup;
                conn.Close();
            }
            catch (Exception ex) { }
        }

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("select SUPPLIERS_INVOICE.paid المدفوع_للمورد,SUPPLIERS_INVOICE.date التاريخ,SUPPLIERS.name إسم_المورد  from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id=SUPPLIERS.id where SUPPLIERS.name LIKE N'%" + txtSarch.Text + "%'", conn);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                gridsuppliers.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }
    }
}
