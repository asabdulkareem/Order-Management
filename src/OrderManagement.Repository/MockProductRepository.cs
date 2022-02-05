using OrderManagement.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.Repository
{
    public class MockProductRepository : IProdcuctRepository
    {
        readonly List<Product> _products;
        public MockProductRepository()
        {
            _products = new List<Product>()
            {
                new Product() { ProductId = 1, Name = "Colgate Strong Teeth", Price = 235, ShortDescription="500 Grams", ImageUrl="/Images/AvlLogo.png" },
                new Product() { ProductId = 2, Name = "Maggi Masala Noodles", Price = 138, ShortDescription="Maggi Masala Noodles - Pack of 12", ImageUrl="/Images/AvlLogo.png", IsProductOfTheWeek = true}
            };
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.Where(x => x.ProductId == id).FirstOrDefault();
        }


        public List<Product> GetProductOfTheWeek()
        {
            return _products.Where(x => x.IsProductOfTheWeek == true).ToList();
        }
    }
}
