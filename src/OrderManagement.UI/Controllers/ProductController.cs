using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.UI.Models;
using OrderManagement.UI.ViewModels;
using System.IO;
using System.Reflection;

namespace OrderManagement.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProdcuctRepository _prodcuctRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProdcuctRepository prodcuctRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _prodcuctRepository = prodcuctRepository;
        }
        public ViewResult List()
        {
            string Url = HttpContext.Request.GetEncodedUrl();
            //Url = Path.Combine(Url, @"..\\..\\");
            Url = Url.Remove(Url.LastIndexOf("/"));
            ViewBag.Url = Url.Remove(Url.LastIndexOf("/"));
            ViewBag.Title = "List Page";            
            ProductListViewModel productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _prodcuctRepository.GetAllProducts();
            productListViewModel.CurrentCategory = "Grocery";
            return View(productListViewModel);
        }
        public IActionResult Details(int id)
        {
            var product = _prodcuctRepository.GetProductById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}
