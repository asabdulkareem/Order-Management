using OrderManagement.Domain.Models;
using System.Collections.Generic;

namespace OrderManagement.UI.Razor.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
