using System.Collections.Generic;

namespace OrderManagement.UI.Models
{
    public interface IProdcuctRepository
    {
        List<Product> GetAllProducts();
        Product GetProductOfTheWeek();
        Product GetProductById(int id);
    }
}
