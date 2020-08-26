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
    public partial class Main_Information : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Main_Information()
        {
            InitializeComponent();
        }
        #region BINDGRID
        private void BindGrid()
        {
            conn.Open();
            cmd.CommandText = @"select MAIN_INFORMATION.id as المسلسل,MAIN_INFORMATION.date_start as تاريخ_البدء,MAIN_INFORMATION.date_end as تاريخ_الإنتهاء,MAIN_INFORMATION.notes as الملاحظات from MAIN_INFORMATION ";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MainInformationgrid.DataSource = dt;
            conn.Close();
        }
        #endregion

        private void Main_Information_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            conn.Open();
            cmd.CommandText = @"insert into MAIN_INFORMATION (date_start,date_end,notes) values(@date_start,@date_end,@notes)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@date_start", dateStart.Value.Date.ToShortDateString());
            cmd.Parameters.AddWithValue("@date_end", dateEnd.Value.Date.ToShortDateString());
            cmd.Parameters.AddWithValue("@notes", txtnotes.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.Close();
            BindGrid();
            txtnotes.Text = "";
            MessageBox.Show("تمت عمليه الحفظ");
        }
    }
}
