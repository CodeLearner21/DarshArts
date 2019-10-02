namespace DarshArts.UI.Customers
{
    partial class ManageCustomerForm
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
            this.grpBoxSearchCustomer = new System.Windows.Forms.GroupBox();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerSearchKeyword = new System.Windows.Forms.TextBox();
            this.dgvCustomersList = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerListDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.customerListDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpBoxSearchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxSearchCustomer
            // 
            this.grpBoxSearchCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSearchCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBoxSearchCustomer.Controls.Add(this.btnAddNewCustomer);
            this.grpBoxSearchCustomer.Controls.Add(this.label1);
            this.grpBoxSearchCustomer.Controls.Add(this.txtCustomerSearchKeyword);
            this.grpBoxSearchCustomer.Location = new System.Drawing.Point(12, 12);
            this.grpBoxSearchCustomer.Name = "grpBoxSearchCustomer";
            this.grpBoxSearchCustomer.Size = new System.Drawing.Size(776, 94);
            this.grpBoxSearchCustomer.TabIndex = 0;
            this.grpBoxSearchCustomer.TabStop = false;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNewCustomer.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(603, 24);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(154, 52);
            this.btnAddNewCustomer.TabIndex = 1;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.BtnAddNewCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by customer name, code or by city name";
            // 
            // txtCustomerSearchKeyword
            // 
            this.txtCustomerSearchKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSearchKeyword.Location = new System.Drawing.Point(14, 54);
            this.txtCustomerSearchKeyword.Name = "txtCustomerSearchKeyword";
            this.txtCustomerSearchKeyword.Size = new System.Drawing.Size(486, 22);
            this.txtCustomerSearchKeyword.TabIndex = 0;
            this.txtCustomerSearchKeyword.TextChanged += new System.EventHandler(this.TxtCustomerSearchKeyword_TextChanged);
            // 
            // dgvCustomersList
            // 
            this.dgvCustomersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomersList.AutoGenerateColumns = false;
            this.dgvCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.addressLine2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.dgvCustomersList.DataSource = this.customerListDtoBindingSource1;
            this.dgvCustomersList.Location = new System.Drawing.Point(12, 147);
            this.dgvCustomersList.Name = "dgvCustomersList";
            this.dgvCustomersList.Size = new System.Drawing.Size(776, 291);
            this.dgvCustomersList.TabIndex = 1;
            this.dgvCustomersList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomersList_CellDoubleClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            this.addressLine2DataGridViewTextBoxColumn.DataPropertyName = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.HeaderText = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // customerListDtoBindingSource1
            // 
            this.customerListDtoBindingSource1.DataSource = typeof(DarshArts.Models.Customers.CustomerListDto);
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCustomerCount.Location = new System.Drawing.Point(12, 117);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(153, 16);
            this.lblCustomerCount.TabIndex = 2;
            this.lblCustomerCount.Text = "Customers Loading...";
            // 
            // customerListDtoBindingSource
            // 
            this.customerListDtoBindingSource.DataSource = typeof(DarshArts.Models.Customers.CustomerListDto);
            // 
            // ManageCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCustomerCount);
            this.Controls.Add(this.dgvCustomersList);
            this.Controls.Add(this.grpBoxSearchCustomer);
            this.Name = "ManageCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Customers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageCustomerForm_Load);
            this.grpBoxSearchCustomer.ResumeLayout(false);
            this.grpBoxSearchCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSearchCustomer;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerSearchKeyword;
        private System.Windows.Forms.DataGridView dgvCustomersList;
        private System.Windows.Forms.BindingSource customerListDtoBindingSource;
        private System.Windows.Forms.BindingSource customerListDtoBindingSource1;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
    }
}