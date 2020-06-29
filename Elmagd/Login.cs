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
    public partial class Login : Form
    {
        string password, userName;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();
        }

        #region LOGIN
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Equals(""))
            {
                MessageBox.Show("يجب إدخال البريد إسم المستخدم اولا");
                txtusername.Focus();
            }
            else if (txtpassword.Text.Equals(""))
            {
                MessageBox.Show("يجب إدخال كلمة المرور");
                txtpassword.Focus();
            }
            else
            {
                password = txtpassword.Text;
                userName = txtusername.Text;
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
        #endregion

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
