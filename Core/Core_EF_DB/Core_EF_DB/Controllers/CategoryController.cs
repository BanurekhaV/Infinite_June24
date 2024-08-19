using Microsoft.AspNetCore.Mvc;
using Core_EF_DB.Models;
using Core_EF_DB.Repository;

namespace Core_EF_DB.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;   

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> GetAllCategories()
        {
            List<Category> categories = await _categoryRepository.GetCategory();
            return View(categories);
        }

        public async Task<IActionResult> GetCategoryByID(int id)
        {
            Category cat = await _categoryRepository.GetCategoryById(id);
            if (cat != null)
            {
                return View(cat);
            }
            else return View(null);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
