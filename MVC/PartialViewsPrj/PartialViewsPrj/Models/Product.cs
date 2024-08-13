using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewsPrj.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

}