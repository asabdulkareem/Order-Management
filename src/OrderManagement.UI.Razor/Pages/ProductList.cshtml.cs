using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderManagement.Repository;
using OrderManagement.UI.Razor.ViewModels;
using System.Linq;

namespace OrderManagement.UI.Razor.Pages
{
    public class ProductModel : PageModel
    {
        private readonly IProdcuctRepository _prodcuctRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ProductListViewModel ProductListViewModel { get; set; }
        public string URl { get; set; }
        public ProductModel(IProdcuctRepository prodcuctRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _prodcuctRepository = prodcuctRepository;
            ProductListViewModel = new();
        }
        public void OnGet(string category)
        {            
            string currentCategory;
            URl = HttpContext.Request.GetEncodedUrl();
            URl = URl.Remove(URl.LastIndexOf("/"));
            
            if (string.IsNullOrEmpty(category))
            {
                ProductListViewModel.Products = _prodcuctRepository.GetAllProducts();
                currentCategory = "All Products";
            }
            else
            {
                ProductListViewModel.Products = _prodcuctRepository.GetAllProducts().Where(x => x.Category.CategoryName == category)?.OrderBy(p => p.ProductId).ToList();
                currentCategory = _categoryRepository.GetAllCategories().FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            ProductListViewModel.CurrentCategory = currentCategory;
            Page();
        }
    }
}
