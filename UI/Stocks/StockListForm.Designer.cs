namespace DarshArts.UI.Stocks
{
    partial class StockListForm
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
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.lblStockListLoader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockList
            // 
            this.dgvStockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.Location = new System.Drawing.Point(24, 70);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.Size = new System.Drawing.Size(240, 150);
            this.dgvStockList.TabIndex = 0;
            // 
            // lblStockListLoader
            // 
            this.lblStockListLoader.AutoSize = true;
            this.lblStockListLoader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockListLoader.Location = new System.Drawing.Point(332, 218);
            this.lblStockListLoader.Name = "lblStockListLoader";
            this.lblStockListLoader.Size = new System.Drawing.Size(127, 16);
            this.lblStockListLoader.TabIndex = 1;
            this.lblStockListLoader.Text = "Loading Stocks...";
            this.lblStockListLoader.Visible = false;
            // 
            // StockListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStockListLoader);
            this.Controls.Add(this.dgvStockList);
            this.Name = "StockListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.Label lblStockListLoader;
    }
}