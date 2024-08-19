using Core_EF_DB.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_EF_DB.Repository
{
    public class CategoryService :ICategoryRepository
    {
        private readonly NorthwindContext _Context;

        public CategoryService(NorthwindContext context)
        {
            _Context = context;
        }

        public async Task<List<Category>> GetCategory()
        {
            return await _Context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            Category category = await _Context.Categories.FindAsync(id);
            return category;
        }

      

    }
}
