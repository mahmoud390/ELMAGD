﻿namespace Elmagd
{
    partial class Clint_Detail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShowDuringPeriod = new Telerik.WinControls.UI.RadButton();
            this.dateTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnCalc = new Telerik.WinControls.UI.RadButton();
            this.txtValue = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.gridsupplierspayments = new System.Windows.Forms.DataGridView();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.gridClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridsupplierspayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowDuringPeriod
            // 
            this.btnShowDuringPeriod.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnShowDuringPeriod.ForeColor = System.Drawing.Color.Black;
            this.btnShowDuringPeriod.Location = new System.Drawing.Point(47, 35);
            this.btnShowDuringPeriod.Name = "btnShowDuringPeriod";
            this.btnShowDuringPeriod.Size = new System.Drawing.Size(179, 37);
            this.btnShowDuringPeriod.TabIndex = 30;
            this.btnShowDuringPeriod.Text = "عرض خلال فترة";
            this.btnShowDuringPeriod.Click += new System.EventHandler(this.btnShowDuringPeriod_Click);
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd-MM-yyyy";
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(547, 19);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(197, 39);
            this.dateTo.TabIndex = 29;
            this.dateTo.TabStop = false;
            this.dateTo.Text = "30-06-2020";
            this.dateTo.Value = new System.DateTime(2020, 6, 30, 14, 41, 31, 882);
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd-MM-yyyy";
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(936, 22);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(197, 39);
            this.dateFrom.TabIndex = 28;
            this.dateFrom.TabStop = false;
            this.dateFrom.Text = "30-06-2020";
            this.dateFrom.Value = new System.DateTime(2020, 6, 30, 14, 41, 31, 882);
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnCalc.ForeColor = System.Drawing.Color.Black;
            this.btnCalc.Location = new System.Drawing.Point(343, 22);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(157, 46);
            this.btnCalc.TabIndex = 26;
            this.btnCalc.Text = "حساب";
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtValue.Location = new System.Drawing.Point(12, 29);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(182, 32);
            this.txtValue.TabIndex = 25;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(1186, 28);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(87, 27);
            this.radLabel1.TabIndex = 22;
            this.radLabel1.Text = "التاريخ من:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(560, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 24);
            this.label9.TabIndex = 87;
            this.label9.Text = "بحث";
            // 
            // txtSarch
            // 
            this.txtSarch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSarch.Location = new System.Drawing.Point(46, 146);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(491, 32);
            this.txtSarch.TabIndex = 86;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(797, 28);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(89, 27);
            this.radLabel2.TabIndex = 23;
            this.radLabel2.Text = "التاريخ إلي:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(239, 31);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(55, 27);
            this.radLabel3.TabIndex = 24;
            this.radLabel3.Text = "القيمة:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnShowDuringPeriod);
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(1047, 89);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(250, 99);
            this.radGroupBox1.TabIndex = 88;
            this.radGroupBox1.Text = "radGroupBox1";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.gridsupplierspayments);
            this.radGroupBox2.HeaderText = "المدفوع من مورد اجل";
            this.radGroupBox2.Location = new System.Drawing.Point(636, 194);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox2.Size = new System.Drawing.Size(661, 589);
            this.radGroupBox2.TabIndex = 101;
            this.radGroupBox2.Text = "المدفوع من مورد اجل";
            // 
            // gridsupplierspayments
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridsupplierspayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridsupplierspayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridsupplierspayments.BackgroundColor = System.Drawing.Color.White;
            this.gridsupplierspayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridsupplierspayments.Location = new System.Drawing.Point(5, 21);
            this.gridsupplierspayments.Name = "gridsupplierspayments";
            this.gridsupplierspayments.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridsupplierspayments.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gridsupplierspayments.RowTemplate.Height = 26;
            this.gridsupplierspayments.Size = new System.Drawing.Size(650, 563);
            this.gridsupplierspayments.TabIndex = 99;
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.gridClient);
            this.radGroupBox3.HeaderText = "عرض المدفوع من فواتير العملاء";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 194);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(608, 589);
            this.radGroupBox3.TabIndex = 102;
            this.radGroupBox3.Text = "عرض المدفوع من فواتير العملاء";
            // 
            // gridClient
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClient.BackgroundColor = System.Drawing.Color.White;
            this.gridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClient.Location = new System.Drawing.Point(13, 27);
            this.gridClient.Name = "gridClient";
            this.gridClient.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridClient.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gridClient.RowTemplate.Height = 26;
            this.gridClient.Size = new System.Drawing.Size(582, 556);
            this.gridClient.TabIndex = 28;
            // 
            // Clint_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1332, 790);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Clint_Detail";
            this.Text = "العملاء تفصيلي";
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridsupplierspayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnShowDuringPeriod;
        private Telerik.WinControls.UI.RadDateTimePicker dateTo;
        private Telerik.WinControls.UI.RadDateTimePicker dateFrom;
        private Telerik.WinControls.UI.RadButton btnCalc;
        private Telerik.WinControls.UI.RadTextBox txtValue;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.DataGridView gridsupplierspayments;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private System.Windows.Forms.DataGridView gridClient;
    }
}