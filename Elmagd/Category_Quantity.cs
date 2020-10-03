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
    public partial class Category_Quantity : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Category_Quantity()
        {
            InitializeComponent();
        }

        private void Category_Quantity_Load(object sender, EventArgs e)
        {
            Loadcategory();
        }
        #region LOADCATRGORY
        private void Loadcategory()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From CATEGORY", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر الصنف---";
            dt.Rows.InsertAt(dr, 0);
            combocategory.ValueMember = "id";
            combocategory.DisplayMember = "name";
            combocategory.DataSource = dt;
        }
        #endregion

        private void btngard_Click(object sender, EventArgs e)
        {
            double quantity = 0; ;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select sum(quantity) from MAIN_STORE where  cat_id ='" + (int)combocategory.SelectedValue + "' ", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "")
                    quantity = 0.0;
                else
                    quantity = double.Parse(reader[0].ToString());
               
            }
            conn.Close();
            if (quantity == 0.0)
            {
                MessageBox.Show("المخزن خالي من هذا الصنف تبعا لنوع الكمية");
                txtquantity.Text = "0";
            }
            else
                txtquantity.Text = quantity.ToString();
        }
    }
}
