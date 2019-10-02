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
    public partial class CreateCustomerForm : Form
    {
        private readonly CustomerBUS _customerBUS;
        public CreateCustomerForm()
        {
            _customerBUS = new CustomerBUS();
            InitializeComponent();
        }

        private void CreateCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSaveCustomer_Click(object sender, EventArgs e)
        {
            var isValidName = ValidateCustomerName();
            var isValidMobile = ValidateCustomerMobile();
            var isValidAddress = ValidateAddressLine1();
            var isValidCity = ValidateCityName();
            var isValidState = ValidateStateName();
            var isValidCountry = ValidateCountryName();

            if (isValidName && isValidMobile && isValidAddress && isValidCity && isValidState && isValidCountry)
            {
                var customer = new CreateCustomerDto
                {
                    Code = null,
                    Name = txtCustomerName.Text,
                    Mobile = txtCustomerMobile.Text,
                    Telephone = txtCustomerTelephone.Text,
                    AddressLine1 = txtAddressLine1.Text,
                    AddressLine2 = txtAddressLine2.Text,
                    City = txtCityName.Text,
                    State = txtStateName.Text,
                    Country = txtCountryName.Text
                };

                if (_customerBUS.SaveCustomer(customer))
                {
                    MessageBox.Show("Customer details saved successfully");
                    ClearFormInputs();
                    this.Hide();
                    ManageCustomerForm manageCustomerForm = new ManageCustomerForm();
                    
                }
                else
                {
                    MessageBox.Show("Details not saved");
                }
            }
            else
            {
                MessageBox.Show("Please enter required details");
            }
        }

        private void BtnResetCustomer_Click(object sender, EventArgs e)
        {
            ClearFormInputs();
        }

        private void TxtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            ValidateCustomerName();
        }

        private void TxtCustomerMobile_Validating(object sender, CancelEventArgs e)
        {
            ValidateCustomerMobile();
        }

        private void TxtAddressLine1_Validating(object sender, CancelEventArgs e)
        {
            ValidateAddressLine1();
        }

        private void TxtCityName_Validating(object sender, CancelEventArgs e)
        {
            ValidateCityName();
        }

        private void TxtStateName_Validating(object sender, CancelEventArgs e)
        {
            ValidateStateName();
        }

        private void TxtCountryName_Validating(object sender, CancelEventArgs e)
        {
            ValidateCountryName();
        }

        public bool ValidateCustomerName()
        {
            var flag = true;

            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                epCustomerName.SetError(txtCustomerName, "Customer name is required");
                flag = false;
            }
            else
            {
                epCustomerName.SetError(txtCustomerName, null);
                flag = true;
            }
            return flag;
        }

        public bool ValidateCustomerMobile()
        {
            var flag = true;

            if (string.IsNullOrEmpty(txtCustomerMobile.Text))
            {
                epMobileNumber.SetError(txtCustomerMobile, "Mobile number is required");
                flag = false;
            }
            else
            {
                epMobileNumber.SetError(txtCustomerMobile, null);
                flag = true;
            }
            return flag;
        }

        public bool ValidateAddressLine1()
        {
            var flag = true;

            if (string.IsNullOrEmpty(txtAddressLine1.Text))
            {
                epAddressLine1.SetError(txtAddressLine1, "Address Line 1 can not be blank");
                flag = false;
            }
            else
            {
                epAddressLine1.SetError(txtAddressLine1, null);
                flag = true;
            }
            return flag;
        }

        public bool ValidateCityName()
        {
            var flag = true;

            if (string.IsNullOrEmpty(txtCityName.Text))
            {
                epCityName.SetError(txtCityName, "City name is required");
                flag = false;
            }
            else
            {
                epCityName.SetError(txtCityName, null);
                flag = true;
            }
            return flag;
        }

        public bool ValidateStateName()
        {
            var flag = true;

            if (string.IsNullOrEmpty(txtStateName.Text))
            {
                epStateName.SetError(txtStateName, "State name is required");
                flag = false;
            }
            else
            {
                epStateName.SetError(txtStateName, null);
                flag = true;
            }
            return flag;
        }

        public bool ValidateCountryName()
        {
            var flag = true;

            if (string.IsNullOrEmpty(txtCountryName.Text))
            {
                epCountryName.SetError(txtCountryName, "Country name is required");
                flag = false;
            }
            else
            {
                epCountryName.SetError(txtCountryName, null);
                flag = true;
            }
            return flag;
        }

        public void ClearFormInputs()
        {
            txtCustomerName.Text = "";
            txtCustomerMobile.Text = "";
            txtCustomerTelephone.Text = "";
            txtAddressLine1.Text = "";
            txtAddressLine2.Text = "";
            txtCityName.Text = "";
            txtStateName.Text = "";
            txtCountryName.Text = "";
        }
        
    }
}
