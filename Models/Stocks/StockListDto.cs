using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarshArts.Models.Stocks
{
    public class StockListDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime LastUpdated { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal ProductUnitPrice { get; set; }
    }
}
