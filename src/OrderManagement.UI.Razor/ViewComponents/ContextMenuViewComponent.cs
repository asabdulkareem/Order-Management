using Microsoft.AspNetCore.Mvc;
using OrderManagement.Repository;
using System.Linq;

namespace OrderManagement.UI.Razor.ViewComponents
{
    public class ContextMenuViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public ContextMenuViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAllCategories().OrderBy(c => c.CategoryName);
            return View(categories.ToList());
        }
    }
}
