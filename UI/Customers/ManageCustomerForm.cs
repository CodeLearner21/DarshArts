using DarshArts.BLL;
using DarshArts.Models.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarshArts.UI.Customers
{
    public partial class ManageCustomerForm : Form
    {
        private readonly CustomerBUS _customerBUS;
        
        public ManageCustomerForm()
        {
            _customerBUS = new CustomerBUS();
            InitializeComponent();
        }

        private void ManageCustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers(null);
        }

        private void TxtCustomerSearchKeyword_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(txtCustomerSearchKeyword.Text);
        }

        private void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomerForm createCustomerForm = new CreateCustomerForm();            
            createCustomerForm.Show();
        }

        private void LoadCustomers(string searchKeyword = null)
        {
            var customers = _customerBUS.GetAllCustomers();
            if(customers != null)
            {
                if (!string.IsNullOrWhiteSpace(searchKeyword))
                {
                    customers = customers.Where(c => c.Name.Contains(searchKeyword) || c.Code.Contains(searchKeyword) || c.City.Contains(searchKeyword)).ToList();
                    lblCustomerCount.Text = string.Format("{0} Customers found matching to your search {1}", customers.Count(), searchKeyword);

                    if (customers.Count() > 0)
                        lblCustomerCount.ForeColor = Color.Black;
                    else
                        lblCustomerCount.ForeColor = Color.Red;
                }
                else
                {
                    lblCustomerCount.Text = string.Format("Total Customers: {0}", customers.Count());
                    if (customers.Count() < 1)
                        lblCustomerCount.ForeColor = Color.Red;
                }                  
                dgvCustomersList.DataSource = customers;
                dgvCustomersList.Columns.Add(CreateDetailLinkColumn());
                
            }
            else
            {
                lblCustomerCount.ForeColor = Color.Red;
                lblCustomerCount.Text = "No Customer Found";
            }
        }

        private DataGridViewLinkColumn CreateDetailLinkColumn()
        {
            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.DataPropertyName = "linkDetailForm";
            linkColumn.Text = "View Details";
            linkColumn.UseColumnTextForLinkValue = true;

            return linkColumn;
        }

        private void DgvCustomersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedColumn = dgvCustomersList.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
            var customerCode = dgvCustomersList.CurrentRow.Cells[0].Value.ToString();
            if (clickedColumn == "View Details")
            {
                UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm();
                updateCustomerForm.LoadCustomerInForm(customerCode);
                updateCustomerForm.Show();
            }
        }
    }
}
