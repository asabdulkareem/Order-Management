using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderManagement.Domain.Models;

namespace OrderManagement.UI.Razor.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Order Order { get; set; }
        public void OnGet()
        {
        }
    }
}
