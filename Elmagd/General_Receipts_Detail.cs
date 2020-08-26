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
    public partial class General_Receipts_Detail : Form
    {
        string dateFromDummy = "", dateToDummy = "";
        int firstLoad = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public General_Receipts_Detail()
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
                cmd.CommandText = @"select sum(value) from GENERAL_RECEIPTS";
            else
                cmd.CommandText = @"select sum(value) from GENERAL_RECEIPTS where GENERAL_RECEIPTS.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
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
                    cmd.CommandText = @"select GENERAL_RECEIPTS.value القيمة,GENERAL_RECEIPTS.date التاريخ,GENERAL_RECEIPTS_ITEMS.name  البند from GENERAL_RECEIPTS inner join GENERAL_RECEIPTS_ITEMS on GENERAL_RECEIPTS_ITEMS.id=GENERAL_RECEIPTS.recepitsitems_id";
                else
                    cmd.CommandText = @" select GENERAL_RECEIPTS.value القيمة,GENERAL_RECEIPTS.date التاريخ,GENERAL_RECEIPTS_ITEMS.name  البند from GENERAL_RECEIPTS inner join GENERAL_RECEIPTS_ITEMS on GENERAL_RECEIPTS_ITEMS.id=GENERAL_RECEIPTS.recepitsitems_id where GENERAL_RECEIPTS.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridGeneralReceipts.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select GENERAL_RECEIPTS.value القيمة,GENERAL_RECEIPTS.date التاريخ,GENERAL_RECEIPTS.name  البند from GENERAL_RECEIPTS  where GENERAL_RECEIPTS.name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            gridGeneralReceipts.DataSource = dt;
            conn.Close();
        }
    }
}
