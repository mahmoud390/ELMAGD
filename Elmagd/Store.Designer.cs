﻿namespace Elmagd
{
    partial class Store
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
            this.txtname = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.storegrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            this.btndelet = new Telerik.WinControls.UI.RadButton();
            this.btnedite = new Telerik.WinControls.UI.RadButton();
            this.btnadd = new Telerik.WinControls.UI.RadButton();
            this.txtnotes = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(1321, 41);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(303, 24);
            this.txtname.TabIndex = 17;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1677, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "الإسم";
            // 
            // storegrid
            // 
            this.storegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storegrid.Location = new System.Drawing.Point(12, 339);
            this.storegrid.Name = "storegrid";
            this.storegrid.ReadOnly = true;
            this.storegrid.RowTemplate.Height = 24;
            this.storegrid.Size = new System.Drawing.Size(2020, 620);
            this.storegrid.TabIndex = 30;
            this.storegrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storegrid_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1406, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "بحث";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSarch
            // 
            this.txtSarch.Location = new System.Drawing.Point(909, 279);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(474, 24);
            this.txtSarch.TabIndex = 32;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // btndelet
            // 
            this.btndelet.Location = new System.Drawing.Point(1005, 188);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(123, 30);
            this.btndelet.TabIndex = 37;
            this.btndelet.Text = "حذف";
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // btnedite
            // 
            this.btnedite.Location = new System.Drawing.Point(1218, 188);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(129, 30);
            this.btnedite.TabIndex = 36;
            this.btnedite.Text = "تعديل";
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(1430, 188);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(126, 30);
            this.btnadd.TabIndex = 35;
            this.btnadd.Text = "إضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtnotes
            // 
            this.txtnotes.AutoSize = false;
            this.txtnotes.Location = new System.Drawing.Point(708, 37);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnotes.Size = new System.Drawing.Size(442, 94);
            this.txtnotes.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1181, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "ملاحضات";
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 777);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnedite);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.storegrid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Store";
            this.Text = "إضافة مخزن";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView storegrid;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
        private Telerik.WinControls.UI.RadButton btndelet;
        private Telerik.WinControls.UI.RadButton btnedite;
        private Telerik.WinControls.UI.RadButton btnadd;
        private Telerik.WinControls.UI.RadTextBox txtnotes;
        private System.Windows.Forms.Label label4;
    }
}