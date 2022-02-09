using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderManagement.Repository;
using OrderManagement.UI.Razor.ViewModels;
using System.Linq;

namespace OrderManagement.UI.Razor.Pages
{
    public class ShoppingCartPageModel : PageModel
    {
        private readonly IProductRepository _productRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartViewModel ShoppingCartViewModel { get; set; }

        public ShoppingCartPageModel(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult OnGet()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            ShoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return Page();
        }

        public RedirectToActionResult OnGetAddToShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.GetAllProducts().FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("OnGet");
        }

        public RedirectToActionResult OnGetRemoveFromShoppingCart(int productId)
        {
            var selectedPie = _productRepository.GetAllProducts().FirstOrDefault(p => p.ProductId == productId);

            if (selectedPie != null)
            {
                _shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("OnGet");
        }
        public RedirectToActionResult OnGetClearAllItems()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("OnGet");
        }
    }
}
