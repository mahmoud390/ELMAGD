﻿namespace Elmagd
{
    partial class Sales
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
            this.salesgrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salesgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            this.SuspendLayout();
            // 
            // salesgrid
            // 
            this.salesgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesgrid.Location = new System.Drawing.Point(12, 83);
            this.salesgrid.Name = "salesgrid";
            this.salesgrid.ReadOnly = true;
            this.salesgrid.RowTemplate.Height = 24;
            this.salesgrid.Size = new System.Drawing.Size(2020, 900);
            this.salesgrid.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(796, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "بحث";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSarch
            // 
            this.txtSarch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSarch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSarch.Location = new System.Drawing.Point(352, 33);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(421, 32);
            this.txtSarch.TabIndex = 34;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(148)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1436, 764);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.salesgrid);
            this.Name = "Sales";
            this.Text = "المبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesgrid;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
    }
}