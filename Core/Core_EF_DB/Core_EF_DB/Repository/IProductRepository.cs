using Core_EF_DB.Models;

namespace Core_EF_DB.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(int id);

        //to get the viewmodel object bound to a view 

        dynamic GetProductSupplier();
    }
}
