using Core_EF_DB.Models;

namespace Core_EF_DB.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
      

        //to get the viewmodel object bound to a view 

        dynamic GetProductSupplier();
    }
}
