﻿namespace Elmagd
{
    partial class General_Payments_Detail
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
            this.gridGeneralPayments = new System.Windows.Forms.DataGridView();
            this.btnCalc = new Telerik.WinControls.UI.RadButton();
            this.txtValue = new Telerik.WinControls.UI.RadTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneralPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowDuringPeriod
            // 
            this.btnShowDuringPeriod.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnShowDuringPeriod.ForeColor = System.Drawing.Color.Black;
            this.btnShowDuringPeriod.Location = new System.Drawing.Point(726, 77);
            this.btnShowDuringPeriod.Name = "btnShowDuringPeriod";
            this.btnShowDuringPeriod.Size = new System.Drawing.Size(175, 38);
            this.btnShowDuringPeriod.TabIndex = 39;
            this.btnShowDuringPeriod.Text = "عرض خلال فترة";
            this.btnShowDuringPeriod.Click += new System.EventHandler(this.btnShowDuringPeriod_Click);
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd-MM-yyyy";
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(935, 303);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(197, 39);
            this.dateTo.TabIndex = 38;
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
            this.dateFrom.Location = new System.Drawing.Point(935, 189);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(197, 39);
            this.dateFrom.TabIndex = 37;
            this.dateFrom.TabStop = false;
            this.dateFrom.Text = "30-06-2020";
            this.dateFrom.Value = new System.DateTime(2020, 6, 30, 14, 41, 31, 882);
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // gridGeneralPayments
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGeneralPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridGeneralPayments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGeneralPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridGeneralPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGeneralPayments.Location = new System.Drawing.Point(21, 123);
            this.gridGeneralPayments.Name = "gridGeneralPayments";
            this.gridGeneralPayments.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGeneralPayments.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gridGeneralPayments.RowTemplate.Height = 26;
            this.gridGeneralPayments.Size = new System.Drawing.Size(893, 563);
            this.gridGeneralPayments.TabIndex = 36;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnCalc.ForeColor = System.Drawing.Color.Black;
            this.btnCalc.Location = new System.Drawing.Point(957, 384);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(157, 43);
            this.btnCalc.TabIndex = 35;
            this.btnCalc.Text = "حساب";
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtValue.Location = new System.Drawing.Point(935, 488);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(197, 32);
            this.txtValue.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(596, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 24);
            this.label9.TabIndex = 91;
            this.label9.Text = "بحث";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSarch
            // 
            this.txtSarch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSarch.Location = new System.Drawing.Point(82, 79);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(491, 32);
            this.txtSarch.TabIndex = 90;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(1214, 488);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(55, 27);
            this.radLabel2.TabIndex = 95;
            this.radLabel2.Text = "القيمة:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(1197, 304);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel4.Size = new System.Drawing.Size(89, 27);
            this.radLabel4.TabIndex = 94;
            this.radLabel4.Text = "التاريخ إلي:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(1199, 189);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(87, 27);
            this.radLabel1.TabIndex = 93;
            this.radLabel1.Text = "التاريخ من:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // General_Payments_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1338, 698);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.btnShowDuringPeriod);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.gridGeneralPayments);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "General_Payments_Detail";
            this.Text = "المدفوعات العامة تفصيلي";
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneralPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnShowDuringPeriod;
        private Telerik.WinControls.UI.RadDateTimePicker dateTo;
        private Telerik.WinControls.UI.RadDateTimePicker dateFrom;
        private System.Windows.Forms.DataGridView gridGeneralPayments;
        private Telerik.WinControls.UI.RadButton btnCalc;
        private Telerik.WinControls.UI.RadTextBox txtValue;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}