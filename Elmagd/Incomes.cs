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
    public partial class Incomes : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;User ID=test;Password=test;");
        SqlCommand cmd = new SqlCommand();
        public Incomes()
        {
            InitializeComponent();
        }

        private void Incomes_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select SUPPLIERS_INVOICE.id,SUPPLIERS.name as إسم_المورد,CATEGORY.name as إسم_الصنف,SUPPLIERS_INVOICE.quantity as الكمية,QUANTITY_TYPE.name as نوع_الكمية,SUPPLIERS_INVOICE.price as السعر,SUPPLIERS_INVOICE.total as الإجمالي,SUPPLIERS_INVOICE.biskoul as بسكول,SUPPLIERS_INVOICE.mashal as مشال,SUPPLIERS_INVOICE.commissions as عمولات,SUPPLIERS_INVOICE.rest as الإجمالي_بعدالخصم,SUPPLIERS_INVOICE.paid as المدفوع,SUPPLIERS_INVOICE.baky as الباقي,SUPPLIERS_INVOICE.date as التاريخ from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id =SUPPLIERS.id inner join CATEGORY on SUPPLIERS_INVOICE.catid =CATEGORY.id inner join QUANTITY_TYPE on SUPPLIERS_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on SUPPLIERS_INVOICE.store_id =STORE.id";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            incomesgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select SUPPLIERS_INVOICE.id,SUPPLIERS.name,CATEGORY.name,SUPPLIERS_INVOICE.quantity,QUANTITY_TYPE.name,SUPPLIERS_INVOICE.price,SUPPLIERS_INVOICE.total,SUPPLIERS_INVOICE.biskoul,SUPPLIERS_INVOICE.mashal,SUPPLIERS_INVOICE.commissions,SUPPLIERS_INVOICE.rest,SUPPLIERS_INVOICE.paid,SUPPLIERS_INVOICE.baky from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id =SUPPLIERS.id inner join CATEGORY on SUPPLIERS_INVOICE.catid =CATEGORY.id inner join QUANTITY_TYPE on SUPPLIERS_INVOICE.quantitytype_id =QUANTITY_TYPE.id inner join STORE on SUPPLIERS_INVOICE.store_id =STORE.id where SUPPLIERS.name  LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            incomesgrid.DataSource = dt;
            conn.Close();
        }
    }
}
