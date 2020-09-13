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
    public partial class General_Payments_Detail : Form
    {
        string dateFromDummy = "", dateToDummy = "";
        int firstLoad = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public General_Payments_Detail()
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
                    cmd.CommandText = @"select sum(value) from GENERAL_PAYMENTS";
                else
                    cmd.CommandText = @"select sum(value) from GENERAL_PAYMENTS where GENERAL_PAYMENTS.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        txtValue.Text = "0";
                    else
                        txtValue.Text = reader[0].ToString();
                }
                conn.Close();
            }
            catch (Exception ex) { }
        }

        private void btnShowDuringPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (dateFromDummy == dateToDummy)
                    cmd.CommandText = @"select GENERAL_PAYMENTS.value القيمة,GENERAL_PAYMENTS.date التاريخ,GENERAL_PAYMENT_ITEMS.name  البند from GENERAL_PAYMENTS inner join GENERAL_PAYMENT_ITEMS on GENERAL_PAYMENT_ITEMS.id =GENERAL_PAYMENTS.paymentitems_id";
                else
                    cmd.CommandText = @" select GENERAL_PAYMENTS.value القيمة,GENERAL_PAYMENTS.date التاريخ,GENERAL_PAYMENT_ITEMS.name  البند from GENERAL_PAYMENTS inner join GENERAL_PAYMENT_ITEMS on GENERAL_PAYMENT_ITEMS.id =GENERAL_PAYMENTS.paymentitems_id where GENERAL_PAYMENTS.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridGeneralPayments.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("select GENERAL_PAYMENTS.value القيمة,GENERAL_PAYMENTS.date التاريخ,GENERAL_PAYMENTS.name  البند from GENERAL_PAYMENTS  where GENERAL_PAYMENTS.name LIKE N'%" + txtSarch.Text + "%'", conn);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                gridGeneralPayments.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
