namespace Elmagd
{
    partial class Payments_Client
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            this.btndelet = new Telerik.WinControls.UI.RadButton();
            this.btnedite = new Telerik.WinControls.UI.RadButton();
            this.btnadd = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cllientpaymentdate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtvalue = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboclient = new System.Windows.Forms.ComboBox();
            this.txtnotes = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.client_paymentsgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cllientpaymentdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_paymentsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1143, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "بحث";
            // 
            // txtSarch
            // 
            this.txtSarch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSarch.Location = new System.Drawing.Point(794, 258);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(326, 24);
            this.txtSarch.TabIndex = 65;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // btndelet
            // 
            this.btndelet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndelet.Location = new System.Drawing.Point(686, 150);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(123, 30);
            this.btndelet.TabIndex = 64;
            this.btndelet.Text = "حذف";
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // btnedite
            // 
            this.btnedite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnedite.Location = new System.Drawing.Point(959, 150);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(129, 30);
            this.btnedite.TabIndex = 63;
            this.btnedite.Text = "تعديل";
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd.Location = new System.Drawing.Point(1262, 150);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(126, 30);
            this.btnadd.TabIndex = 62;
            this.btnadd.Text = "إضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1706, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "التاريخ";
            // 
            // cllientpaymentdate
            // 
            this.cllientpaymentdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cllientpaymentdate.CustomFormat = "dd-MM-yyyy";
            this.cllientpaymentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cllientpaymentdate.Location = new System.Drawing.Point(1381, 34);
            this.cllientpaymentdate.Name = "cllientpaymentdate";
            this.cllientpaymentdate.Size = new System.Drawing.Size(286, 24);
            this.cllientpaymentdate.TabIndex = 60;
            this.cllientpaymentdate.TabStop = false;
            this.cllientpaymentdate.Text = "23-06-2020";
            this.cllientpaymentdate.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // txtvalue
            // 
            this.txtvalue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtvalue.Location = new System.Drawing.Point(440, 34);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(303, 24);
            this.txtvalue.TabIndex = 58;
            this.txtvalue.TextChanged += new System.EventHandler(this.txtvalue_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "المبلغ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1193, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "إسم العميل";
            // 
            // comboclient
            // 
            this.comboclient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboclient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboclient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboclient.FormattingEnabled = true;
            this.comboclient.Location = new System.Drawing.Point(854, 35);
            this.comboclient.Name = "comboclient";
            this.comboclient.Size = new System.Drawing.Size(303, 24);
            this.comboclient.TabIndex = 57;
            // 
            // txtnotes
            // 
            this.txtnotes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnotes.AutoSize = false;
            this.txtnotes.Location = new System.Drawing.Point(21, 34);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnotes.Size = new System.Drawing.Size(303, 94);
            this.txtnotes.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "ملاحضات";
            // 
            // client_paymentsgrid
            // 
            this.client_paymentsgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.client_paymentsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_paymentsgrid.Location = new System.Drawing.Point(12, 311);
            this.client_paymentsgrid.Name = "client_paymentsgrid";
            this.client_paymentsgrid.ReadOnly = true;
            this.client_paymentsgrid.RowTemplate.Height = 24;
            this.client_paymentsgrid.Size = new System.Drawing.Size(2020, 630);
            this.client_paymentsgrid.TabIndex = 53;
            this.client_paymentsgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.client_paymentsgrid_CellClick);
            // 
            // Payments_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 766);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnedite);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cllientpaymentdate);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboclient);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.client_paymentsgrid);
            this.Name = "Payments_Client";
            this.Text = "مدفوعات لعميل";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payments_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cllientpaymentdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_paymentsgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
        private Telerik.WinControls.UI.RadButton btndelet;
        private Telerik.WinControls.UI.RadButton btnedite;
        private Telerik.WinControls.UI.RadButton btnadd;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker cllientpaymentdate;
        private Telerik.WinControls.UI.RadTextBox txtvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboclient;
        private Telerik.WinControls.UI.RadTextBox txtnotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView client_paymentsgrid;
    }
}