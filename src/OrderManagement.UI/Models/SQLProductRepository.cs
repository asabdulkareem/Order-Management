﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.UI.Models
{
    public class SQLProductRepository : IProdcuctRepository
    {
        private readonly AppDbContext _appDbContext;
        public SQLProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<Product> GetAllProducts()
        {
            return _appDbContext.Products.Include(c => c.Category).ToList();
        }

        public Product GetProductById(int id)
        {
            return _appDbContext.Products.Include(c => c.Category).FirstOrDefault(p => p.ProductId == id);  
        }

        public Product GetProductOfTheWeek()
        {
            return _appDbContext.Products.Include(c => c.Category).Where(p => p.IsProductOfTheWeek).FirstOrDefault();    
        }
    }
}