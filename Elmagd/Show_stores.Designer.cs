﻿namespace Elmagd
{
    partial class Show_stores
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
            this.label12 = new System.Windows.Forms.Label();
            this.comboquantitytype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combostore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.btngard = new Telerik.WinControls.UI.RadButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantity = new Telerik.WinControls.UI.RadTextBox();
            this.showstoregrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btngard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showstoregrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(821, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 72;
            this.label12.Text = "نوع الكمية";
            // 
            // comboquantitytype
            // 
            this.comboquantitytype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboquantitytype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboquantitytype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboquantitytype.FormattingEnabled = true;
            this.comboquantitytype.Location = new System.Drawing.Point(544, 42);
            this.comboquantitytype.Name = "comboquantitytype";
            this.comboquantitytype.Size = new System.Drawing.Size(241, 24);
            this.comboquantitytype.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1698, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "المخزن";
            // 
            // combostore
            // 
            this.combostore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combostore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combostore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combostore.FormattingEnabled = true;
            this.combostore.Location = new System.Drawing.Point(1410, 42);
            this.combostore.Name = "combostore";
            this.combostore.Size = new System.Drawing.Size(241, 24);
            this.combostore.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1209, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "الصنف";
            // 
            // combocategory
            // 
            this.combocategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combocategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combocategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Location = new System.Drawing.Point(932, 46);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(241, 24);
            this.combocategory.TabIndex = 67;
            // 
            // btngard
            // 
            this.btngard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btngard.Location = new System.Drawing.Point(998, 140);
            this.btngard.Name = "btngard";
            this.btngard.Size = new System.Drawing.Size(189, 44);
            this.btngard.TabIndex = 73;
            this.btngard.Text = "جرد";
            this.btngard.Click += new System.EventHandler(this.btngard_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1277, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "الكميه";
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtquantity.Location = new System.Drawing.Point(979, 245);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(239, 24);
            this.txtquantity.TabIndex = 74;
            // 
            // showstoregrid
            // 
            this.showstoregrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showstoregrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showstoregrid.Location = new System.Drawing.Point(12, 317);
            this.showstoregrid.Name = "showstoregrid";
            this.showstoregrid.RowTemplate.Height = 24;
            this.showstoregrid.Size = new System.Drawing.Size(2020, 650);
            this.showstoregrid.TabIndex = 76;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Elmagd.Properties.Resources.رز;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // Show_stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 776);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showstoregrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.btngard);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboquantitytype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combostore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combocategory);
            this.Name = "Show_stores";
            this.Text = "عرض المخازن";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Show_stores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btngard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showstoregrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboquantitytype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combostore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combocategory;
        private Telerik.WinControls.UI.RadButton btngard;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtquantity;
        private System.Windows.Forms.DataGridView showstoregrid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}