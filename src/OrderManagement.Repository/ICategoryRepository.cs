using OrderManagement.Domain.Models;
using System.Collections.Generic;

namespace OrderManagement.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
    }
}
