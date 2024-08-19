using Core_EF_DB.Models;

namespace Core_EF_DB.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
       // dynamic GetProductSupplier();
    }
}
