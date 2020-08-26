namespace Elmagd
{
    partial class Sales_Returns
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.comboquantitytype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotal = new Telerik.WinControls.UI.RadTextBox();
            this.btncalc = new Telerik.WinControls.UI.RadButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprice = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantity = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combostore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboclient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientinvoicedate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btndelet = new Telerik.WinControls.UI.RadButton();
            this.btnadd = new Telerik.WinControls.UI.RadButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            this.returnsgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinvoicedate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1255, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 103;
            this.label12.Text = "نوع الكمية";
            // 
            // comboquantitytype
            // 
            this.comboquantitytype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboquantitytype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboquantitytype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboquantitytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboquantitytype.FormattingEnabled = true;
            this.comboquantitytype.Location = new System.Drawing.Point(1041, 134);
            this.comboquantitytype.Name = "comboquantitytype";
            this.comboquantitytype.Size = new System.Drawing.Size(172, 28);
            this.comboquantitytype.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 101;
            this.label7.Text = "الإجمالي";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(122)))), ((int)(((byte)(13)))));
            this.txttotal.Location = new System.Drawing.Point(42, 134);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(239, 32);
            this.txttotal.TabIndex = 100;
            // 
            // btncalc
            // 
            this.btncalc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(10)))));
            this.btncalc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.ForeColor = System.Drawing.Color.Black;
            this.btncalc.Location = new System.Drawing.Point(437, 126);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(155, 38);
            this.btncalc.TabIndex = 99;
            this.btncalc.Text = "حساب الإجمالي";
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(938, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 98;
            this.label6.Text = "السعر";
            // 
            // txtprice
            // 
            this.txtprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtprice.Location = new System.Drawing.Point(647, 138);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(239, 28);
            this.txtprice.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1684, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 96;
            this.label5.Text = "الكميه";
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtquantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtquantity.Location = new System.Drawing.Point(1386, 130);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(239, 32);
            this.txtquantity.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 94;
            this.label4.Text = "المخزن";
            // 
            // combostore
            // 
            this.combostore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combostore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combostore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combostore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combostore.FormattingEnabled = true;
            this.combostore.Location = new System.Drawing.Point(36, 48);
            this.combostore.Name = "combostore";
            this.combostore.Size = new System.Drawing.Size(251, 28);
            this.combostore.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(722, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 92;
            this.label3.Text = "الصنف";
            // 
            // combocategory
            // 
            this.combocategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combocategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combocategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combocategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Location = new System.Drawing.Point(437, 48);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(241, 28);
            this.combocategory.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1223, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 90;
            this.label2.Text = "العميل";
            // 
            // comboclient
            // 
            this.comboclient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboclient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboclient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboclient.FormattingEnabled = true;
            this.comboclient.Location = new System.Drawing.Point(838, 45);
            this.comboclient.Name = "comboclient";
            this.comboclient.Size = new System.Drawing.Size(303, 28);
            this.comboclient.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1697, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 88;
            this.label1.Text = "التاريخ";
            // 
            // clientinvoicedate
            // 
            this.clientinvoicedate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientinvoicedate.CustomFormat = "dd-MM-yyyy";
            this.clientinvoicedate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clientinvoicedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.clientinvoicedate.Location = new System.Drawing.Point(1372, 47);
            this.clientinvoicedate.Name = "clientinvoicedate";
            this.clientinvoicedate.Size = new System.Drawing.Size(286, 32);
            this.clientinvoicedate.TabIndex = 87;
            this.clientinvoicedate.TabStop = false;
            this.clientinvoicedate.Text = "23-06-2020";
            this.clientinvoicedate.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // btndelet
            // 
            this.btndelet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndelet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(51)))), ((int)(((byte)(22)))));
            this.btndelet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelet.ForeColor = System.Drawing.Color.Black;
            this.btndelet.Location = new System.Drawing.Point(619, 246);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(157, 56);
            this.btndelet.TabIndex = 105;
            this.btndelet.Text = "حذف";
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(199)))), ((int)(((byte)(14)))));
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(930, 246);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(165, 56);
            this.btnadd.TabIndex = 104;
            this.btnadd.Text = "إضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1103, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 24);
            this.label9.TabIndex = 108;
            this.label9.Text = "بحث";
            // 
            // txtSarch
            // 
            this.txtSarch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSarch.Location = new System.Drawing.Point(638, 330);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(431, 24);
            this.txtSarch.TabIndex = 107;
            // 
            // returnsgrid
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnsgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.returnsgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnsgrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnsgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.returnsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnsgrid.Location = new System.Drawing.Point(6, 373);
            this.returnsgrid.Name = "returnsgrid";
            this.returnsgrid.ReadOnly = true;
            this.returnsgrid.RowTemplate.Height = 24;
            this.returnsgrid.Size = new System.Drawing.Size(1751, 400);
            this.returnsgrid.TabIndex = 106;
            this.returnsgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.returnsgrid_CellClick);
            // 
            // Sales_Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 785);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.returnsgrid);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboquantitytype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combostore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combocategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboclient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientinvoicedate);
            this.Name = "Sales_Returns";
            this.Text = "Sales_Returns";
            this.Load += new System.EventHandler(this.Sales_Returns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txttotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinvoicedate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnsgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboquantitytype;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadTextBox txttotal;
        private Telerik.WinControls.UI.RadButton btncalc;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadTextBox txtprice;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combostore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboclient;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker clientinvoicedate;
        private Telerik.WinControls.UI.RadButton btndelet;
        private Telerik.WinControls.UI.RadButton btnadd;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
        private System.Windows.Forms.DataGridView returnsgrid;
    }
}