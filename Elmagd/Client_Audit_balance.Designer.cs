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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bakeygrid = new System.Windows.Forms.DataGridView();
            this.showAutoGeneral = new Telerik.WinControls.UI.RadButton();
            this.btnShowDuringPeriod = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bakeygrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAutoGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // bakeygrid
            // 
            this.bakeygrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bakeygrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bakeygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bakeygrid.Location = new System.Drawing.Point(3, 150);
            this.bakeygrid.Name = "bakeygrid";
            this.bakeygrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakeygrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bakeygrid.RowTemplate.Height = 24;
            this.bakeygrid.Size = new System.Drawing.Size(1012, 602);
            this.bakeygrid.TabIndex = 80;
            // 
            // showAutoGeneral
            // 
            this.showAutoGeneral.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showAutoGeneral.Location = new System.Drawing.Point(264, 96);
            this.showAutoGeneral.Name = "showAutoGeneral";
            this.showAutoGeneral.Size = new System.Drawing.Size(187, 48);
            this.showAutoGeneral.TabIndex = 79;
            this.showAutoGeneral.Text = "عرض بشكل عام";
            this.showAutoGeneral.Click += new System.EventHandler(this.showAutoGeneral_Click);
            // 
            // btnShowDuringPeriod
            // 
            this.btnShowDuringPeriod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowDuringPeriod.Location = new System.Drawing.Point(563, 96);
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
            this.label2.Location = new System.Drawing.Point(916, 35);
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
            this.label1.Location = new System.Drawing.Point(390, 31);
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
            this.dateTo.Location = new System.Drawing.Point(50, 20);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(286, 39);
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
            this.dateFrom.Location = new System.Drawing.Point(578, 24);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(286, 39);
            this.dateFrom.TabIndex = 75;
            this.dateFrom.TabStop = false;
            this.dateFrom.Text = "23-06-2020";
            this.dateFrom.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // Client_Audit_balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1036, 764);
            this.Controls.Add(this.bakeygrid);
            this.Controls.Add(this.showAutoGeneral);
            this.Controls.Add(this.btnShowDuringPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Client_Audit_balance";
            this.Text = "الباقي من فواتير العملاء";
            this.Load += new System.EventHandler(this.Client_Audit_balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bakeygrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAutoGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowDuringPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bakeygrid;
        private Telerik.WinControls.UI.RadButton showAutoGeneral;
        private Telerik.WinControls.UI.RadButton btnShowDuringPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker dateTo;
        private Telerik.WinControls.UI.RadDateTimePicker dateFrom;
    }
}