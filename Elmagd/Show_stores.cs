﻿using System;
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
    public partial class Show_stores : Form
    {
        double quantity = 0, storequantity, quantity_kilo, totalquantity;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public Show_stores()
        {
            InitializeComponent();
        }

        #region LOAD_page
        private void Show_stores_Load(object sender, EventArgs e)
        {
            Loadcategory();
            Loadquantity_type();
            Loadstore();
            BindGrid();
        }
        #endregion

        #region BINDGRID
        private void BindGrid()
        {
            try
            {
                conn.Open();
                cmd.CommandText = @"select MAIN_STORE.id as م,STORE.name as المخزن, CATEGORY.name as الصنف,MAIN_STORE.quantity as الكمية,QUANTITY_TYPE.name as 'نوع الكمية' from MAIN_STORE inner join STORE on MAIN_STORE.store_id =STORE.id inner join CATEGORY on MAIN_STORE.cat_id =CATEGORY.id inner join QUANTITY_TYPE on MAIN_STORE.quantitytype_id =QUANTITY_TYPE.id";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                showstoregrid.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }
        #endregion

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

        #region  QUANTITY_TYPE
        private void Loadquantity_type()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From QUANTITY_TYPE", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر نوع الكمية---";
            dt.Rows.InsertAt(dr, 0);
            comboquantitytype.ValueMember = "id";
            comboquantitytype.DisplayMember = "name";
            comboquantitytype.DataSource = dt;
        }
        #endregion

        #region LOAD STORE
        private void Loadstore()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From STORE", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["name"] = "---اختر المخزن---";
            dt.Rows.InsertAt(dr, 0);
            combostore.ValueMember = "id";
            combostore.DisplayMember = "name";
            combostore.DataSource = dt;
        }
        #endregion

        #region GARD_MAINSTORE
        private void btngard_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)combostore.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختيار مخزن");
                else if ((int)combocategory.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختيار صنف");

                else
                {
                    quantity = 0;
                    var qtyType = 0;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select sum(quantity),quantitytype_id from MAIN_STORE where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "' group by quantity,quantitytype_id", conn);//and quantitytype_id = '" + (int)comboquantitytype.SelectedValue + "' "
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == "")
                            quantity = 0.0;
                        else
                            quantity += double.Parse(reader[0].ToString());
                        qtyType = int.Parse(reader[1].ToString());
                    }
                    conn.Close();
                    if (quantity == 0.0)
                    {
                        MessageBox.Show("المخزن خالي من هذا الصنف تبعا لنوع الكمية");
                        txtquantity.Text = "0";
                    }
                    else
                    {
                        if ((int)comboquantitytype.SelectedValue == 1)
                        {
                            if (qtyType == 1)
                                txtquantity.Text = quantity.ToString();
                            else if (qtyType == 2)
                            {
                                storequantity = quantity * 1000;
                                txtquantity.Text = storequantity.ToString();
                            }
                        }
                        else if ((int)comboquantitytype.SelectedValue == 2)
                        {
                            if (qtyType == 2)
                                txtquantity.Text = quantity.ToString();
                            else if (qtyType == 1)
                            {
                                storequantity = quantity / 1000;
                                txtquantity.Text = storequantity.ToString();
                            }

                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
        #endregion
    }
}