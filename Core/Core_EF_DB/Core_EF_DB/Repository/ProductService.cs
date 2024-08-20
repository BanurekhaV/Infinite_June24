using Core_EF_DB.Models;
using Core_EF_DB.ViewModel;

namespace Core_EF_DB.Repository
{
    public class ProductService : IProductRepository
    {
        private readonly NorthwindContext _context;
        public ProductService(NorthwindContext context)
        {
            _context = context;
        }

       

        //get all products
        public async Task<List<Product>>GetProducts()
        {
            List<Product> products = new List<Product>();   
            return products;
        }

        //get the viewmodel object
        public dynamic GetProductSupplier()
        {
            dynamic Prdsuppdata = (from product in _context.Products
                                   join supplier in _context.Suppliers on
                                   product.SupplierId equals supplier.SupplierId
                                   select new {supplier.CompanyName, product.ProductId,
                                   product.ProductName, product.UnitPrice}).ToList();
            return Prdsuppdata;
        }
        
    }
}
