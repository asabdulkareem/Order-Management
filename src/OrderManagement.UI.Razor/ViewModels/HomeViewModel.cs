using System.Collections.Generic;
using OrderManagement.Domain.Models;

namespace OrderManagement.UI.Razor.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> ProductOfTheWeek { get; set; }
    }
}
