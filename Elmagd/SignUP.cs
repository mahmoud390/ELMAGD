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
    public partial class SignUP : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public SignUP()
        {
            InitializeComponent();
        }

        #region ADD_ADMIN
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Equals(""))
                MessageBox.Show("برجاء إدخال الاسم ");
            else if (txtphone.Text.Equals(""))
                MessageBox.Show("برجاء إدخال الهاتف");
            else if (txtusername.Text.Equals(" "))
                MessageBox.Show("برجاء إدخال اسم المستخدم");
            else if (txtpassword.Text.Equals(""))
                MessageBox.Show("برجاء إدخال الباسورد");
            {

                //التشيك علي اسم المستخدم اذا كان موجود\ بالفعل
                conn.Open();
                SqlCommand cmd = new SqlCommand("select username from ADMIN where username ='" + txtusername + "' ", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    MessageBox.Show("هذا البريد الالكتروني موجود بالفعل");
                    txtusername.Text = "";
                    txtusername.Focus();
                    conn.Close();
                }
                else
                {
                    
                    // إضافة بيانات الادمن
                    conn.Close();
                    conn.Open();
                    cmd.CommandText = @"insert into ADMIN ( name,phone,username,Password) values (@name,@phone,@username,@Password)";
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    conn.Close();
                    txtname.Text = "";
                    txtphone.Text = "";
                    txtpassword.Text = "";
                    txtusername.Text = "";
                    MessageBox.Show("تمت عملية الاضافة بنجاح");
                }
            }
        }
        #endregion

        // txtname_changed
        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtname.Text, "[0-9.*]"))
            {
                MessageBox.Show("يجب ادخال حروف فقط");
                txtname.Text = txtname.Text.Remove(txtname.Text.Length - 1);
            }     
        }

        //txtphone_changed
        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtphone.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtphone.Text = txtphone.Text.Remove(txtphone.Text.Length - 1);
            }
        }

        #region CLOSE
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
