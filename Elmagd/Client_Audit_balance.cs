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
    public partial class Client_Audit_balance : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Client_Audit_balance()
        {
            InitializeComponent();
        }

        private void Client_Audit_balance_Load(object sender, EventArgs e)
        {

        }

        private void btnShowDuringPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.CommandText = @"select CLIENT.name as الإسم,CLIENT_INVOICE.baky as الباقي,CLIENT_INVOICE.date as التاريخ from CLIENT_INVOICE inner join CLIENT on CLIENT.id = CLIENT_INVOICE.client_id where CLIENT_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bakeygrid.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }

        private void showAutoGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.CommandText = @"select CLIENT.name as الإسم,CLIENT_INVOICE.baky as الباقي,CLIENT_INVOICE.date as التاريخ from CLIENT_INVOICE inner join CLIENT on CLIENT.id = CLIENT_INVOICE.client_id ";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bakeygrid.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }
    }
}
