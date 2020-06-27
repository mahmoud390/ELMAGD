namespace Elmagd
{
    partial class General_payments
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
            this.txtvalue = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndelet = new Telerik.WinControls.UI.RadButton();
            this.btnedite = new Telerik.WinControls.UI.RadButton();
            this.btnadd = new Telerik.WinControls.UI.RadButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            this.generalpaymentgrid = new System.Windows.Forms.DataGridView();
            this.txtnotes = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generaldate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalpaymentgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generaldate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).BeginInit();
            this.SuspendLayout();
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(503, 37);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(286, 24);
            this.txtvalue.TabIndex = 88;
            this.txtvalue.TextChanged += new System.EventHandler(this.txtvalue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(841, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "المبلغ";
            // 
            // btndelet
            // 
            this.btndelet.Location = new System.Drawing.Point(605, 115);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(179, 43);
            this.btndelet.TabIndex = 86;
            this.btndelet.Text = "حذف";
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // btnedite
            // 
            this.btnedite.Location = new System.Drawing.Point(867, 118);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(195, 43);
            this.btnedite.TabIndex = 85;
            this.btnedite.Text = "تعديل";
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(1140, 118);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(191, 43);
            this.btnadd.TabIndex = 84;
            this.btnadd.Text = "إضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1078, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 83;
            this.label9.Text = "بحث";
            // 
            // txtSarch
            // 
            this.txtSarch.Location = new System.Drawing.Point(729, 224);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(326, 24);
            this.txtSarch.TabIndex = 82;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // generalpaymentgrid
            // 
            this.generalpaymentgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generalpaymentgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generalpaymentgrid.Location = new System.Drawing.Point(12, 263);
            this.generalpaymentgrid.Name = "generalpaymentgrid";
            this.generalpaymentgrid.ReadOnly = true;
            this.generalpaymentgrid.RowTemplate.Height = 24;
            this.generalpaymentgrid.Size = new System.Drawing.Size(2020, 720);
            this.generalpaymentgrid.TabIndex = 81;
            this.generalpaymentgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.generalpaymentgrid_CellClick);
            // 
            // txtnotes
            // 
            this.txtnotes.AutoSize = false;
            this.txtnotes.Location = new System.Drawing.Point(59, 37);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnotes.Size = new System.Drawing.Size(303, 94);
            this.txtnotes.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "ملاحضات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1761, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "التاريخ";
            // 
            // generaldate
            // 
            this.generaldate.CustomFormat = "dd-MM-yyyy";
            this.generaldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.generaldate.Location = new System.Drawing.Point(1436, 40);
            this.generaldate.Name = "generaldate";
            this.generaldate.Size = new System.Drawing.Size(286, 24);
            this.generaldate.TabIndex = 77;
            this.generaldate.TabStop = false;
            this.generaldate.Text = "23-06-2020";
            this.generaldate.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1294, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "الإسم ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(958, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(286, 24);
            this.txtname.TabIndex = 75;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // General_payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 776);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnedite);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.generalpaymentgrid);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generaldate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Name = "General_payments";
            this.Text = "المدفوعات العامة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.General_payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalpaymentgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generaldate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtvalue;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton btndelet;
        private Telerik.WinControls.UI.RadButton btnedite;
        private Telerik.WinControls.UI.RadButton btnadd;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
        private System.Windows.Forms.DataGridView generalpaymentgrid;
        private Telerik.WinControls.UI.RadTextBox txtnotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDateTimePicker generaldate;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtname;
    }
}