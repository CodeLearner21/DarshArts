using DarshArts.DAL;
using DarshArts.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarshArts.BLL
{
    public class UserBUS
    {
        private readonly UserDAO _userDAO;
        public UserBUS()
        {
            _userDAO = new UserDAO();
        }

        public bool Login(UserLogin userLogin)
        {
            var result = _userDAO.GetUserByUsernamePassword(userLogin.Username, userLogin.Password);
            if (result.Rows.Count > 0 && result != null)
                return true;

            return false;
        }
    }
}
