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
        string password, userName;
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

            }
        }

      

       

       
    }
}
