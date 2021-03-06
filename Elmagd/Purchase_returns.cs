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
    public partial class Purchase_returns : Form
    {
        int id, quntity_type, store_fromdb, cat_fromdb, quantitytype_fromdb;
        double enter_quantity, enterprice, totat, quantity_from_mainstore, total_quantity, quantity_fromdb, totalquantity_db, total_enter_quantity;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public Purchase_returns()
        {
            InitializeComponent();
        }

        private void Purchase_returns_Load(object sender, EventArgs e)
        {
            Loadquantity_type();
            Loadsuppliers();
            Loadstore();
            Loadcategory();
            BindGrid();
        }
        #region BINDGRID
        private void BindGrid()
        {
            try
            {
                conn.Open();
                cmd.CommandText = @"select PURCHASE_RETURNED.id as م,SUPPLIERS.name as المورد,CATEGORY.name as الصنف,STORE.name as المخزن,PURCHASE_RETURNED.quantity as الكمية,QUANTITY_TYPE.name as 'نوع الكمية' ,PURCHASE_RETURNED.price as السعر,PURCHASE_RETURNED.total as الإجمالي,PURCHASE_RETURNED.date as التاريخ from PURCHASE_RETURNED inner join SUPPLIERS on SUPPLIERS.id = PURCHASE_RETURNED.suppliers_id inner join CATEGORY on CATEGORY.id = PURCHASE_RETURNED.category_id inner join STORE on STORE.id = PURCHASE_RETURNED.store_id inner join QUANTITY_TYPE on QUANTITY_TYPE.id = PURCHASE_RETURNED.quantitytype_id";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                returnsgrid.DataSource = dt;
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

        private void btncalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtquantity.Text.Equals(""))
                    MessageBox.Show("برجاء إدخال الكمية");
                else if ((int)comboquantitytype.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختيار نوع الكمية");
                else if (txtprice.Text.Equals(""))
                    MessageBox.Show("برجاء ادخال السعر ");
                else
                {
                    enter_quantity = double.Parse(txtquantity.Text);
                    enterprice = double.Parse(txtprice.Text);
                    totat = enter_quantity * enterprice;
                    txttotal.Text = totat.ToString();

                }
            }
            catch (Exception ex) { }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)combosuppliers.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختيار مورد");
                else if ((int)combocategory.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختيار صنف");
                else if ((int)combostore.SelectedIndex == 0)
                    MessageBox.Show("برجاء اختيار مخزن");
                else if (txttotal.Text.Equals(""))
                    MessageBox.Show("برجاء الضغط علي زر اجمالي لحساب الاجمالي");
                else
                {
                    int qunttypfrom_main = 0;
                    quntity_type = (int)comboquantitytype.SelectedValue;
                    enter_quantity = double.Parse(txtquantity.Text);
                    // التشيك علي الكمية المراد ارجاعها
                    conn.Open();
                    cmd.CommandText = @" select quantity,quantitytype_id from MAIN_STORE where store_id ='" + (int)combostore.SelectedValue + "'and cat_id='" + (int)combocategory.SelectedValue + "'";//and quantitytype_id= 1 ";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("المخزن خالي");
                        conn.Close();
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == "")
                            {
                                quantity_from_mainstore = 0;
                            }
                            else
                            {
                                quantity_from_mainstore = double.Parse(reader[0].ToString());
                                qunttypfrom_main = int.Parse(reader[1].ToString());
                            }
                        }

                        conn.Close();
                        //-------------------------------------
                        if (quntity_type == qunttypfrom_main)
                            enter_quantity = enter_quantity;
                        else if (qunttypfrom_main == 1 && quntity_type == 2)
                        {
                            enter_quantity = enter_quantity * 1000;
                        }
                        else if (qunttypfrom_main == 2 && quntity_type == 1)
                        {
                            enter_quantity = enter_quantity / 1000;
                        }

                        if (enter_quantity > quantity_from_mainstore)
                        {
                            MessageBox.Show("الكمية الموجودة في المخزن غير كافية لهملية الارجاع البضاعة");
                        }
                        else
                        {

                            conn.Open();
                            cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity-'" + enter_quantity + "' where store_id = '" + (int)combostore.SelectedValue + "'and cat_id ='" + (int)combocategory.SelectedValue + "'";//and quantitytype_id = 1  ";
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            conn.Close();
                            //---------------------------------
                            //عملية الإضافة
                            conn.Close();
                            conn.Open();
                            cmd.CommandText = @"insert into PURCHASE_RETURNED (suppliers_id,category_id,quantity,quantitytype_id,price,total,store_id,date) values(@suppliers_id,@category_id,@quantity,@quantitytype_id,@price,@total,@store_id,@date)";
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@suppliers_id", (int)combosuppliers.SelectedValue);
                            cmd.Parameters.AddWithValue("@category_id", (int)combocategory.SelectedValue);
                            cmd.Parameters.AddWithValue("@quantity", txtquantity.Text);
                            cmd.Parameters.AddWithValue("@quantitytype_id", (int)comboquantitytype.SelectedValue);
                            cmd.Parameters.AddWithValue("@price", txtprice.Text);
                            cmd.Parameters.AddWithValue("@total", txttotal.Text);
                            cmd.Parameters.AddWithValue("@store_id", (int)combostore.SelectedValue);
                            cmd.Parameters.AddWithValue("@date", suppliersinvoicedate.Value.Date.ToShortDateString());
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            conn.Close();
                            BindGrid();
                            txtprice.Text = "";
                            txtquantity.Text = "";
                            txttotal.Text = "";
                            combocategory.SelectedIndex = 0;
                            combostore.SelectedIndex = 0;
                            comboquantitytype.SelectedIndex = 0;
                            combosuppliers.SelectedIndex = 0;
                            //----------------------------------------------
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void returnsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (returnsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "")
                    MessageBox.Show("يجب الضغط على صف يحتوى على بيانات بالفعل");
                else
                {
                    returnsgrid.CurrentRow.Selected = true;
                    id = int.Parse(returnsgrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                }
            }
            catch (Exception ex) { }
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    MessageBox.Show("يجب الضغط عل صف يحتوي علي بيانات");
                else
                {
                    conn.Open();
                    cmd.CommandText = @" select store_id,category_id,quantity,quantitytype_id from PURCHASE_RETURNED where id='" + id + "' ";
                    SqlDataReader reader_temp = cmd.ExecuteReader();
                    while (reader_temp.Read())
                    {
                        store_fromdb = int.Parse(reader_temp[0].ToString());
                        cat_fromdb = int.Parse(reader_temp[1].ToString());
                        quantity_fromdb = double.Parse(reader_temp[2].ToString());
                        quantitytype_fromdb = int.Parse(reader_temp[3].ToString());

                    }
                    conn.Close();
                    //--------------------------
                    double quantityfrommain = 0;
                    int quantitytypefrommainstore = 0;
                    conn.Open();
                    cmd.CommandText = @"  select quantity,quantitytype_id from MAIN_STORE where store_id ='" + store_fromdb + "'and cat_id='" + cat_fromdb + "'";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        quantityfrommain = double.Parse(reader[0].ToString());
                        quantitytypefrommainstore = int.Parse(reader[1].ToString());

                    }
                    conn.Close();
                    //---------------------------------
                    //update mainstore
                    if (quntity_type == quantitytypefrommainstore)
                        quantity_fromdb = quantity_fromdb;
                    else if (quantitytypefrommainstore == 1 && quntity_type == 2)
                    {
                        quantity_fromdb = quantity_fromdb * 1000;
                    }
                    else if (quantitytypefrommainstore == 2 && quntity_type == 1)
                    {
                        quantity_fromdb = quantity_fromdb / 1000;
                    }
                    conn.Open();
                    cmd.CommandText = @"UPDATE MAIN_STORE  SET quantity = quantity+'" + quantity_fromdb + "' where store_id = '" + store_fromdb + "'and cat_id ='" + cat_fromdb + "'";//and quantitytype_id =1  ";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    conn.Close();
                    foreach (DataGridViewRow row in returnsgrid.SelectedRows)
                    {

                        returnsgrid.Rows.RemoveAt(row.Index);
                        conn.Open();
                        cmd.CommandText = @"delete from PURCHASE_RETURNED where id = '" + id + "'";
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        BindGrid();
                        MessageBox.Show("تم الحذف");
                        id = 0;
                        btnadd.Enabled = true;
                    }
                }
            }
            catch (Exception ex) { }
        }


    }
}
