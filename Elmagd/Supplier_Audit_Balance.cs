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
    public partial class Supplier_Audit_Balance : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Supplier_Audit_Balance()
        {
            InitializeComponent();
        }

        private void Supplier_Audit_Balance_Load(object sender, EventArgs e)
        {

        }

        private void btnShowDuringPeriod_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select SUPPLIERS.name as الإسم,SUPPLIERS_INVOICE.baky as الباقي,SUPPLIERS_INVOICE.date as التاريخ from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS.id = SUPPLIERS_INVOICE.suppliers_id where SUPPLIERS_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bakeygrid.DataSource = dt;
            conn.Close();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select SUPPLIERS.name as الإسم,SUPPLIERS_INVOICE.baky as الباقي,SUPPLIERS_INVOICE.date as التاريخ from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS.id = SUPPLIERS_INVOICE.suppliers_id ";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bakeygrid.DataSource = dt;
            conn.Close();
        }
    }
}
