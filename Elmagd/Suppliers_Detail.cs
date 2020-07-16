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
                    cmd.CommandText = @"select SUPPLIERS_INVOICE.paid المدفوع_للمورد,SUPPLIERS_INVOICE.date التاريخ,SUPPLIERS.name إسم_المورد  from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id=SUPPLIERS.id ";
                else
                    cmd.CommandText = @"select SUPPLIERS_INVOICE.paid المدفوع_للمورد,SUPPLIERS_INVOICE.date التاريخ,SUPPLIERS.name إسم_المورد from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id=SUPPLIERS.id  where SUPPLIERS_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridClient.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select SUPPLIERS_INVOICE.paid المدفوع_للمورد,SUPPLIERS_INVOICE.date التاريخ,SUPPLIERS.name إسم_المورد  from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id=SUPPLIERS.id where SUPPLIERS.name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            gridClient.DataSource = dt;
            conn.Close();
        }
    }
}
