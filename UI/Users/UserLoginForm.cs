using DarshArts.BLL;
using DarshArts.Models.Users;
using DarshArts.UI.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarshArts.UI.Users
{
    public partial class UserLoginForm : Form
    {
        private readonly UserBUS _userBUS;
        public UserLoginForm()
        {
            _userBUS = new UserBUS();
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var userLogin = new UserLogin { Username = txtUsername.Text, Password = txtPassword.Text };
                var result = _userBUS.Login(userLogin);
                if (result)
                {
                    this.Hide();
                    DashboardForm dashboard = new DashboardForm();
                    dashboard.FormClosed += (s, args) => this.Close();
                    dashboard.Show();
                }
                else
                    lblLoginMessage.Text = string.Format("Invalid Username or Password!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occur: {0}", ex.Message);
            }
        }

        private void GrpBoxLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
