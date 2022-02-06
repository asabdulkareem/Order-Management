using Microsoft.AspNetCore.Mvc;
using OrderManagement.Repository;
using OrderManagement.UI.Razor.ViewModels;

namespace OrderManagement.UI.Razor.ViewComponents
{
    public class ShoppingCartSummaryViewComponents : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummaryViewComponents(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };
            return View(shoppingCartViewModel);
        }
    }
}
