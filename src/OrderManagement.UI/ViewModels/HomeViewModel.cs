using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderManagement.UI.Models;

namespace OrderManagement.UI.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductOfTheWeek { get; set; }
    }
}
