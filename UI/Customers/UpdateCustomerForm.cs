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
    public partial class UpdateCustomerForm : Form
    {
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {

        }

        public void LoadCustomerInForm(string userCode = null)
        {
            MessageBox.Show("Details for customer = " + userCode);
        }
    }
}
