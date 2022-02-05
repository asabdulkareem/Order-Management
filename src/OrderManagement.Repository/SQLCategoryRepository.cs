using OrderManagement.Data.Models;
using OrderManagement.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.Repository
{
    public class SQLCategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public SQLCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Category> GetAllCategories()
        {
            return _appDbContext.Categories.ToList();
        }
    }
}
