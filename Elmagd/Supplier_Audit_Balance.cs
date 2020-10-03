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
    public partial class Supplier_Audit_Balance : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        public Supplier_Audit_Balance()
        {
            InitializeComponent();
        }

        private void Supplier_Audit_Balance_Load(object sender, EventArgs e)
        {
            Loadsuppliers();
        }
        #region LOAD_SUPPLIERS
        private void Loadsuppliers()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From SUPPLIERS", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر المورد---";
            dt.Rows.InsertAt(dr, 0);
            combosuppliers.ValueMember = "id";
            combosuppliers.DisplayMember = "name";
            combosuppliers.DataSource = dt;
        }
        #endregion

        private void btnShowDuringPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                if (combosuppliers.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختيار مورد");
                else
                {
                    conn.Open();
                    cmd.CommandText = @"select SUPPLIERS.name as 'إسم المورد',CATEGORY.name as 'الصنف' ,SUPPLIERS_INVOICE.quantity as 'الكميه',QUANTITY_TYPE.name as 'نوع الكمية',SUPPLIERS_INVOICE.price as 'السعر',SUPPLIERS_INVOICE.rest as 'الإجمالي ',SUPPLIERS_INVOICE.paid as 'المدفوع',SUPPLIERS_INVOICE.baky as 'الباقي',SUPPLIERS_INVOICE.date as 'التاريخ' from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id = SUPPLIERS.id inner join CATEGORY on SUPPLIERS_INVOICE.catid = CATEGORY.id inner join QUANTITY_TYPE on SUPPLIERS_INVOICE.quantitytype_id =QUANTITY_TYPE.id where SUPPLIERS_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "' and suppliers_id ='" + combosuppliers.SelectedValue + "'";
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

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (combosuppliers.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختيار مورد");
                else
                {
                    conn.Open();
                    cmd.CommandText = @"select SUPPLIERS.name as 'إسم المورد',CATEGORY.name as 'الصنف' ,SUPPLIERS_INVOICE.quantity as 'الكميه',QUANTITY_TYPE.name as 'نوع الكمية',SUPPLIERS_INVOICE.price as 'السعر',SUPPLIERS_INVOICE.rest as 'الإجمالي ',SUPPLIERS_INVOICE.paid as 'المدفوع',SUPPLIERS_INVOICE.baky as 'الباقي',SUPPLIERS_INVOICE.date as 'التاريخ' from SUPPLIERS_INVOICE inner join SUPPLIERS on SUPPLIERS_INVOICE.suppliers_id = SUPPLIERS.id inner join CATEGORY on SUPPLIERS_INVOICE.catid = CATEGORY.id inner join QUANTITY_TYPE on SUPPLIERS_INVOICE.quantitytype_id =QUANTITY_TYPE.id where suppliers_id ='" + combosuppliers.SelectedValue + "' ";
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

      //حساب الموردين
        private void btncalc_Click(object sender, EventArgs e)
        {
            if (combosuppliers.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار مورد");
            else
            {
                double total_supplierINO = 0;
                double total_paid = 0;
                double total_paid_payment = 0;

                conn.Open();
                cmd.CommandText = @"select sum(rest) from SUPPLIERS_INVOICE where suppliers_id ='" + combosuppliers.SelectedValue + "' ";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        total_supplierINO = 0;
                    else
                        total_supplierINO = double.Parse(reader[0].ToString());
                }
                conn.Close();
                txttotal.Text = total_supplierINO.ToString();
                //-----------------------------------------------
                //----------------------------------------------
                conn.Open();
                cmd.CommandText = @"select sum(paid) from SUPPLIERS_INVOICE where suppliers_id ='" + combosuppliers.SelectedValue + "' ";
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
                //----------------------------------
                conn.Open();
                cmd.CommandText = @"select sum(value) from PAYMENTS_SUPPLIERS where suppliers_id ='" + combosuppliers.SelectedValue + "' ";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        total_paid_payment = 0;
                    else
                        total_paid_payment = double.Parse(reader[0].ToString());
                }
                conn.Close();
                double total_all_paid = total_paid + total_paid_payment;
                txtpaid.Text = total_all_paid.ToString();
                //--------------------------------------------
                //--------------------------------------------
                txtbaky.Text = (total_supplierINO - total_all_paid).ToString();
            }
        }
        // حساب المورد خلال فترة
        private void btnhesab_Click(object sender, EventArgs e)
        {
            if (combosuppliers.SelectedIndex == 0)
                MessageBox.Show("برجاء اختيار مورد");
            else
            {
                double total_supplierINO = 0;
                double total_paid = 0;
                double total_paid_payment = 0;

                conn.Open();
                cmd.CommandText = @"select sum(rest) from SUPPLIERS_INVOICE  where SUPPLIERS_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "' and suppliers_id ='" + combosuppliers.SelectedValue + "' ";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        total_supplierINO = 0;
                    else
                        total_supplierINO = double.Parse(reader[0].ToString());
                }
                conn.Close();
                txttotal.Text = total_supplierINO.ToString();
                //-----------------------------------------------
                //----------------------------------------------
                conn.Open();
                cmd.CommandText = @"select sum(paid) from SUPPLIERS_INVOICE where SUPPLIERS_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "' and suppliers_id ='" + combosuppliers.SelectedValue + "' ";
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
                //----------------------------------
                conn.Open();
                cmd.CommandText = @"select sum(value) from PAYMENTS_SUPPLIERS where PAYMENTS_SUPPLIERS.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "' and suppliers_id ='" + combosuppliers.SelectedValue + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        total_paid_payment = 0;
                    else
                        total_paid_payment = double.Parse(reader[0].ToString());
                }
                conn.Close();
                double total_all_paid = total_paid + total_paid_payment;
                txtpaid.Text = total_all_paid.ToString();
                //--------------------------------------------
                //--------------------------------------------
                txtbaky.Text = (total_supplierINO - total_all_paid).ToString();
            }
        }

       

       
    }
}
