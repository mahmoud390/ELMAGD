using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elmagd
{
    public partial class Homeform : Form
    {
        public Homeform()
        {
            InitializeComponent();
        }

       

        private void radRibbonBarGroup1_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();
        }

        private void radRibbonBarGroup2_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
        }

        private void radRibbonBarGroup3_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
        }

        private void radRibbonBarGroup4_Click(object sender, EventArgs e)
        {
            Investors investors = new Investors();
            investors.Show();
        }

        private void radRibbonBarGroup5_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Show();
        }

        private void ribbonTab1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ribbonTab6_Click(object sender, EventArgs e)
        {
            SignUP signup = new SignUP();
            signup.Show();
        }

        private void radRibbonBarGroup6_Click(object sender, EventArgs e)
        {
            SuppliersInvoice suppliersinvoice = new SuppliersInvoice();
            suppliersinvoice.Show();
        }

        private void radRibbonBarGroup7_Click(object sender, EventArgs e)
        {
            Payments_Suppliers payments_suppliers = new Payments_Suppliers();
            payments_suppliers.Show();
        }

        private void radRibbonBarGroup8_Click(object sender, EventArgs e)
        {
            Receipt_Suppliers receipt_suppliers = new Receipt_Suppliers();
            receipt_suppliers.Show();
        }

        private void radRibbonBarGroup9_Click(object sender, EventArgs e)
        {
            ClientInvoice clientinvoice = new ClientInvoice();
            clientinvoice.Show();
        }

        private void radRibbonBarGroup10_Click(object sender, EventArgs e)
        {
            Receipts_Client receipts_client = new Receipts_Client();
            receipts_client.Show();

        }

        private void radRibbonBarGroup11_Click(object sender, EventArgs e)
        {
            Payments_Client payments_client = new Payments_Client();
            payments_client.Show();
        }

        private void ribbonTab7_Click(object sender, EventArgs e)
        {
            
        }

        private void radRibbonBarGroup12_Click(object sender, EventArgs e)
        {
            General_Receipts general_receipts = new General_Receipts();
            general_receipts.Show();
        }

        private void radRibbonBarGroup13_Click(object sender, EventArgs e)
        {
            General_payments general_payments = new General_payments();
            general_payments.Show();

        }

        private void radRibbonBarGroup14_Click(object sender, EventArgs e)
        {
            Show_stores show_stores = new Show_stores();
            show_stores.Show();
        }

        private void radRibbonBarGroup15_Click(object sender, EventArgs e)
        {
            Internal_Exchange internal_exchange = new Internal_Exchange();
            internal_exchange.Show();
        }

        private void radRibbonBarGroup16_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void radRibbonBarGroup17_Click(object sender, EventArgs e)
        {
            Incomes incomes = new Incomes();
            incomes.Show();
        }

       
    }
}
