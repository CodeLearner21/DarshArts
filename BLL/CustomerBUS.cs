using DarshArts.DAL;
using DarshArts.Models.Customers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarshArts.BLL
{
    public class CustomerBUS
    {
        private readonly CustomerDAO _customerDAO;
        public CustomerBUS()
        {
            _customerDAO = new CustomerDAO();
        }

        public IEnumerable<CustomerListDto> GetAllCustomers()
        {
            var customers = _customerDAO.GetAll().AsEnumerable()
                .Select(row => new CustomerListDto
                {
                    Id = row.Field<int>(0),
                    Code = row.Field<string>(1),
                    Name = row.Field<string>(2),
                    Mobile = row.Field<string>(3),
                    Telephone = row.Field<string>(4),
                    AddressLine1 = row.Field<string>(5),
                    AddressLine2 = row.Field<string>(6),
                    City = row.Field<string>(7),
                    State = row.Field<string>(8),
                    Country = row.Field<string>(9)
                }).ToList();

            if (customers != null)
                return customers;

            return null;
        }

        public bool SaveCustomer(CreateCustomerDto createCustomer)
        {
            if (string.IsNullOrWhiteSpace(createCustomer.Code))
            {
                var custCode = "";
                do
                {
                    Random generator = new Random();
                    string range = generator.Next(0, 999999).ToString("D6");
                    custCode = "DA" + range;
                }
                while ((_customerDAO.GetByCode(custCode) != null || _customerDAO.GetByCode(custCode).Rows.Count > 0) 
                && string.IsNullOrWhiteSpace(custCode));

                createCustomer.Code = custCode;
            }

            return _customerDAO.Create(createCustomer.Code,
                    createCustomer.Name,
                    createCustomer.Mobile,
                    createCustomer.Telephone,
                    createCustomer.AddressLine1,
                    createCustomer.AddressLine2,
                    createCustomer.City,
                    createCustomer.State,
                    createCustomer.Country);
        }
    }
}
