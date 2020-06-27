﻿namespace Elmagd
{
    partial class Suppliers
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
            this.suppliersgrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new Telerik.WinControls.UI.RadTextBox();
            this.txtphone = new Telerik.WinControls.UI.RadTextBox();
            this.txtaddress = new Telerik.WinControls.UI.RadTextBox();
            this.btnadd = new Telerik.WinControls.UI.RadButton();
            this.btnedite = new Telerik.WinControls.UI.RadButton();
            this.btndelet = new Telerik.WinControls.UI.RadButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            this.txtnotes = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliersgrid
            // 
            this.suppliersgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersgrid.Location = new System.Drawing.Point(13, 339);
            this.suppliersgrid.Name = "suppliersgrid";
            this.suppliersgrid.ReadOnly = true;
            this.suppliersgrid.RowTemplate.Height = 24;
            this.suppliersgrid.Size = new System.Drawing.Size(2020, 620);
            this.suppliersgrid.TabIndex = 0;
            this.suppliersgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersgrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1746, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "الإسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1322, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "الهاتف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(907, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "العنوان";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(1412, 35);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(303, 24);
            this.txtname.TabIndex = 4;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(988, 35);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(303, 24);
            this.txtphone.TabIndex = 5;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(573, 40);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(303, 24);
            this.txtaddress.TabIndex = 6;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(1260, 127);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(157, 44);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "إضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedite
            // 
            this.btnedite.Location = new System.Drawing.Point(1022, 128);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(157, 44);
            this.btnedite.TabIndex = 8;
            this.btnedite.Text = "تعديل";
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // btndelet
            // 
            this.btndelet.Location = new System.Drawing.Point(801, 130);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(157, 44);
            this.btndelet.TabIndex = 9;
            this.btndelet.Text = "حذف";
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1277, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "بحث";
            // 
            // txtSarch
            // 
            this.txtSarch.Location = new System.Drawing.Point(890, 284);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(364, 24);
            this.txtSarch.TabIndex = 24;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // txtnotes
            // 
            this.txtnotes.AutoSize = false;
            this.txtnotes.Location = new System.Drawing.Point(85, 38);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnotes.Size = new System.Drawing.Size(373, 94);
            this.txtnotes.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "ملاحضات";
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 788);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnedite);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suppliersgrid);
            this.Name = "Suppliers";
            this.Text = "إضافة مورد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView suppliersgrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadTextBox txtname;
        private Telerik.WinControls.UI.RadTextBox txtphone;
        private Telerik.WinControls.UI.RadTextBox txtaddress;
        private Telerik.WinControls.UI.RadButton btnadd;
        private Telerik.WinControls.UI.RadButton btnedite;
        private Telerik.WinControls.UI.RadButton btndelet;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
        private Telerik.WinControls.UI.RadTextBox txtnotes;
        private System.Windows.Forms.Label label4;
    }
}