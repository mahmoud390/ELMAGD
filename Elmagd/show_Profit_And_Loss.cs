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
    public partial class show_Profit_And_Loss : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public show_Profit_And_Loss()
        {
            InitializeComponent();
        }

        private void show_Profit_And_Loss_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select id  as 'م',total_sales as 'إجمالي المبيعات',return_sales as 'مردودات المبيعات',net_sales as 'صافي المبيعات',purchases as 'إجمالي المشتريات',return_purchase as 'مردودات المشتريات',total_purchase as 'صافي المستريات',first_term as 'رصيد اول المدة',available_goods as 'تكلفة البضاعة المتاحة',last_term  as 'رصيد أخر المدة',costof_goods as 'تكلفة البضاعة المباعة',net_profit as 'صافي الربح',general_paymentd as 'إجالي المدفوعات العامة',general_recepits as 'إجمالي المقبوضات العامة',totalnet_profit as 'إجمالي صافر الربح',datefrom  as 'التاريخ من ',dateto as 'التاريخ إالي' from PROFIT_AND_LOSS";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            profit_nd_lossgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

    }
}
