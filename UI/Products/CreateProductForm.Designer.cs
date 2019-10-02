namespace DarshArts.UI.Products
{
    partial class CreateProductForm
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
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetProduct = new System.Windows.Forms.Button();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.epProductCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.epProductName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epProductPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProductCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxProduct.AutoSize = true;
            this.groupBoxProduct.BackColor = System.Drawing.Color.White;
            this.groupBoxProduct.Controls.Add(this.btnProductSave);
            this.groupBoxProduct.Controls.Add(this.btnResetProduct);
            this.groupBoxProduct.Controls.Add(this.label4);
            this.groupBoxProduct.Controls.Add(this.txtProductUnitPrice);
            this.groupBoxProduct.Controls.Add(this.txtProductName);
            this.groupBoxProduct.Controls.Add(this.txtProductCode);
            this.groupBoxProduct.Controls.Add(this.label3);
            this.groupBoxProduct.Controls.Add(this.label2);
            this.groupBoxProduct.Controls.Add(this.label1);
            this.groupBoxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxProduct.Location = new System.Drawing.Point(33, 31);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(428, 385);
            this.groupBoxProduct.TabIndex = 0;
            this.groupBoxProduct.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(34, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(32, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit Price";
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.Color.OldLace;
            this.txtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.ForeColor = System.Drawing.Color.Black;
            this.txtProductCode.Location = new System.Drawing.Point(123, 106);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(234, 22);
            this.txtProductCode.TabIndex = 3;
            this.txtProductCode.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductCode_Validating);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.OldLace;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.Location = new System.Drawing.Point(123, 161);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(234, 22);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductName_Validating);
            // 
            // txtProductUnitPrice
            // 
            this.txtProductUnitPrice.BackColor = System.Drawing.Color.OldLace;
            this.txtProductUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.txtProductUnitPrice.Location = new System.Drawing.Point(123, 216);
            this.txtProductUnitPrice.Name = "txtProductUnitPrice";
            this.txtProductUnitPrice.Size = new System.Drawing.Size(234, 22);
            this.txtProductUnitPrice.TabIndex = 5;
            this.txtProductUnitPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductUnitPrice_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(118, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add New Product";
            // 
            // btnResetProduct
            // 
            this.btnResetProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResetProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnResetProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResetProduct.Location = new System.Drawing.Point(123, 298);
            this.btnResetProduct.Name = "btnResetProduct";
            this.btnResetProduct.Size = new System.Drawing.Size(75, 26);
            this.btnResetProduct.TabIndex = 1;
            this.btnResetProduct.Text = "&Reset";
            this.btnResetProduct.UseVisualStyleBackColor = false;
            this.btnResetProduct.Click += new System.EventHandler(this.BtnResetProduct_Click);
            // 
            // btnProductSave
            // 
            this.btnProductSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProductSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductSave.Location = new System.Drawing.Point(236, 298);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(75, 26);
            this.btnProductSave.TabIndex = 7;
            this.btnProductSave.Text = "&Save";
            this.btnProductSave.UseVisualStyleBackColor = false;
            this.btnProductSave.Click += new System.EventHandler(this.BtnProductSave_Click);
            // 
            // dgvProductList
            // 
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(467, 38);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(321, 378);
            this.dgvProductList.TabIndex = 1;
            // 
            // epProductCode
            // 
            this.epProductCode.ContainerControl = this;
            // 
            // epProductName
            // 
            this.epProductName.ContainerControl = this;
            // 
            // epProductPrice
            // 
            this.epProductPrice.ContainerControl = this;
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.groupBoxProduct);
            this.Name = "CreateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateProductForm_Load);
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProductCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductUnitPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btnResetProduct;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.ErrorProvider epProductCode;
        private System.Windows.Forms.ErrorProvider epProductName;
        private System.Windows.Forms.ErrorProvider epProductPrice;
    }
}