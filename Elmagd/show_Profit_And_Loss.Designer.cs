namespace Elmagd
{
    partial class show_Profit_And_Loss
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
            this.profit_nd_lossgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.profit_nd_lossgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // profit_nd_lossgrid
            // 
            this.profit_nd_lossgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profit_nd_lossgrid.Location = new System.Drawing.Point(12, 67);
            this.profit_nd_lossgrid.Name = "profit_nd_lossgrid";
            this.profit_nd_lossgrid.RowTemplate.Height = 24;
            this.profit_nd_lossgrid.Size = new System.Drawing.Size(1771, 699);
            this.profit_nd_lossgrid.TabIndex = 0;
            // 
            // show_Profit_And_Loss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 778);
            this.Controls.Add(this.profit_nd_lossgrid);
            this.Name = "show_Profit_And_Loss";
            this.Text = "show_Profit_And_Loss";
            this.Load += new System.EventHandler(this.show_Profit_And_Loss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profit_nd_lossgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView profit_nd_lossgrid;
    }
}