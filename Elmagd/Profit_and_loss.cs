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
    public partial class Profit_and_loss : Form
    {
        double totalsales, returnsales, netsales,totalpurchase,returnpurchase,netparchase,firstterm,lastnetpranches,totalavailablgoods,lastterm,totalnetsales,totalcostgoods,generalpayment,generalrecepits,totalnetprofit,lasttotalnetprofit;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Profit_and_loss()
        {
            InitializeComponent();
        }

        private void Profit_and_loss_Load(object sender, EventArgs e)
        {

        }

        

        private void btnTotalsales_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(paid) from CLIENT_INVOICE where CLIENT_INVOICE.date between '" + datefrom.Value.Date.ToShortDateString() + "'" + " and '" + dateto.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txttotalsales.Text = "0";
                else
                    txttotalsales.Text = reader[0].ToString();
            }
            conn.Close();
        }

        private void btnreturnsales_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(total) from SALES_RETURNS where SALES_RETURNS.date between '" + datefrom.Value.Date.ToShortDateString() + "'" + " and '" + dateto.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtreturnsales.Text = "0";
                else
                    txtreturnsales.Text = reader[0].ToString();
            }
            conn.Close();
        }

        private void btnnetsales_Click(object sender, EventArgs e)
        {
            if (txttotalsales.Text.Equals(""))
                MessageBox.Show("برجاء حساب اجمالي المبيعات اولا");
            else if (txtreturnsales.Text.Equals(""))
                MessageBox.Show("برجاء حساب اجمالي مردودات المبيعات");
            else
            {
                totalsales = double.Parse(txttotalsales.Text);
                returnsales = double.Parse(txtreturnsales.Text);
                netsales = totalsales - returnsales;
                txtnetsales.Text = netsales.ToString();
            }
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(paid) from SUPPLIERS_INVOICE where SUPPLIERS_INVOICE.date between '" + datefrom.Value.Date.ToShortDateString() + "'" + " and '" + dateto.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtpurchase.Text = "0";
                else
                    txtpurchase.Text = reader[0].ToString();
            }
            conn.Close();
        }

        private void btnreturnpurchase_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(total) from PURCHASE_RETURNED where PURCHASE_RETURNED.date between '" + datefrom.Value.Date.ToShortDateString() + "'" + " and '" + dateto.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtreturnpurchase.Text = "0";
                else
                    txtreturnpurchase.Text = reader[0].ToString();
            }
            conn.Close();
        }

        private void btnnetpruchase_Click(object sender, EventArgs e)
        {
            if (txtpurchase.Text.Equals(""))
                MessageBox.Show("برجاء حساب اجمالي المشتريات");
            else if (txtreturnpurchase.Text.Equals(""))
                MessageBox.Show("برجاء حساب اجمالي مردودات المشتريات");
            else
            {
                totalpurchase = double.Parse(txtpurchase.Text);
                returnpurchase = double.Parse(txtreturnpurchase.Text);
                netparchase = totalpurchase - returnpurchase;
                txtnetpurchase.Text = netparchase.ToString();
            }
        }

        private void btnavailablgoods_Click(object sender, EventArgs e)
        {
            if (txtfirstterm.Text.Equals(""))
                MessageBox.Show("برجاء ادخال رصيد اول المدة");
            else if (txtnetpurchase.Text.Equals(""))
                MessageBox.Show("برجاء حساب صافي المشتريات");
            else
            {
                firstterm = double.Parse(txtfirstterm.Text);
                lastnetpranches = double.Parse(txtnetpurchase.Text);
                txtavailablgoods.Text = (firstterm + lastnetpranches).ToString();

            }
        }

        private void btncostofgoods_Click(object sender, EventArgs e)
        {
            if (txtavailablgoods.Text.Equals(""))
                MessageBox.Show("برجاء حساب البضاعة المتاحة للبيع");
            else if (txtlasttrem.Text.Equals(""))
                MessageBox.Show("برجاء ادخال رصيد اخر المدة");
            else
            {
                totalavailablgoods = double.Parse(txtavailablgoods.Text);
                lastterm = double.Parse(txtlasttrem.Text);
                txtcostofgoods.Text = (totalavailablgoods - lastterm).ToString();
            }
        }

        private void btnnetprofit_Click(object sender, EventArgs e)
        {
            if (txtnetsales.Text.Equals(""))
                MessageBox.Show("برجاء حساب صافي المبيعات");
            else if (txtcostofgoods.Text.Equals(""))
                MessageBox.Show("برجاء حساب تلكفة البضاعة المباعة");
            else
            {
                totalnetsales = double.Parse(txtnetsales.Text);
                totalcostgoods = double.Parse(txtcostofgoods.Text);
                txtnetprofit.Text = (totalnetsales - totalcostgoods).ToString();
            }
        }

        private void btngeneralpayment_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(value) from GENERAL_PAYMENTS where GENERAL_PAYMENTS.date between '" + datefrom.Value.Date.ToShortDateString() + "'" + " and '" + dateto.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtgeneralpayment.Text = "0";
                else
                    txtgeneralpayment.Text = reader[0].ToString();
            }
            conn.Close();
        }

        private void btngeneralrecepits_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = @"select sum(value) from GENERAL_RECEIPTS where GENERAL_RECEIPTS.date between '" + datefrom.Value.Date.ToShortDateString() + "'" + " and '" + dateto.Value.Date.ToShortDateString() + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    txtgeneralrecepits.Text = "0";
                else
                    txtgeneralrecepits.Text = reader[0].ToString();
            }
            conn.Close();
        }

        private void btntotalnetprofit_Click(object sender, EventArgs e)
        {
            if (txtnetprofit.Text.Equals(""))
                MessageBox.Show("برجاء حساب صافي الربح");
            else if (txtgeneralpayment.Text.Equals(""))
                MessageBox.Show("برجاء حساب اجمالي المدفوعات العامة");
            else if (txtgeneralrecepits.Text.Equals(""))
                MessageBox.Show("برجاء حساب اجمالي المقبوضات العامة");
            else
            {
                generalpayment = double.Parse(txtgeneralpayment.Text);
                generalrecepits = double.Parse(txtgeneralrecepits.Text);
                totalnetprofit = double.Parse(txtnetprofit.Text);
                lasttotalnetprofit = (totalnetprofit + generalrecepits) - generalpayment;
                txttotalnetprofit.Text = lasttotalnetprofit.ToString();

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            cmd.CommandText = @"insert into PROFIT_AND_LOSS ( total_sales,return_sales,net_sales,purchases,return_purchase,total_purchase,first_term,available_goods,last_term,costof_goods,net_profit,general_paymentd,general_recepits,totalnet_profit,datefrom,dateto) values (@total_sales,@return_sales,@net_sales,@purchases,@return_purchase,@total_purchase,@first_term,@available_goods,@last_term,@costof_goods,@net_profit,@general_paymentd,@general_recepits,@totalnet_profit,@datefrom,@dateto)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@total_sales", double.Parse(txttotalsales.Text));
            cmd.Parameters.AddWithValue("@return_sales", double.Parse(txtreturnsales.Text));
            cmd.Parameters.AddWithValue("@net_sales", double.Parse(txtnetsales.Text));
            cmd.Parameters.AddWithValue("@purchases", double.Parse(txtpurchase.Text));
            cmd.Parameters.AddWithValue("@return_purchase", double.Parse(txtreturnpurchase.Text));
            cmd.Parameters.AddWithValue("@total_purchase", double.Parse(txtnetpurchase.Text));
            cmd.Parameters.AddWithValue("@first_term", double.Parse(txtfirstterm.Text));
            cmd.Parameters.AddWithValue("@available_goods", double.Parse(txtavailablgoods.Text));
            cmd.Parameters.AddWithValue("@last_term", double.Parse(txtlasttrem.Text));
            cmd.Parameters.AddWithValue("@costof_goods", double.Parse(txtcostofgoods.Text));
            cmd.Parameters.AddWithValue("@net_profit", double.Parse(txtnetprofit.Text));
            cmd.Parameters.AddWithValue("@general_paymentd", double.Parse(txtgeneralpayment.Text));
            cmd.Parameters.AddWithValue("@general_recepits", double.Parse(txtgeneralrecepits.Text));
            cmd.Parameters.AddWithValue("@totalnet_profit", double.Parse(txttotalnetprofit.Text));
            cmd.Parameters.AddWithValue("@datefrom", datefrom.Value.Date.ToShortDateString());
            cmd.Parameters.AddWithValue("@dateto", dateto.Value.Date.ToShortDateString());
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.Close();
            txttotalsales.Text = "";
            txtreturnsales.Text = "";
            txttotalsales.Text = "";
            txtpurchase.Text = "";
            txtreturnpurchase.Text = "";
            txtnetpurchase.Text = "";
            txtfirstterm.Text = "";
            txtavailablgoods.Text = "";
            txtlasttrem.Text = "";
            txtcostofgoods.Text = "";
            txtnetprofit.Text = "";
            txtgeneralpayment.Text = "";
            txtgeneralrecepits.Text = "";
            txttotalnetprofit.Text = "";
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

      

     
    }
}
