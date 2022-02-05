using Microsoft.AspNetCore.Mvc;
using OrderManagement.Repository;
using OrderManagement.UI.ViewModels;

namespace OrderManagement.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdcuctRepository _productRepository;

        public HomeController(IProdcuctRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductOfTheWeek = _productRepository.GetProductOfTheWeek()
            };
            return View(homeViewModel);
        }
    }
}
