namespace DarshArts.UI.Stocks
{
    partial class CreateStockForm
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
            this.components = new System.ComponentModel.Container();
            this.grpBoxCreateStock = new System.Windows.Forms.GroupBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveStock = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epStockProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.epStockQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockListDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpBoxCreateStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStockProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStockQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockListDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxCreateStock
            // 
            this.grpBoxCreateStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBoxCreateStock.Controls.Add(this.cbProduct);
            this.grpBoxCreateStock.Controls.Add(this.btnSaveStock);
            this.grpBoxCreateStock.Controls.Add(this.txtQuantity);
            this.grpBoxCreateStock.Controls.Add(this.label2);
            this.grpBoxCreateStock.Controls.Add(this.label1);
            this.grpBoxCreateStock.Location = new System.Drawing.Point(0, -7);
            this.grpBoxCreateStock.Name = "grpBoxCreateStock";
            this.grpBoxCreateStock.Size = new System.Drawing.Size(401, 460);
            this.grpBoxCreateStock.TabIndex = 0;
            this.grpBoxCreateStock.TabStop = false;
            // 
            // cbProduct
            // 
            this.cbProduct.BackColor = System.Drawing.Color.OldLace;
            this.cbProduct.DataSource = this.productBindingSource;
            this.cbProduct.DisplayMember = "Name";
            this.cbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(154, 85);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(206, 24);
            this.cbProduct.TabIndex = 5;
            this.cbProduct.ValueMember = "Id";
            this.cbProduct.SelectionChangeCommitted += new System.EventHandler(this.CbProduct_SelectionChangeCommitted);
            this.cbProduct.Validating += new System.ComponentModel.CancelEventHandler(this.CbProduct_Validating);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DarshArts.Models.Products.Product);
            // 
            // btnSaveStock
            // 
            this.btnSaveStock.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStock.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStock.ForeColor = System.Drawing.Color.White;
            this.btnSaveStock.Location = new System.Drawing.Point(154, 209);
            this.btnSaveStock.Name = "btnSaveStock";
            this.btnSaveStock.Size = new System.Drawing.Size(91, 27);
            this.btnSaveStock.TabIndex = 4;
            this.btnSaveStock.Text = "&Save Stock";
            this.btnSaveStock.UseVisualStyleBackColor = false;
            this.btnSaveStock.Click += new System.EventHandler(this.BtnSaveStock_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.OldLace;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(154, 140);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(207, 22);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.TxtQuantity_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Product";
            // 
            // epStockProduct
            // 
            this.epStockProduct.ContainerControl = this;
            // 
            // epStockQuantity
            // 
            this.epStockQuantity.ContainerControl = this;
            // 
            // dgvStockList
            // 
            this.dgvStockList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStockList.AutoGenerateColumns = false;
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productUnitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn});
            this.dgvStockList.DataSource = this.stockListDtoBindingSource;
            this.dgvStockList.Location = new System.Drawing.Point(407, 8);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.Size = new System.Drawing.Size(389, 430);
            this.dgvStockList.TabIndex = 1;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productUnitPriceDataGridViewTextBoxColumn
            // 
            this.productUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductUnitPrice";
            this.productUnitPriceDataGridViewTextBoxColumn.HeaderText = "ProductUnitPrice";
            this.productUnitPriceDataGridViewTextBoxColumn.Name = "productUnitPriceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            // 
            // stockListDtoBindingSource
            // 
            this.stockListDtoBindingSource.DataSource = typeof(DarshArts.Models.Stocks.StockListDto);
            // 
            // CreateStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStockList);
            this.Controls.Add(this.grpBoxCreateStock);
            this.Name = "CreateStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateStockForm_Load);
            this.grpBoxCreateStock.ResumeLayout(false);
            this.grpBoxCreateStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStockProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStockQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockListDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCreateStock;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Button btnSaveStock;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epStockProduct;
        private System.Windows.Forms.ErrorProvider epStockQuantity;
        private System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockListDtoBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}