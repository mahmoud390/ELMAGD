﻿namespace Elmagd
{
    partial class Incomes
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
            this.incomesgrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.incomesgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            this.SuspendLayout();
            // 
            // incomesgrid
            // 
            this.incomesgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incomesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomesgrid.Location = new System.Drawing.Point(12, 58);
            this.incomesgrid.Name = "incomesgrid";
            this.incomesgrid.RowTemplate.Height = 24;
            this.incomesgrid.Size = new System.Drawing.Size(2020, 920);
            this.incomesgrid.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1125, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "بحث";
            // 
            // txtSarch
            // 
            this.txtSarch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSarch.Location = new System.Drawing.Point(696, 28);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(406, 24);
            this.txtSarch.TabIndex = 36;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // Incomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 853);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.incomesgrid);
            this.Name = "Incomes";
            this.Text = "التوريدات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Incomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomesgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView incomesgrid;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
    }
}