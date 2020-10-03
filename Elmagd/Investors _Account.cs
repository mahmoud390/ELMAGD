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
    public partial class Investors__Account : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Investors__Account()
        {
            InitializeComponent();
        }

        private void Investors__Account_Load(object sender, EventArgs e)
        {
            Loadinvestor();
        }

        #region LOAD_INVESTOR
        private void Loadinvestor()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From INVESTORS", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر مستثمر---";
            dt.Rows.InsertAt(dr, 0);
            comboinvestor.ValueMember = "id";
            comboinvestor.DisplayMember = "name";
            comboinvestor.DataSource = dt;
        }
        #endregion

        // ايداع المستثمرين
        private void btnedaa_Click(object sender, EventArgs e)
        {
            double edaa = 0;
            if (txtedaa.Text.Equals(""))
                MessageBox.Show("برجاء إدخال مبلغ الإيداع");
            else if (comboinvestor.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار مستثمر");
            else
            {

                edaa = double.Parse(txtedaa.Text);
                conn.Open();
                cmd.CommandText = @"insert into INVESTOR_ACCOUNT (investor_id,edaa,date) values(@investor_id,@edaa,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@investor_id", comboinvestor.SelectedValue);
                cmd.Parameters.AddWithValue("@edaa", edaa);
                cmd.Parameters.AddWithValue("@date", date.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                txtedaa.Text = "";
                comboinvestor.SelectedIndex = 0;
                MessageBox.Show("تمت عمليه الإيداع");
                //---------------------------------
                // حركات الخزنة
                conn.Open();
                cmd.CommandText = @"select id from INVESTOR_ACCOUNT where INVESTOR_ACCOUNT.date = '" + date.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = @"insert into CASHIER (investoraccount_id,date) values(@investoraccount_id,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@investoraccount_id", id);
                cmd.Parameters.AddWithValue("@date", date.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();

            }
        }

        // إضاقة ارباح المستثمر
        private void btnadd_Click(object sender, EventArgs e)
        {
            double arbah = 0;
            if (txtarbah.Text.Equals(""))
                MessageBox.Show("برجاء إدخال قيمة الربح");
            else if (comboinvestor.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار مستثمر");
            else
            {
                arbah = double.Parse(txtarbah.Text);
                conn.Open();
                cmd.CommandText = @"insert into INVESTOR_ACCOUNT (investor_id,arbah,date) values(@investor_id,@arbah,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@investor_id", comboinvestor.SelectedValue);
                cmd.Parameters.AddWithValue("@arbah", arbah);
                cmd.Parameters.AddWithValue("@date", date.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                txtarbah.Text = "";
                comboinvestor.SelectedIndex = 0;
                MessageBox.Show("تمت عمليه الإضافة");
            }
        }
        // سحب المسثمر
        private void btnsahb_Click(object sender, EventArgs e)
        {
            double sahb = 0;
            if (txtsahb.Text.Equals(""))
                MessageBox.Show("برجاء إدخال قيمة السحب");
            else if (comboinvestor.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار مستثمر");
            else
            {
                sahb = double.Parse(txtsahb.Text);
                conn.Open();
                cmd.CommandText = @"insert into INVESTOR_ACCOUNT (investor_id,sahb,date) values(@investor_id,@sahb,@date)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@investor_id", comboinvestor.SelectedValue);
                cmd.Parameters.AddWithValue("@sahb", sahb);
                cmd.Parameters.AddWithValue("@date", date.Value.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
                txtsahb.Text = "";
                comboinvestor.SelectedIndex = 0;
                MessageBox.Show("تمت عمليه السحب");
            }
        }
        // حساب صافي حساب المستثمر
        private void btntotal_Click(object sender, EventArgs e)
        {
            if (comboinvestor.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار مستثمر");
            else
            {
                // اجمالي الايداع
                double sum_edaa = 0;
                double sum_arbah = 0;
                double sum_sahb = 0;
                conn.Open();
                cmd.CommandText = @"select sum(edaa) from INVESTOR_ACCOUNT where investor_id ='" + comboinvestor.SelectedValue + "' ";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        sum_edaa = 0;
                    else
                        sum_edaa = double.Parse(reader[0].ToString());
                }
                conn.Close();
                //----------------------------------------
                // اجمالي الارباح
              
                conn.Open();
                cmd.CommandText = @"select sum(arbah) from INVESTOR_ACCOUNT where investor_id ='" + comboinvestor.SelectedValue + "' ";
                cmd.Connection = conn;
                 reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        sum_arbah = 0;
                    else
                        sum_arbah = double.Parse(reader[0].ToString());
                }
                conn.Close();
                //-------------------------------------------------
                // اجمالي السحب
                conn.Open();
                cmd.CommandText = @"select sum(sahb) from INVESTOR_ACCOUNT where investor_id ='" + comboinvestor.SelectedValue + "' ";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        sum_sahb = 0;
                    else
                        sum_sahb = double.Parse(reader[0].ToString());
                }
                conn.Close();
                //-----------------------------------
                txttotal.Text = ((sum_edaa + sum_arbah) - sum_sahb).ToString();
            }
        }


    }
}
