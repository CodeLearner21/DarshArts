using DarshArts.DAL;
using DarshArts.Models.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarshArts.BLL
{
    public class ProductBUS
    {
        private readonly ProductDAO _productDAO;
        public ProductBUS()
        {
            _productDAO = new ProductDAO();
        }

        public bool AddProduct(CreateProduct product)
        {
            if (product == null)
                return false;

            var result = _productDAO.AddProduct(product.Code, product.Name, product.UnitPrice);

            if (result)
                return result;

            return false;
        }

        public bool CheckExistingProduct(CreateProduct product)
        {
            if (product == null)
                return false;

            var result = _productDAO.GetByCodeOrName(product.Code, product.Name);
            if (result != null && result.Rows.Count > 0)
                return true;

            return false;
        }


        public IEnumerable<Product> GetAll()
        {
            return _productDAO.GetAllProducts().AsEnumerable()
                .Select(row => new Product
                {
                    Id = row.Field<int>(0),
                    Code = row.Field<string>(1),
                    Name = row.Field<string>(2),
                    UnitPrice = row.Field<decimal>(3)
                }).ToList();
        }


        public IEnumerable<ProductQuantity> GetProductsWithStock()
        {
            var list = _productDAO.GetAllProductsWithQuantity().AsEnumerable();

            return _productDAO.GetAllProductsWithQuantity().AsEnumerable()
                .Select(row => new ProductQuantity
                {
                    Id = row.Field<int>(0),
                    Code = row.Field<string>(1),
                    Name = row.Field<string>(2),
                    UnitPrice = row.Field<decimal>(3),
                    Quantity = (row.Field<int?>(4) != null) ? row.Field<int?>(4) : 0

                }).ToList();
        }
    }
}
