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
    public partial class Commission_Detail : Form
    {
        string dateFromDummy = "", dateToDummy = "";
        int firstLoad = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public Commission_Detail()
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
            conn.Open();
            if (dateFromDummy == dateToDummy)
                cmd.CommandText = @"select sum(commission) from CLIENT_INVOICE";
            else
                cmd.CommandText = @"select sum(commission) from CLIENT_INVOICE where CLIENT_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
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

        private void btnShowDuringPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (dateFromDummy == dateToDummy)
                    cmd.CommandText = @"select CLIENT_INVOICE.commission العمولات,CLIENT_INVOICE.date التاريخ,CLIENT.name اسم_العميل,STORE.name اسم_المخزن from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id inner join STORE on CLIENT_INVOICE.store_id=STORE.id";
                else
                    cmd.CommandText = @"select CLIENT_INVOICE.commission العمولات,CLIENT_INVOICE.date التاريخ,CLIENT.name اسم_العميل,STORE.name اسم_المخزن  from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id inner join STORE on CLIENT_INVOICE.store_id=STORE.id where CLIENT_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridCommission.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select CLIENT_INVOICE.commission العمولات,CLIENT_INVOICE.date التاريخ,CLIENT.name اسم_العميل,STORE.name اسم_المخزن from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id inner join STORE on CLIENT_INVOICE.store_id=STORE.id  where CLIENT.name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            gridCommission.DataSource = dt;
            conn.Close();
        }
    }
}
