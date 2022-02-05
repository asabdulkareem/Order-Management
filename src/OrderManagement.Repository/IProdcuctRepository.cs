using OrderManagement.Domain.Models;
using System.Collections.Generic;

namespace OrderManagement.Repository
{
    public interface IProdcuctRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetProductOfTheWeek();
        Product GetProductById(int id);
    }
}
