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

    public partial class Admin : Form
    {
        int id;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select id as 'م',name as الإسم, phone as الهاتف ,username as 'إسم المستخدم' ,password as 'كلمة المرور' from ADMIN";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admingrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void admingrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnadd.Enabled = false;
            try
            {
                if (admingrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    admingrid.CurrentRow.Selected = true;
                    id = int.Parse(admingrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    txtname.Text = admingrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtphone.Text = admingrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtusername.Text = admingrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtpassword.Text = admingrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void btnedite_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update ADMIN set name=@name,phone=@phone,username=@username,password =@password where id = '" + id + "'", conn);
                cmd.Parameters.AddWithValue("@name", txtname.Text.ToString());
                cmd.Parameters.AddWithValue("@phone", txtphone.Text.ToString());
                cmd.Parameters.AddWithValue("@username", txtusername.Text.ToString());
                cmd.Parameters.AddWithValue("@password", txtpassword.Text.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                BindGrid();
                txtname.Text = "";
                txtphone.Text = "";
                txtusername.Text = "";
                txtpassword.Text = "";
                MessageBox.Show("تم التعديل");
                id = 0;
                btnadd.Enabled = true;
            }
        }

        #region DELET_ADMIN
        private void btndelet_Click(object sender, EventArgs e)
        {
            if (id == 0)
                MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
            else
            {
                foreach (DataGridViewRow row in admingrid.SelectedRows)
                {
                    admingrid.Rows.RemoveAt(row.Index);
                    conn.Open();
                    cmd.CommandText = @"delete from ADMIN where id = '" + id + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    BindGrid();
                    txtname.Text = "";
                    txtphone.Text = "";
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    MessageBox.Show("تم الحذف");
                    id = 0;
                    btnadd.Enabled = true;
                }
            }

        }
        #endregion

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dataadapter = new SqlDataAdapter("select id,name as الإسم, phone as الهاتف ,username as إسم_المستخدم ,password as كلمة_المرور from ADMIN where name LIKE N'%" + txtSarch.Text + "%'", conn);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            admingrid.DataSource = dt;
            conn.Close();
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtphone.Text, "[^0-9]"))
            {
                MessageBox.Show("يجب إدخال أرقام فقط");
                txtphone.Text = txtphone.Text.Remove(txtphone.Text.Length - 1);
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtname.Text, "[0-9.*]"))
            {
                MessageBox.Show("يجب ادخال حروف فقط");
                txtname.Text = txtname.Text.Remove(txtname.Text.Length - 1);
            }    
        }

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
            else
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
                    BindGrid();
                    txtname.Text = "";
                    txtphone.Text = "";
                    txtpassword.Text = "";
                    txtusername.Text = "";
                    MessageBox.Show("تمت عملية الاضافة بنجاح");
                }
            }
        }

    }
}
