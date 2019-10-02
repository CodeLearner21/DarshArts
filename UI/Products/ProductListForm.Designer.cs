namespace DarshArts.UI.Products
{
    partial class ProductListForm
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
            this.dgvAllProductList = new System.Windows.Forms.DataGridView();
            this.groupBoxSearchParam = new System.Windows.Forms.GroupBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProductList)).BeginInit();
            this.groupBoxSearchParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllProductList
            // 
            this.dgvAllProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProductList.Location = new System.Drawing.Point(0, 121);
            this.dgvAllProductList.Name = "dgvAllProductList";
            this.dgvAllProductList.Size = new System.Drawing.Size(802, 328);
            this.dgvAllProductList.TabIndex = 0;
            // 
            // groupBoxSearchParam
            // 
            this.groupBoxSearchParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxSearchParam.Controls.Add(this.txtSearchProduct);
            this.groupBoxSearchParam.Controls.Add(this.label1);
            this.groupBoxSearchParam.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearchParam.Name = "groupBoxSearchParam";
            this.groupBoxSearchParam.Size = new System.Drawing.Size(776, 103);
            this.groupBoxSearchParam.TabIndex = 1;
            this.groupBoxSearchParam.TabStop = false;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(25, 58);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(729, 22);
            this.txtSearchProduct.TabIndex = 2;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.TxtSearchProduct_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter product name or product code to search";
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSearchParam);
            this.Controls.Add(this.dgvAllProductList);
            this.Name = "ProductListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProductList)).EndInit();
            this.groupBoxSearchParam.ResumeLayout(false);
            this.groupBoxSearchParam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllProductList;
        private System.Windows.Forms.GroupBox groupBoxSearchParam;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label label1;
    }
}