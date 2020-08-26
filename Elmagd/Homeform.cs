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

        private void ribbonTab8_Click(object sender, EventArgs e)
        {
            Cachier Cachier = new Cachier();
            Cachier.Show();
        }

        private void radRibbonBarGroup18_Click(object sender, EventArgs e)
        {
            //Main_Information main_information = new Main_Information();
            //main_information.Show();
        }

        private void radRibbonBarGroup19_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.Show();
        }

        private void radRibbonBarGroup20_Click(object sender, EventArgs e)
        {
            Full_Production full_production = new Full_Production();
            full_production.Show();
        }

        private void radRibbonBarGroup21_Click(object sender, EventArgs e)
        {
            General_Payment_Items generl_payment_items = new General_Payment_Items();
            generl_payment_items.Show();
        }

        private void radRibbonBarGroup18_Click_1(object sender, EventArgs e)
        {
            General_Recepits_Items general_recepits_items = new General_Recepits_Items();
            general_recepits_items.Show();
        }

        private void radRibbonBarGroup22_Click(object sender, EventArgs e)
        {
            Supplier_Audit_Balance suppliers_audit_balance = new Supplier_Audit_Balance();
            suppliers_audit_balance.Show();
        }

        private void radRibbonBarGroup23_Click(object sender, EventArgs e)
        {
            Client_Audit_balance client_audit_balance = new Client_Audit_balance();
            client_audit_balance.Show();
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void radRibbonBarGroup24_Click(object sender, EventArgs e)
        {
            Purchase_returns purchase_returns = new Purchase_returns();
            purchase_returns.Show();
        }

        private void radRibbonBarGroup25_Click(object sender, EventArgs e)
        {
            Sales_Returns sales_returns = new Sales_Returns();
            sales_returns.Show();
        }

        private void ribbonTab11_Click(object sender, EventArgs e)
        {
            Profit_and_loss profit_and_loss = new Profit_and_loss();
            profit_and_loss.Show();
        }

        private void ribbonTab12_Click(object sender, EventArgs e)
        {
            show_Profit_And_Loss show_profit_and_loss = new show_Profit_And_Loss();
            show_profit_and_loss.Show();
        }

       
    }
}
