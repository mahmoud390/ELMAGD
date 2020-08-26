namespace Elmagd
{
    partial class Full_Production
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
            this.fullproductiongrid = new System.Windows.Forms.DataGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btndelet = new Telerik.WinControls.UI.RadButton();
            this.Temfullproductiongrid = new System.Windows.Forms.DataGridView();
            this.btnadd = new Telerik.WinControls.UI.RadButton();
            this.label12 = new System.Windows.Forms.Label();
            this.comboquantitytype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantity = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.btnsave = new Telerik.WinControls.UI.RadButton();
            this.label4 = new System.Windows.Forms.Label();
            this.combostore = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnotes = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fullproductiongrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Temfullproductiongrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).BeginInit();
            this.SuspendLayout();
            // 
            // fullproductiongrid
            // 
            this.fullproductiongrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullproductiongrid.Location = new System.Drawing.Point(7, 114);
            this.fullproductiongrid.Name = "fullproductiongrid";
            this.fullproductiongrid.RowTemplate.Height = 24;
            this.fullproductiongrid.Size = new System.Drawing.Size(914, 850);
            this.fullproductiongrid.TabIndex = 91;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.txtnotes);
            this.radGroupBox1.Controls.Add(this.btndelet);
            this.radGroupBox1.Controls.Add(this.Temfullproductiongrid);
            this.radGroupBox1.Controls.Add(this.btnadd);
            this.radGroupBox1.Controls.Add(this.label12);
            this.radGroupBox1.Controls.Add(this.comboquantitytype);
            this.radGroupBox1.Controls.Add(this.label5);
            this.radGroupBox1.Controls.Add(this.txtquantity);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.combocategory);
            this.radGroupBox1.HeaderText = "الاصناف الناتجه من عملية الانتاج";
            this.radGroupBox1.Location = new System.Drawing.Point(927, 108);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1100, 855);
            this.radGroupBox1.TabIndex = 94;
            this.radGroupBox1.Text = "الاصناف الناتجه من عملية الانتاج";
            // 
            // btndelet
            // 
            this.btndelet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(51)))), ((int)(((byte)(22)))));
            this.btndelet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelet.ForeColor = System.Drawing.Color.Black;
            this.btndelet.Location = new System.Drawing.Point(386, 221);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(154, 42);
            this.btndelet.TabIndex = 87;
            this.btndelet.Text = "حذف";
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // Temfullproductiongrid
            // 
            this.Temfullproductiongrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Temfullproductiongrid.Location = new System.Drawing.Point(48, 271);
            this.Temfullproductiongrid.Name = "Temfullproductiongrid";
            this.Temfullproductiongrid.RowTemplate.Height = 24;
            this.Temfullproductiongrid.Size = new System.Drawing.Size(1000, 560);
            this.Temfullproductiongrid.TabIndex = 70;
            this.Temfullproductiongrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Temfullproductiongrid_CellClick);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(199)))), ((int)(((byte)(14)))));
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(677, 221);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(160, 42);
            this.btnadd.TabIndex = 69;
            this.btnadd.Text = "إضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(498, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 68;
            this.label12.Text = "نوع الكمية";
            // 
            // comboquantitytype
            // 
            this.comboquantitytype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboquantitytype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboquantitytype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboquantitytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboquantitytype.FormattingEnabled = true;
            this.comboquantitytype.Location = new System.Drawing.Point(48, 35);
            this.comboquantitytype.Name = "comboquantitytype";
            this.comboquantitytype.Size = new System.Drawing.Size(429, 28);
            this.comboquantitytype.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(922, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 59;
            this.label5.Text = "الكميه";
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtquantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtquantity.Location = new System.Drawing.Point(624, 139);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(239, 28);
            this.txtquantity.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(897, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "الصنف";
            // 
            // combocategory
            // 
            this.combocategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combocategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combocategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combocategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Location = new System.Drawing.Point(620, 35);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(241, 28);
            this.combocategory.TabIndex = 54;
            // 
            // btnsave
            // 
            this.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(201)))), ((int)(((byte)(38)))));
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(561, 70);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(179, 38);
            this.btnsave.TabIndex = 88;
            this.btnsave.Text = "حفظ";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1697, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 93;
            this.label4.Text = "المخزن";
            // 
            // combostore
            // 
            this.combostore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combostore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combostore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combostore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combostore.FormattingEnabled = true;
            this.combostore.Location = new System.Drawing.Point(1195, 72);
            this.combostore.Name = "combostore";
            this.combostore.Size = new System.Drawing.Size(455, 28);
            this.combostore.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(487, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 96;
            this.label9.Text = "بحث";
            // 
            // txtSarch
            // 
            this.txtSarch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSarch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSarch.Location = new System.Drawing.Point(-5, 66);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(469, 32);
            this.txtSarch.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1664, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 98;
            this.label2.Text = "تاريخ الإنتهاء";
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "dd-MM-yyyy";
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(1195, 12);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(453, 32);
            this.dateEnd.TabIndex = 97;
            this.dateEnd.TabStop = false;
            this.dateEnd.Text = "30-06-2020";
            this.dateEnd.Value = new System.DateTime(2020, 6, 30, 14, 41, 31, 882);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "ملاحظات";
            // 
            // txtnotes
            // 
            this.txtnotes.AutoSize = false;
            this.txtnotes.Location = new System.Drawing.Point(46, 82);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnotes.Size = new System.Drawing.Size(431, 127);
            this.txtnotes.TabIndex = 100;
            // 
            // Full_Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1765, 773);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.fullproductiongrid);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combostore);
            this.Name = "Full_Production";
            this.Text = "الإنتاج التام";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Full_Production_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fullproductiongrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btndelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Temfullproductiongrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fullproductiongrid;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnsave;
        private Telerik.WinControls.UI.RadButton btndelet;
        private System.Windows.Forms.DataGridView Temfullproductiongrid;
        private Telerik.WinControls.UI.RadButton btnadd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboquantitytype;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combostore;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDateTimePicker dateEnd;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtnotes;
    }
}