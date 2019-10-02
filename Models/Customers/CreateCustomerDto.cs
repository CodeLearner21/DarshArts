using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarshArts.Models.Customers
{
    public class CreateCustomerDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
