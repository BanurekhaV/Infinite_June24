using System.ComponentModel.DataAnnotations;

namespace Core_EF_DB.ViewModel
{
    public class ProductSupplier
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
        public decimal UnitPrice { get; set; }
        public string CompanyName { get; set; } 

    }
}
