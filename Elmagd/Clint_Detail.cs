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
    public partial class Clint_Detail : Form
    {
        string dateFromDummy = "", dateToDummy = "";
        int firstLoad = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ELMAGD;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();

        public Clint_Detail()
        {
            InitializeComponent();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            firstLoad = 1;
            dateFromDummy = dateFrom.Value.Date.ToShortDateString();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            firstLoad = 1;
            dateToDummy = dateTo.Value.Date.ToShortDateString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (dateFromDummy == dateToDummy)
                    cmd.CommandText = @"select sum(paid) from CLIENT_INVOICE";
                else
                    cmd.CommandText = @"select sum(paid) from CLIENT_INVOICE where CLIENT_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "")
                        txtValue.Text = "0";
                    else
                        txtValue.Text = reader[0].ToString();
                }
                conn.Close();
            }
            catch (Exception ex) { }
        }

        private void btnShowDuringPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (dateFromDummy == dateToDummy)
                    cmd.CommandText = @"select CLIENT_INVOICE.paid as ' المدفوع من عميل',CLIENT_INVOICE.baky as ' الباقي من فواتير العملاء',CLIENT_INVOICE.date  as التاريخ,CLIENT.name as  العميل  from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id ";
                    
                else
                    cmd.CommandText = @"select CLIENT_INVOICE.paid as ' المدفوع من عميل',CLIENT_INVOICE.baky as ' الباقي من فواتير العملاء',CLIENT_INVOICE.date as التاريخ,CLIENT.name as  العميل from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id  where CLIENT_INVOICE.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridClient.DataSource = dt;
                conn.Close();
                //-------------------------------
                conn.Open();
                if (dateFromDummy == dateToDummy)
                    cmd.CommandText = @"select RESEIPTS_CLIENT.value as 'المدفوع من عميل',RESEIPTS_CLIENT.date as التاريخ,CLIENT.name as العميل  from RESEIPTS_CLIENT inner join CLIENT on RESEIPTS_CLIENT.client_id=CLIENT.id ";
                else
                    cmd.CommandText = @"select RESEIPTS_CLIENT.value as 'المدفوع من عميل',RESEIPTS_CLIENT.date as التاريخ,CLIENT.name as العميل  from RESEIPTS_CLIENT inner join CLIENT on RESEIPTS_CLIENT.client_id=CLIENT.id  where RESEIPTS_CLIENT.date between '" + dateFrom.Value.Date.ToShortDateString() + "'" + " and '" + dateTo.Value.Date.ToShortDateString() + "'";
                cmd.Connection = conn;
                SqlDataAdapter da_paymint_sup = new SqlDataAdapter(cmd);
                DataTable dt_payment_sup = new DataTable();
                da_paymint_sup.Fill(dt_payment_sup);
                gridsupplierspayments.DataSource = dt_payment_sup;
                conn.Close();
            }
            catch (Exception ex) { }
        }

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter("select CLIENT_INVOICE.paid المدفوع_من_العميل,CLIENT_INVOICE.date التاريخ,CLIENT.name اسم_العميل  from CLIENT_INVOICE inner join CLIENT on CLIENT_INVOICE.client_id=CLIENT.id  where CLIENT.name LIKE N'%" + txtSarch.Text + "%'", conn);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                gridClient.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }
        }
    }
}
