using Core_EF_DB.Models;

namespace Core_EF_DB.Repository
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategory();
        Task<Category> GetCategoryById(int id);
    }
}
