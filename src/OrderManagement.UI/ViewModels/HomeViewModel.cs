using System.Collections.Generic;
using OrderManagement.Domain.Models;

namespace OrderManagement.UI.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductOfTheWeek { get; set; }
    }
}
