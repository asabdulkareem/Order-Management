using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OrderManagement.Domain.Models;
using OrderManagement.Repository;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.UI.Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProdcuctRepository _productRepository;
        private readonly ILogger<IndexModel> _logger;
        public List<Product> ProductOfTheWeek { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IProdcuctRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        public void OnGet()
        {
            ProductOfTheWeek = _productRepository.GetAllProducts().Where(x => x.IsProductOfTheWeek == true).ToList();
        }
    }
}
