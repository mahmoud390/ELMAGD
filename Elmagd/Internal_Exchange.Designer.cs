namespace Elmagd
{
    partial class Internal_Exchange
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.exchangedate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.combostore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combotostore = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboQtyTypeFrom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantity = new Telerik.WinControls.UI.RadTextBox();
            this.exchangegrid = new System.Windows.Forms.DataGridView();
            this.btnadd1 = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSarch = new Telerik.WinControls.UI.RadTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboQtyTypeTo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.exchangedate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1518, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 70;
            this.label1.Text = "التاريخ";
            // 
            // exchangedate
            // 
            this.exchangedate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exchangedate.CustomFormat = "dd-MM-yyyy";
            this.exchangedate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exchangedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.exchangedate.Location = new System.Drawing.Point(1234, 32);
            this.exchangedate.Name = "exchangedate";
            this.exchangedate.Size = new System.Drawing.Size(220, 28);
            this.exchangedate.TabIndex = 69;
            this.exchangedate.TabStop = false;
            this.exchangedate.Text = "23-06-2020";
            this.exchangedate.Value = new System.DateTime(2020, 6, 23, 15, 39, 18, 479);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1046, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 76;
            this.label4.Text = "المخزن المنقول منه";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // combostore
            // 
            this.combostore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combostore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combostore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combostore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combostore.FormattingEnabled = true;
            this.combostore.Location = new System.Drawing.Point(699, 36);
            this.combostore.Name = "combostore";
            this.combostore.Size = new System.Drawing.Size(307, 28);
            this.combostore.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 78;
            this.label2.Text = "المخزن المنقول الية";
            // 
            // combotostore
            // 
            this.combotostore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combotostore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combotostore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combotostore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotostore.FormattingEnabled = true;
            this.combotostore.Location = new System.Drawing.Point(145, 29);
            this.combotostore.Name = "combotostore";
            this.combotostore.Size = new System.Drawing.Size(359, 28);
            this.combotostore.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(859, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 24);
            this.label12.TabIndex = 90;
            this.label12.Text = "نوع الكمية(من)";
            // 
            // comboQtyTypeFrom
            // 
            this.comboQtyTypeFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboQtyTypeFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboQtyTypeFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboQtyTypeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboQtyTypeFrom.FormattingEnabled = true;
            this.comboQtyTypeFrom.Location = new System.Drawing.Point(706, 138);
            this.comboQtyTypeFrom.Name = "comboQtyTypeFrom";
            this.comboQtyTypeFrom.Size = new System.Drawing.Size(138, 28);
            this.comboQtyTypeFrom.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 88;
            this.label5.Text = "الكميه";
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtquantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtquantity.Location = new System.Drawing.Point(474, 134);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(153, 28);
            this.txtquantity.TabIndex = 87;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // exchangegrid
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangegrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.exchangegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exchangegrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exchangegrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.exchangegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exchangegrid.Location = new System.Drawing.Point(10, 319);
            this.exchangegrid.Name = "exchangegrid";
            this.exchangegrid.RowTemplate.Height = 24;
            this.exchangegrid.Size = new System.Drawing.Size(1768, 650);
            this.exchangegrid.TabIndex = 91;
            this.exchangegrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exchangegrid_CellClick);
            // 
            // btnadd1
            // 
            this.btnadd1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(199)))), ((int)(((byte)(14)))));
            this.btnadd1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd1.ForeColor = System.Drawing.Color.Black;
            this.btnadd1.Location = new System.Drawing.Point(844, 209);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(151, 43);
            this.btnadd1.TabIndex = 92;
            this.btnadd1.Text = "إضافة / إسترجاع";
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1515, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 94;
            this.label3.Text = "الصنف";
            // 
            // combocategory
            // 
            this.combocategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combocategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combocategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combocategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Location = new System.Drawing.Point(990, 135);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(464, 28);
            this.combocategory.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1195, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 24);
            this.label9.TabIndex = 96;
            this.label9.Text = "بحث";
            // 
            // txtSarch
            // 
            this.txtSarch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSarch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSarch.Location = new System.Drawing.Point(644, 279);
            this.txtSarch.Name = "txtSarch";
            this.txtSarch.Size = new System.Drawing.Size(527, 32);
            this.txtSarch.TabIndex = 95;
            this.txtSarch.TextChanged += new System.EventHandler(this.txtSarch_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 98;
            this.label6.Text = "نوع الكمية (إلى)";
            // 
            // comboQtyTypeTo
            // 
            this.comboQtyTypeTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboQtyTypeTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboQtyTypeTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboQtyTypeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboQtyTypeTo.FormattingEnabled = true;
            this.comboQtyTypeTo.Location = new System.Drawing.Point(139, 138);
            this.comboQtyTypeTo.Name = "comboQtyTypeTo";
            this.comboQtyTypeTo.Size = new System.Drawing.Size(138, 28);
            this.comboQtyTypeTo.TabIndex = 97;
            // 
            // Internal_Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1583, 773);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboQtyTypeTo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSarch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combocategory);
            this.Controls.Add(this.btnadd1);
            this.Controls.Add(this.exchangegrid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboQtyTypeFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combotostore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combostore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exchangedate);
            this.Name = "Internal_Exchange";
            this.Text = "الصرف الداخلي";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Internal_Exchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exchangedate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker exchangedate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combostore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combotostore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboQtyTypeFrom;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtquantity;
        private System.Windows.Forms.DataGridView exchangegrid;
        private Telerik.WinControls.UI.RadButton btnadd1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadTextBox txtSarch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboQtyTypeTo;
    }
}