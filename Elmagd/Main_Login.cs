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
    public partial class Main_Login : Form
    {
        string password, userName, activationCode;
        DateTime currentDate;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Main_Login()
        {
            InitializeComponent();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "إسم المستخدم";
                txtName.ForeColor = Color.Orange;

            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "كلمة المرور")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;

            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "إسم المستخدم")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.LightGray;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "كلمة المرور";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("يجب إدخال البريد إسم المستخدم اولا");
                txtName.Focus();
            }
            else if (txtpass.Text.Equals(""))
            {
                MessageBox.Show("يجب إدخال كلمة المرور");
                txtpass.Focus();
            }
            else
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select [key],id from ACTIVATION", conn);
                SqlDataReader dataReader2 = cmd2.ExecuteReader();
                dataReader2.Read();
                if (txtAcivateCode.Text != "")
                {
                    while (dataReader2.Read())
                    {
                        if (txtAcivateCode.Text == dataReader2[0].ToString())
                        {
                            int id = int.Parse(dataReader2[1].ToString());
                            currentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                            currentDate = AddMonthToEndOfMonth(currentDate, 3);
                            conn.Close();
                            conn.Open();
                            cmd.CommandText = @"UPDATE ADMIN SET activationCode = '" + txtAcivateCode.Text + "' , expireDate = '" + currentDate.ToShortDateString() + "'";
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            conn.Close();
                            conn.Open();
                            cmd.CommandText = @"DELETE from ACTIVATION where id = '" + id + "'";
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            break;
                        }
                    }
                }
                conn.Close();
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select expireDate,activationCode from ADMIN", conn);
                SqlDataReader dataReader1 = cmd1.ExecuteReader();
                dataReader1.Read();
                if (DateTime.Parse(DateTime.Now.ToShortDateString()) >= DateTime.Parse(dataReader1[0].ToString()))
                {
                    if (txtAcivateCode.Text != "")
                        MessageBox.Show("كود التفعيل غير صحيح!!! للتفعيل اتصل بالرقم الأتى 01006209613");
                    else
                        MessageBox.Show("يجب تفعيل البرنامج!!! للتفعيل اتصل بالرقم الأتى 01006209613");
                    conn.Close();
                    Application.Exit();
                }
                else
                {
                    conn.Close();
                    password = txtpass.Text;
                    userName = txtName.Text;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select username,Password from ADMIN where username='" + userName + "' and password='" + password + "' ", conn);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        Homeform homeform = new Homeform();
                        homeform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("برجاء التاكد من كتابة إسم المستخدم وكلمة المرور بشكل صحيح");
                    }
                    conn.Close();
                    // back up from data base
                    string fileName = "E:\\imp\\publish\\Application Files\\Elmagd_1_0_0_0\\BUCKUP" + "\\ELMAGD" + DateTime.Now.ToShortDateString().Replace('/', '-') + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                    string stquary = "Backup Database ELMAGD to Disk='" + fileName + ".bak'";
                    cmd = new SqlCommand(stquary, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static DateTime AddMonthToEndOfMonth(DateTime date, int numberOfMonths)
        {
            DateTime nextMonth = date.AddMonths(numberOfMonths);

            if (date.Day != DateTime.DaysInMonth(date.Year, date.Month)) //is last day in month
            {
                //any other day then last day
                return nextMonth;
            }
            else
            {
                //if date was end of month, add remaining days
                int addDays = DateTime.DaysInMonth(nextMonth.Year, nextMonth.Month) - nextMonth.Day;
                return nextMonth.AddDays(addDays);
            }
        }
    }
}
