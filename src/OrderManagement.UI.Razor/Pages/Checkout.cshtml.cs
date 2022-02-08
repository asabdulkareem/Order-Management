using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderManagement.Domain.Models;
using OrderManagement.Repository;

namespace OrderManagement.UI.Razor.Pages
{
    public class CheckoutModel : PageModel
    {
       
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        public Order Order { get; set; }

        public CheckoutModel(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }
        
        public void OnGet()
        {
        }
        public IActionResult OnPost(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some Products first");
            }
            _orderRepository.CreateOrder(order);
            _shoppingCart.ClearCart();
            return RedirectToAction("CheckoutComplete");
        }

        public IActionResult CheckoutComplete()
        {
            //ViewBag.CheckoutCompleteMessage = "Thanks for your order. You'll soon enjoy our delicious pies!";
            return RedirectToAction("OnGet");
        }
    }
}
