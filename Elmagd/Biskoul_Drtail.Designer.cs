namespace Elmagd
{
    partial class Biskoul_Drtail
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
            this.dateTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.gridBiskoul = new System.Windows.Forms.DataGridView();
            this.btnCalc = new Telerik.WinControls.UI.RadButton();
            this.txtValue = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnShowDuringPeriod = new Telerik.WinControls.UI.RadButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBiskoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd-MM-yyyy";
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(1198, 291);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(197, 32);
            this.dateTo.TabIndex = 20;
            this.dateTo.TabStop = false;
            this.dateTo.Text = "30-06-2020";
            this.dateTo.Value = new System.DateTime(2020, 6, 30, 14, 41, 31, 882);
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd-MM-yyyy";
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(1198, 189);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(197, 32);
            this.dateFrom.TabIndex = 19;
            this.dateFrom.TabStop = false;
            this.dateFrom.Text = "30-06-2020";
            this.dateFrom.Value = new System.DateTime(2020, 6, 30, 14, 41, 31, 882);
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // gridBiskoul
            // 
            this.gridBiskoul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBiskoul.Location = new System.Drawing.Point(29, 95);
            this.gridBiskoul.Name = "gridBiskoul";
            this.gridBiskoul.RowTemplate.Height = 26;
            this.gridBiskoul.Size = new System.Drawing.Size(1104, 650);
            this.gridBiskoul.TabIndex = 18;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalc.Location = new System.Drawing.Point(1198, 389);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(247, 46);
            this.btnCalc.TabIndex = 17;
            this.btnCalc.Text = "حساب";
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtValue.Location = new System.Drawing.Point(1216, 501);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(201, 32);
            this.txtValue.TabIndex = 16;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel3.Location = new System.Drawing.Point(1456, 501);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(49, 25);
            this.radLabel3.TabIndex = 15;
            this.radLabel3.Text = "القيمة";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(1441, 289);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(78, 25);
            this.radLabel2.TabIndex = 14;
            this.radLabel2.Text = "التاريخ إلى";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(1441, 189);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(76, 25);
            this.radLabel1.TabIndex = 13;
            this.radLabel1.Text = "التاريخ من";
            // 
            // btnShowDuringPeriod
            // 
            this.btnShowDuringPeriod.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnShowDuringPeriod.Location = new System.Drawing.Point(930, 49);
            this.btnShowDuringPeriod.Name = "btnShowDuringPeriod";
            this.btnShowDuringPeriod.Size = new System.Drawing.Size(203, 40);
            this.btnShowDuringPeriod.TabIndex = 21;
            this.btnShowDuringPeriod.Text = "عرض خلال فترة";
            this.btnShowDuringPeriod.Click += new System.EventHandler(this.btnShowDuringPeriod_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(699, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 24);
            this.label9.TabIndex = 85;
            this.label9.Text = "بحث";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSarch
            // 
            this.txtSarch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSarch.Location = new System.Drawing.Point(185, 53);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(491, 32);
            this.txtSarch.TabIndex = 84;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // Biskoul_Drtail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1590, 757);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.btnShowDuringPeriod);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.gridBiskoul);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "Biskoul_Drtail";
            this.Text = "التفصيلي بسكول";
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBiskoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker dateTo;
        private Telerik.WinControls.UI.RadDateTimePicker dateFrom;
        private System.Windows.Forms.DataGridView gridBiskoul;
        private Telerik.WinControls.UI.RadButton btnCalc;
        private Telerik.WinControls.UI.RadTextBox txtValue;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnShowDuringPeriod;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
    }
}