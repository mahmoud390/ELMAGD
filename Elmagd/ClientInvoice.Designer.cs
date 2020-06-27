namespace Elmagd
{
    partial class ClientInvoice
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
            this.btnadd = new Telerik.WinControls.UI.RadButton();
            this.label12 = new System.Windows.Forms.Label();
            this.comboquantitytype = new System.Windows.Forms.ComboBox();
            this.tempclientgrid = new System.Windows.Forms.DataGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbaky = new Telerik.WinControls.UI.RadTextBox();
            this.btnbaky = new Telerik.WinControls.UI.RadButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpaid = new Telerik.WinControls.UI.RadTextBox();
            this.btndelet = new Telerik.WinControls.UI.RadButton();
            this.btnadd1 = new Telerik.WinControls.UI.RadButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtrest = new Telerik.WinControls.UI.RadTextBox();
            this.btncalc2 = new Telerik.WinControls.UI.RadButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcommestion = new Telerik.WinControls.UI.RadTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmashal = new Telerik.WinControls.UI.RadTextBox();
            this.txtbskoul = new Telerik.WinControls.UI.RadTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotal = new Telerik.WinControls.UI.RadTextBox();
            this.btncalc = new Telerik.WinControls.UI.RadButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprice = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantity = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combostore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboclient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientinvoicedate = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempclientgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbaky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncalc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcommestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmashal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbskoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinvoicedate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd.Location = new System.Drawing.Point(24, 267);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(137, 48);
            this.btnadd.TabIndex = 82;
            this.btnadd.Text = "طباعة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1237, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 86;
            this.label12.Text = "نوع الكمية";
            // 
            // comboquantitytype
            // 
            this.comboquantitytype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboquantitytype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboquantitytype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboquantitytype.FormattingEnabled = true;
            this.comboquantitytype.Location = new System.Drawing.Point(1029, 123);
            this.comboquantitytype.Name = "comboquantitytype";
            this.comboquantitytype.Size = new System.Drawing.Size(172, 24);
            this.comboquantitytype.TabIndex = 85;
            // 
            // tempclientgrid
            // 
            this.tempclientgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tempclientgrid.Location = new System.Drawing.Point(12, 417);
            this.tempclientgrid.Name = "tempclientgrid";
            this.tempclientgrid.RowTemplate.Height = 24;
            this.tempclientgrid.Size = new System.Drawing.Size(2020, 570);
            this.tempclientgrid.TabIndex = 84;
            this.tempclientgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tempclientgrid_CellClick);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.label14);
            this.radGroupBox1.Controls.Add(this.txtbaky);
            this.radGroupBox1.Controls.Add(this.btnbaky);
            this.radGroupBox1.Controls.Add(this.label13);
            this.radGroupBox1.Controls.Add(this.txtpaid);
            this.radGroupBox1.Controls.Add(this.btndelet);
            this.radGroupBox1.Controls.Add(this.btnadd1);
            this.radGroupBox1.Controls.Add(this.label11);
            this.radGroupBox1.Controls.Add(this.txtrest);
            this.radGroupBox1.Controls.Add(this.btncalc2);
            this.radGroupBox1.Controls.Add(this.label10);
            this.radGroupBox1.Controls.Add(this.txtcommestion);
            this.radGroupBox1.Controls.Add(this.label9);
            this.radGroupBox1.Controls.Add(this.label8);
            this.radGroupBox1.Controls.Add(this.txtmashal);
            this.radGroupBox1.Controls.Add(this.txtbskoul);
            this.radGroupBox1.HeaderText = "الخصم والإضافة";
            this.radGroupBox1.Location = new System.Drawing.Point(205, 197);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1469, 200);
            this.radGroupBox1.TabIndex = 83;
            this.radGroupBox1.Text = "الخصم والإضافة";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(746, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 19);
            this.label14.TabIndex = 80;
            this.label14.Text = "الباقي";
            // 
            // txtbaky
            // 
            this.txtbaky.Location = new System.Drawing.Point(555, 123);
            this.txtbaky.Name = "txtbaky";
            this.txtbaky.ReadOnly = true;
            this.txtbaky.Size = new System.Drawing.Size(153, 24);
            this.txtbaky.TabIndex = 79;
            // 
            // btnbaky
            // 
            this.btnbaky.Location = new System.Drawing.Point(829, 122);
            this.btnbaky.Name = "btnbaky";
            this.btnbaky.Size = new System.Drawing.Size(184, 30);
            this.btnbaky.TabIndex = 76;
            this.btnbaky.Text = "حساب البافي";
            this.btnbaky.Click += new System.EventHandler(this.btnbaky_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1258, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 19);
            this.label13.TabIndex = 78;
            this.label13.Text = "المدفوع";
            // 
            // txtpaid
            // 
            this.txtpaid.Location = new System.Drawing.Point(1067, 128);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(153, 24);
            this.txtpaid.TabIndex = 77;
            this.txtpaid.TextChanged += new System.EventHandler(this.txtpaid_TextChanged);
            // 
            // btndelet
            // 
            this.btndelet.Location = new System.Drawing.Point(49, 155);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(137, 30);
            this.btndelet.TabIndex = 63;
            this.btndelet.Text = "حذف";
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // btnadd1
            // 
            this.btnadd1.Location = new System.Drawing.Point(229, 155);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(137, 30);
            this.btnadd1.TabIndex = 62;
            this.btnadd1.Text = "إضافة";
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 19);
            this.label11.TabIndex = 71;
            this.label11.Text = "الإجمالي بعد الخصومات";
            // 
            // txtrest
            // 
            this.txtrest.Location = new System.Drawing.Point(5, 38);
            this.txtrest.Name = "txtrest";
            this.txtrest.ReadOnly = true;
            this.txtrest.Size = new System.Drawing.Size(153, 24);
            this.txtrest.TabIndex = 70;
            // 
            // btncalc2
            // 
            this.btncalc2.Location = new System.Drawing.Point(351, 34);
            this.btncalc2.Name = "btncalc2";
            this.btncalc2.Size = new System.Drawing.Size(160, 30);
            this.btncalc2.TabIndex = 61;
            this.btncalc2.Text = "حساب الإجمالي بعد الخصومات";
            this.btncalc2.Click += new System.EventHandler(this.btncalc2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(798, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 69;
            this.label10.Text = "عمولات";
            // 
            // txtcommestion
            // 
            this.txtcommestion.Location = new System.Drawing.Point(564, 35);
            this.txtcommestion.Name = "txtcommestion";
            this.txtcommestion.Size = new System.Drawing.Size(197, 24);
            this.txtcommestion.TabIndex = 68;
            this.txtcommestion.TextChanged += new System.EventHandler(this.txtcommestion_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1139, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 67;
            this.label9.Text = "مشال";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1368, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 65;
            this.label8.Text = "كارتت بسكول";
            // 
            // txtmashal
            // 
            this.txtmashal.Location = new System.Drawing.Point(890, 36);
            this.txtmashal.Name = "txtmashal";
            this.txtmashal.Size = new System.Drawing.Size(211, 24);
            this.txtmashal.TabIndex = 66;
            this.txtmashal.TextChanged += new System.EventHandler(this.txtmashal_TextChanged);
            // 
            // txtbskoul
            // 
            this.txtbskoul.Location = new System.Drawing.Point(1196, 37);
            this.txtbskoul.Name = "txtbskoul";
            this.txtbskoul.Size = new System.Drawing.Size(150, 24);
            this.txtbskoul.TabIndex = 64;
            this.txtbskoul.TextChanged += new System.EventHandler(this.txtbskoul_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "الإجمالبي";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttotal.Location = new System.Drawing.Point(30, 123);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(239, 24);
            this.txttotal.TabIndex = 80;
            // 
            // btncalc
            // 
            this.btncalc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncalc.Location = new System.Drawing.Point(425, 127);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(137, 30);
            this.btncalc.TabIndex = 79;
            this.btncalc.Text = "حساب الإجمالي";
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(932, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "السعر";
            // 
            // txtprice
            // 
            this.txtprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprice.Location = new System.Drawing.Point(634, 122);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(239, 24);
            this.txtprice.TabIndex = 77;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1672, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "الكميه";
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtquantity.Location = new System.Drawing.Point(1374, 119);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(239, 24);
            this.txtquantity.TabIndex = 75;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "المخزن";
            // 
            // combostore
            // 
            this.combostore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combostore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combostore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combostore.FormattingEnabled = true;
            this.combostore.Location = new System.Drawing.Point(24, 37);
            this.combostore.Name = "combostore";
            this.combostore.Size = new System.Drawing.Size(251, 24);
            this.combostore.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "الصنف";
            // 
            // combocategory
            // 
            this.combocategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combocategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combocategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Location = new System.Drawing.Point(425, 37);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(241, 24);
            this.combocategory.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1212, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "العميل";
            // 
            // comboclient
            // 
            this.comboclient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboclient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboclient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboclient.FormattingEnabled = true;
            this.comboclient.Location = new System.Drawing.Point(826, 34);
            this.comboclient.Name = "comboclient";
            this.comboclient.Size = new System.Drawing.Size(303, 24);
            this.comboclient.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1685, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "التاريخ";
            // 
            // clientinvoicedate
            // 
            this.clientinvoicedate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientinvoicedate.CustomFormat = "dd-MM-yyyy";
            this.clientinvoicedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.clientinvoicedate.Location = new System.Drawing.Point(1360, 36);
            this.clientinvoicedate.Name = "clientinvoicedate";
            this.clientinvoicedate.Size = new System.Drawing.Size(286, 24);
            this.clientinvoicedate.TabIndex = 67;
            this.clientinvoicedate.TabStop = false;
            this.clientinvoicedate.Text = "23-06-2020";
            this.clientinvoicedate.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // ClientInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1790, 770);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboquantitytype);
            this.Controls.Add(this.tempclientgrid);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combostore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combocategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboclient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientinvoicedate);
            this.Name = "ClientInvoice";
            this.Text = "فاتورة مبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClientInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempclientgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbaky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncalc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcommestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmashal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbskoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinvoicedate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnadd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboquantitytype;
        private System.Windows.Forms.DataGridView tempclientgrid;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btndelet;
        private Telerik.WinControls.UI.RadButton btnadd1;
        private System.Windows.Forms.Label label11;
        private Telerik.WinControls.UI.RadTextBox txtrest;
        private Telerik.WinControls.UI.RadButton btncalc2;
        private System.Windows.Forms.Label label10;
        private Telerik.WinControls.UI.RadTextBox txtcommestion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Telerik.WinControls.UI.RadTextBox txtmashal;
        private Telerik.WinControls.UI.RadTextBox txtbskoul;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadTextBox txttotal;
        private Telerik.WinControls.UI.RadButton btncalc;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadTextBox txtprice;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combostore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboclient;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker clientinvoicedate;
        private System.Windows.Forms.Label label14;
        private Telerik.WinControls.UI.RadTextBox txtbaky;
        private Telerik.WinControls.UI.RadButton btnbaky;
        private System.Windows.Forms.Label label13;
        private Telerik.WinControls.UI.RadTextBox txtpaid;
    }
}