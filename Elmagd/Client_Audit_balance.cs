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
    public partial class Client_Audit_balance : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Client_Audit_balance()
        {
            InitializeComponent();
        }

        private void Client_Audit_balance_Load(object sender, EventArgs e)
        {
            Loadclient();
        }
        #region LOAD_CLIENT
        private void Loadclient()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From CLIENT", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر عميل---";
            dt.Rows.InsertAt(dr, 0);
            comboclient.ValueMember = "id";
            comboclient.DisplayMember = "name";
            comboclient.DataSource = dt;
        }
        #endregion

        private void btnShowDuringPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboclient.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختيار عميل");
                else
                {
                    conn.Open();
                    cmd.CommandText = @"select CLIENT.name as 'إٍسم العميل',CATEGORY.name as 'الصنف' ,CLIENT_INVOICE.quantity as 'الكمية',QUANTITY_TYPE.name as 'نوع الكمية',CLIENT_INVOICE.price as 'السعر',CLIENT_INVOICE.rest as 'الإجمالي',CLIENT_INVOICE.paid  as 'المدفوع',CLIENT_INVOICE.baky as 'الباقي',CLIENT_INVOICE.date as 'التاريخ' from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id = CLIENT.id inner join CATEGORY on CLIENT_INVOICE.cat_id = CATEGORY.id inner join QUANTITY_TYPE on CLIENT_INVOICE.quantitytype_id =QUANTITY_TYPE.id where CLIENT_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "' and client_id ='" + comboclient.SelectedValue + "'";
                    cmd.Connection = conn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bakeygrid.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex) { }
        }

        private void showAutoGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboclient.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختيار عميل");
                else
                {
                    conn.Open();
                    cmd.CommandText = @"select CLIENT.name as 'إٍسم العميل',CATEGORY.name as 'الصنف' ,CLIENT_INVOICE.quantity as 'الكمية',QUANTITY_TYPE.name as 'نوع الكمية',CLIENT_INVOICE.price as 'السعر',CLIENT_INVOICE.rest as 'الإجمالي',CLIENT_INVOICE.paid  as 'المدفوع',CLIENT_INVOICE.baky as 'الباقي',CLIENT_INVOICE.date as 'التاريخ' from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id = CLIENT.id inner join CATEGORY on CLIENT_INVOICE.cat_id = CATEGORY.id inner join QUANTITY_TYPE on CLIENT_INVOICE.quantitytype_id =QUANTITY_TYPE.id where client_id ='" + comboclient.SelectedValue + "' ";
                    cmd.Connection = conn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bakeygrid.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex) { }
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            if (comboclient.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار عميل");
            else
            {
                double total_clientINO = 0;
                double total_paid = 0;
                double total_receptis = 0;

                conn.Open();
                cmd.CommandText = @"select sum(rest) from CLIENT_INVOICE where client_id ='" + comboclient.SelectedValue + "' ";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        total_clientINO = 0;
                    else
                        total_clientINO = double.Parse(reader[0].ToString());
                }
                conn.Close();
                txttotal.Text = total_clientINO.ToString();
                //--------------------------------------------
                //----------------------------------------
                conn.Open();
                cmd.CommandText = @"select sum(paid) from CLIENT_INVOICE where client_id ='" + comboclient.SelectedValue + "' ";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        total_paid = 0;
                    else
                        total_paid = double.Parse(reader[0].ToString());
                }
                conn.Close();
                //---------------------------------------------
                conn.Open();
                cmd.CommandText = @"select sum(value) from RESEIPTS_CLIENT where client_id ='" + comboclient.SelectedValue + "' ";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        total_receptis = 0;
                    else
                        total_receptis = double.Parse(reader[0].ToString());
                }
                conn.Close();
                txtpaid.Text = (total_paid + total_receptis).ToString();
                //-------------------------------------------
                //-------------------------------------------
                txtbaky.Text = (total_clientINO - (total_paid + total_receptis)).ToString();
            }
        }

        //حساب العميل خلال فترة
        private void btnhesab_Click(object sender, EventArgs e)
        {
            if (comboclient.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار عميل");
            else
            {
                double total_clientINO = 0;
                double total_paid = 0;
                double total_receptis = 0;

                conn.Open();
                cmd.CommandText = @"select sum(rest) from CLIENT_INVOICE where CLIENT_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "' and client_id ='" + comboclient.SelectedValue + "' ";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        total_clientINO = 0;
                    else
                        total_clientINO = double.Parse(reader[0].ToString());
                }
                conn.Close();
                txttotal.Text = total_clientINO.ToString();
                //--------------------------------------------
                //----------------------------------------
                conn.Open();
                cmd.CommandText = @"select sum(paid) from CLIENT_INVOICE where CLIENT_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "' and client_id ='" + comboclient.SelectedValue + "' ";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        total_paid = 0;
                    else
                        total_paid = double.Parse(reader[0].ToString());
                }
                conn.Close();
                //---------------------------------------------
                conn.Open();
                cmd.CommandText = @"select sum(value) from RESEIPTS_CLIENT where RESEIPTS_CLIENT.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "' and client_id ='" + comboclient.SelectedValue + "' ";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        total_receptis = 0;
                    else
                        total_receptis = double.Parse(reader[0].ToString());
                }
                conn.Close();
                txtpaid.Text = (total_paid + total_receptis).ToString();
                //-------------------------------------------
                //-------------------------------------------
                txtbaky.Text = (total_clientINO - (total_paid + total_receptis)).ToString();
            }
        }
    }
}
