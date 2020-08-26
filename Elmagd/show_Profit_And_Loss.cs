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
            cmd.CommandText = @"select id,total_sales,return_sales,net_sales,purchases,return_purchase,total_purchase,first_term,available_goods,last_term,costof_goods,net_profit,general_paymentd,general_recepits,totalnet_profit,datefrom,dateto from PROFIT_AND_LOSS";
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
