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
    public partial class Sales : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Sales()
        {
            InitializeComponent();
        }

        #region LOAD_PAGE
        private void Sales_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        #endregion

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select CLIENT_INVOICE.id,CLIENT.name as إسم_العميل,CATEGORY.name as إسم_الصنف,CLIENT_INVOICE.quantity as الكمية,QUANTITY_TYPE.name as نوع_الكمية,CLIENT_INVOICE.price as السعر,CLIENT_INVOICE.total as الإجمالي,CLIENT_INVOICE.biskoul as بسكول,CLIENT_INVOICE.mashal as مشال,CLIENT_INVOICE.commission as عمولات,CLIENT_INVOICE.rest as الإجمالي_بعد_الإضافات,CLIENT_INVOICE.paid as المدفوع,CLIENT_INVOICE.baky as الباقي,CLIENT_INVOICE.date as التاريخ from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id inner join CATEGORY on CLIENT_INVOICE.cat_id =CATEGORY.id inner join QUANTITY_TYPE on CLIENT_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on CLIENT_INVOICE.store_id =STORE.id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            salesgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        #region SEARCH
        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select SALES.id, CLIENT.name,CATEGORY.name,SALES.quantity,QUANTITY_TYPE.name,STORE.name,SALES.rest,SALES.date from SALES inner join CLIENT on SALES.cat_id =CLIENT.id inner join CATEGORY on SALES.cat_id =CATEGORY.id inner join QUANTITY_TYPE on SALES.quantitytype_id =QUANTITY_TYPE.id inner join STORE on SALES.store_id =STORE.id where CLIENT.name  LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            salesgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
