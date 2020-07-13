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
    public partial class Mashal_Detail : Form
    {
        string dateFromDummy = "", dateToDummy = "";
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;User ID=test;Password=test;");
        SqlCommand cmd = new SqlCommand();
        public Mashal_Detail()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            conn.Open();
            if (dateFromDummy == dateToDummy)
                cmd.CommandText = @"select sum(mashal) from CLIENT_INVOICE";
            else
                cmd.CommandText = @"select sum(mashal) from CLIENT_INVOICE where CLIENT_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
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

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            dateFromDummy = dateFrom.Value.Date.ToShortDateString();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            dateToDummy = dateTo.Value.Date.ToShortDateString();
        }

        private void btnShowDuringPeriod_Click(object sender, EventArgs e)
        {
            conn.Open();
            if(dateFromDummy == dateToDummy)
                cmd.CommandText = @"select CLIENT_INVOICE.mashal المشال,CLIENT_INVOICE.date التاريخ,CLIENT.name اسم_العميل,STORE.name اسم_المخزن from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id inner join STORE on CLIENT_INVOICE.store_id=STORE.id";
            else
                cmd.CommandText = @"select CLIENT_INVOICE.mashal المشال,CLIENT_INVOICE.date التاريخ,CLIENT.name اسم_العميل,STORE.name اسم_المخزن  from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id inner join STORE on CLIENT_INVOICE.store_id=STORE.id where CLIENT_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridMashal.DataSource = dt;
            conn.Close();
        }
    }
}
