namespace Elmagd
{
    partial class Payments_Suppliers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sup_paymentsgrid = new System.Windows.Forms.DataGridView();
            this.txtnotes = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalue = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combosuppliers = new System.Windows.Forms.ComboBox();
            this.suppaymentdate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelet = new Telerik.WinControls.UI.RadButton();
            this.btnedite = new Telerik.WinControls.UI.RadButton();
            this.btnadd = new Telerik.WinControls.UI.RadButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sup_paymentsgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppaymentdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            this.SuspendLayout();
            // 
            // sup_paymentsgrid
            // 
            this.sup_paymentsgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sup_paymentsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sup_paymentsgrid.Location = new System.Drawing.Point(12, 310);
            this.sup_paymentsgrid.Name = "sup_paymentsgrid";
            this.sup_paymentsgrid.ReadOnly = true;
            this.sup_paymentsgrid.RowTemplate.Height = 24;
            this.sup_paymentsgrid.Size = new System.Drawing.Size(2020, 660);
            this.sup_paymentsgrid.TabIndex = 31;
            this.sup_paymentsgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sup_paymentsgrid_CellClick);
            // 
            // txtnotes
            // 
            this.txtnotes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnotes.AutoSize = false;
            this.txtnotes.Location = new System.Drawing.Point(74, 36);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnotes.Size = new System.Drawing.Size(303, 94);
            this.txtnotes.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "ملاحضات";
            // 
            // txtvalue
            // 
            this.txtvalue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtvalue.Location = new System.Drawing.Point(518, 36);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(303, 24);
            this.txtvalue.TabIndex = 44;
            this.txtvalue.TextChanged += new System.EventHandler(this.txtvalue_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(856, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "المبلغ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1274, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "إسم المورد";
            // 
            // combosuppliers
            // 
            this.combosuppliers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combosuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combosuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combosuppliers.FormattingEnabled = true;
            this.combosuppliers.Location = new System.Drawing.Point(935, 37);
            this.combosuppliers.Name = "combosuppliers";
            this.combosuppliers.Size = new System.Drawing.Size(303, 24);
            this.combosuppliers.TabIndex = 43;
            // 
            // suppaymentdate
            // 
            this.suppaymentdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.suppaymentdate.CustomFormat = "dd-MM-yyyy";
            this.suppaymentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.suppaymentdate.Location = new System.Drawing.Point(1406, 36);
            this.suppaymentdate.Name = "suppaymentdate";
            this.suppaymentdate.Size = new System.Drawing.Size(286, 24);
            this.suppaymentdate.TabIndex = 46;
            this.suppaymentdate.TabStop = false;
            this.suppaymentdate.Text = "23-06-2020";
            this.suppaymentdate.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1731, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "التاريخ";
            // 
            // btndelet
            // 
            this.btndelet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndelet.Location = new System.Drawing.Point(610, 136);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(139, 42);
            this.btndelet.TabIndex = 50;
            this.btndelet.Text = "حذف";
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // btnedite
            // 
            this.btnedite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnedite.Location = new System.Drawing.Point(935, 136);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(144, 42);
            this.btnedite.TabIndex = 49;
            this.btnedite.Text = "تعديل";
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd.Location = new System.Drawing.Point(1286, 136);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(139, 42);
            this.btnadd.TabIndex = 48;
            this.btnadd.Text = "إضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1114, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "بحث";
            // 
            // txtSarch
            // 
            this.txtSarch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSarch.Location = new System.Drawing.Point(621, 262);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(431, 24);
            this.txtSarch.TabIndex = 51;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // Payments_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 764);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnedite);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suppaymentdate);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combosuppliers);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sup_paymentsgrid);
            this.Name = "Payments_Suppliers";
            this.Text = "المدفوعات لمورد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payments_Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sup_paymentsgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppaymentdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sup_paymentsgrid;
        private Telerik.WinControls.UI.RadTextBox txtnotes;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox txtvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combosuppliers;
        private Telerik.WinControls.UI.RadDateTimePicker suppaymentdate;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btndelet;
        private Telerik.WinControls.UI.RadButton btnedite;
        private Telerik.WinControls.UI.RadButton btnadd;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
    }
}