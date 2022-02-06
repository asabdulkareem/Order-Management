using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Repository;
using OrderManagement.UI.ViewModels;
using System.Linq;

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
        public ViewResult List(string category)
        {
            string currentCategory;

            string Url = HttpContext.Request.GetEncodedUrl();
            //Url = Path.Combine(Url, @"..\\..\\");
            Url = Url.Remove(Url.LastIndexOf("/"));
            ViewBag.Url = Url.Remove(Url.LastIndexOf("/"));
            ViewBag.Title = "List Page";            
            ProductListViewModel productListViewModel = new();
            if(string.IsNullOrEmpty(category))
            {
                productListViewModel.Products = _prodcuctRepository.GetAllProducts();
                currentCategory = "All Products";
            }
            else
            {
                productListViewModel.Products = _prodcuctRepository.GetAllProducts().Where(x => x.Category.CategoryName == category)?.OrderBy(p => p.ProductId).ToList();
                currentCategory = _categoryRepository.GetAllCategories().FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            productListViewModel.CurrentCategory = currentCategory;
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
