using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderManagement.Domain.Models;
using OrderManagement.Repository;

namespace OrderManagement.UI.Razor.Pages
{
    public class ProductDetailsModel : PageModel
    {
        private readonly IProductRepository _prodcuctRepository;
        private readonly ICategoryRepository _categoryRepository;
        public Product Product { get; set; }

        public ProductDetailsModel(IProductRepository prodcuctRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _prodcuctRepository = prodcuctRepository;
        }
        public IActionResult OnGet(int productId)
        {
            Product = _prodcuctRepository.GetProductById(productId);
            if (Product == null)
            {
                return RedirectToPage("Error");
            }
            return Page();
        }
    }
}
