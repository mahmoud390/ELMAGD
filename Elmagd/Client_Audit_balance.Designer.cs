namespace Elmagd
{
    partial class Client_Audit_balance
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
            this.showAutoGeneral = new Telerik.WinControls.UI.RadButton();
            this.btnShowDuringPeriod = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboclient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbaky = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpaid = new Telerik.WinControls.UI.RadTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new Telerik.WinControls.UI.RadTextBox();
            this.btncalc = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.bakeygrid = new System.Windows.Forms.DataGridView();
            this.btnhesab = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.showAutoGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakeygrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhesab)).BeginInit();
            this.SuspendLayout();
            // 
            // showAutoGeneral
            // 
            this.showAutoGeneral.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.showAutoGeneral.ForeColor = System.Drawing.Color.Black;
            this.showAutoGeneral.Location = new System.Drawing.Point(1376, 285);
            this.showAutoGeneral.Name = "showAutoGeneral";
            this.showAutoGeneral.Size = new System.Drawing.Size(187, 48);
            this.showAutoGeneral.TabIndex = 79;
            this.showAutoGeneral.Text = "عرض بشكل عام";
            this.showAutoGeneral.Click += new System.EventHandler(this.showAutoGeneral_Click);
            // 
            // btnShowDuringPeriod
            // 
            this.btnShowDuringPeriod.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnShowDuringPeriod.ForeColor = System.Drawing.Color.Black;
            this.btnShowDuringPeriod.Location = new System.Drawing.Point(1617, 285);
            this.btnShowDuringPeriod.Name = "btnShowDuringPeriod";
            this.btnShowDuringPeriod.Size = new System.Drawing.Size(187, 48);
            this.btnShowDuringPeriod.TabIndex = 78;
            this.btnShowDuringPeriod.Text = "عرض خلال فترة";
            this.btnShowDuringPeriod.Click += new System.EventHandler(this.btnShowDuringPeriod_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1681, 107);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(108, 30);
            this.label2.TabIndex = 77;
            this.label2.Text = "التاريخ من:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1679, 195);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 76;
            this.label1.Text = "التاريخ الي:";
            // 
            // dateTo
            // 
            this.dateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTo.CustomFormat = "dd-MM-yyyy";
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(1326, 195);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(303, 39);
            this.dateTo.TabIndex = 74;
            this.dateTo.TabStop = false;
            this.dateTo.Text = "23-06-2020";
            this.dateTo.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // dateFrom
            // 
            this.dateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFrom.CustomFormat = "dd-MM-yyyy";
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(1326, 96);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(303, 39);
            this.dateFrom.TabIndex = 75;
            this.dateFrom.TabStop = false;
            this.dateFrom.Text = "23-06-2020";
            this.dateFrom.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1716, 33);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 82;
            this.label3.Text = "العميل:";
            // 
            // comboclient
            // 
            this.comboclient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboclient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboclient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboclient.FormattingEnabled = true;
            this.comboclient.Location = new System.Drawing.Point(1326, 33);
            this.comboclient.Name = "comboclient";
            this.comboclient.Size = new System.Drawing.Size(303, 28);
            this.comboclient.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1668, 689);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 96;
            this.label5.Text = "الباقي علي العميل:";
            // 
            // txtbaky
            // 
            this.txtbaky.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbaky.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbaky.Location = new System.Drawing.Point(1396, 685);
            this.txtbaky.Name = "txtbaky";
            this.txtbaky.Size = new System.Drawing.Size(239, 28);
            this.txtbaky.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1704, 592);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 94;
            this.label4.Text = "المدفوع:";
            // 
            // txtpaid
            // 
            this.txtpaid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpaid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpaid.Location = new System.Drawing.Point(1396, 592);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(239, 28);
            this.txtpaid.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1694, 500);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 92;
            this.label6.Text = "الإجمالي :";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttotal.Location = new System.Drawing.Point(1396, 496);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(239, 28);
            this.txttotal.TabIndex = 91;
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btncalc.ForeColor = System.Drawing.Color.Black;
            this.btncalc.Location = new System.Drawing.Point(1329, 424);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(467, 46);
            this.btncalc.TabIndex = 90;
            this.btncalc.Text = "حساب العميل";
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.bakeygrid);
            this.radGroupBox1.HeaderText = "عرض التفصيلي";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox1.Size = new System.Drawing.Size(1299, 940);
            this.radGroupBox1.TabIndex = 97;
            this.radGroupBox1.Text = "عرض التفصيلي";
            // 
            // bakeygrid
            // 
            this.bakeygrid.BackgroundColor = System.Drawing.Color.White;
            this.bakeygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bakeygrid.Location = new System.Drawing.Point(27, 21);
            this.bakeygrid.Name = "bakeygrid";
            this.bakeygrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakeygrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bakeygrid.RowTemplate.Height = 24;
            this.bakeygrid.Size = new System.Drawing.Size(1244, 900);
            this.bakeygrid.TabIndex = 81;
            // 
            // btnhesab
            // 
            this.btnhesab.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnhesab.ForeColor = System.Drawing.Color.Black;
            this.btnhesab.Location = new System.Drawing.Point(1329, 360);
            this.btnhesab.Name = "btnhesab";
            this.btnhesab.Size = new System.Drawing.Size(467, 46);
            this.btnhesab.TabIndex = 91;
            this.btnhesab.Text = "حساب العمسل خلال فترة";
            this.btnhesab.Click += new System.EventHandler(this.btnhesab_Click);
            // 
            // Client_Audit_balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1806, 764);
            this.Controls.Add(this.btnhesab);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbaky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboclient);
            this.Controls.Add(this.showAutoGeneral);
            this.Controls.Add(this.btnShowDuringPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Client_Audit_balance";
            this.Text = "الباقي من فواتير العملاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Client_Audit_balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showAutoGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bakeygrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhesab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton showAutoGeneral;
        private Telerik.WinControls.UI.RadButton btnShowDuringPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker dateTo;
        private Telerik.WinControls.UI.RadDateTimePicker dateFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboclient;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtbaky;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox txtpaid;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadTextBox txttotal;
        private Telerik.WinControls.UI.RadButton btncalc;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.DataGridView bakeygrid;
        private Telerik.WinControls.UI.RadButton btnhesab;
    }
}