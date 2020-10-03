namespace Elmagd
{
    partial class Supplier_Audit_Balance
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
            this.dateFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowDuringPeriod = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.bakeygrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.combosuppliers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbaky = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpaid = new Telerik.WinControls.UI.RadTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new Telerik.WinControls.UI.RadTextBox();
            this.btncalc = new Telerik.WinControls.UI.RadButton();
            this.btnhesab = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakeygrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhesab)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFrom
            // 
            this.dateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFrom.CustomFormat = "dd-MM-yyyy";
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(1292, 96);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(303, 39);
            this.dateFrom.TabIndex = 68;
            this.dateFrom.TabStop = false;
            this.dateFrom.Text = "23-06-2020";
            this.dateFrom.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // dateTo
            // 
            this.dateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTo.CustomFormat = "dd-MM-yyyy";
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(1292, 197);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(303, 39);
            this.dateTo.TabIndex = 68;
            this.dateTo.TabStop = false;
            this.dateTo.Text = "23-06-2020";
            this.dateTo.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1680, 197);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 69;
            this.label1.Text = "التاريخ الي:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1680, 111);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "التاريخ من:";
            // 
            // btnShowDuringPeriod
            // 
            this.btnShowDuringPeriod.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnShowDuringPeriod.ForeColor = System.Drawing.Color.Black;
            this.btnShowDuringPeriod.Location = new System.Drawing.Point(1528, 303);
            this.btnShowDuringPeriod.Name = "btnShowDuringPeriod";
            this.btnShowDuringPeriod.Size = new System.Drawing.Size(187, 46);
            this.btnShowDuringPeriod.TabIndex = 71;
            this.btnShowDuringPeriod.Text = "عرض خلال فترة";
            this.btnShowDuringPeriod.Click += new System.EventHandler(this.btnShowDuringPeriod_Click);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.radButton1.ForeColor = System.Drawing.Color.Black;
            this.radButton1.Location = new System.Drawing.Point(1319, 303);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(187, 46);
            this.radButton1.TabIndex = 72;
            this.radButton1.Text = "عرض بشكل عام";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.bakeygrid);
            this.radGroupBox1.HeaderText = "عرض الباقي من قواتير الموردين ";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox1.Size = new System.Drawing.Size(1260, 940);
            this.radGroupBox1.TabIndex = 74;
            this.radGroupBox1.Text = "عرض الباقي من قواتير الموردين ";
            // 
            // bakeygrid
            // 
            this.bakeygrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bakeygrid.BackgroundColor = System.Drawing.Color.White;
            this.bakeygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bakeygrid.Location = new System.Drawing.Point(17, 21);
            this.bakeygrid.Name = "bakeygrid";
            this.bakeygrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakeygrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bakeygrid.RowTemplate.Height = 24;
            this.bakeygrid.Size = new System.Drawing.Size(1228, 900);
            this.bakeygrid.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1678, 26);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "إسم المورد:";
            // 
            // combosuppliers
            // 
            this.combosuppliers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combosuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combosuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combosuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combosuppliers.FormattingEnabled = true;
            this.combosuppliers.Location = new System.Drawing.Point(1292, 23);
            this.combosuppliers.Name = "combosuppliers";
            this.combosuppliers.Size = new System.Drawing.Size(303, 28);
            this.combosuppliers.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1607, 714);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 89;
            this.label5.Text = "الباقي للمورد:";
            // 
            // txtbaky
            // 
            this.txtbaky.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbaky.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbaky.Location = new System.Drawing.Point(1335, 710);
            this.txtbaky.Name = "txtbaky";
            this.txtbaky.Size = new System.Drawing.Size(239, 28);
            this.txtbaky.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1643, 617);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 87;
            this.label4.Text = "المدفوع:";
            // 
            // txtpaid
            // 
            this.txtpaid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpaid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpaid.Location = new System.Drawing.Point(1335, 617);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(239, 28);
            this.txtpaid.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1633, 525);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 85;
            this.label6.Text = "الإجمالي :";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttotal.Location = new System.Drawing.Point(1335, 521);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(239, 28);
            this.txttotal.TabIndex = 84;
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btncalc.ForeColor = System.Drawing.Color.Black;
            this.btncalc.Location = new System.Drawing.Point(1295, 447);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(467, 46);
            this.btncalc.TabIndex = 83;
            this.btncalc.Text = "حساب المورد";
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnhesab
            // 
            this.btnhesab.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnhesab.ForeColor = System.Drawing.Color.Black;
            this.btnhesab.Location = new System.Drawing.Point(1297, 375);
            this.btnhesab.Name = "btnhesab";
            this.btnhesab.Size = new System.Drawing.Size(467, 46);
            this.btnhesab.TabIndex = 84;
            this.btnhesab.Text = "حساب المورد خلال الفترة";
            this.btnhesab.Click += new System.EventHandler(this.btnhesab_Click);
            // 
            // Supplier_Audit_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1802, 762);
            this.Controls.Add(this.btnhesab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbaky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combosuppliers);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnShowDuringPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Supplier_Audit_Balance";
            this.Text = "الباقي من الموردين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Supplier_Audit_Balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bakeygrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhesab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker dateFrom;
        private Telerik.WinControls.UI.RadDateTimePicker dateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnShowDuringPeriod;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.DataGridView bakeygrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combosuppliers;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtbaky;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox txtpaid;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadTextBox txttotal;
        private Telerik.WinControls.UI.RadButton btncalc;
        private Telerik.WinControls.UI.RadButton btnhesab;
    }
}