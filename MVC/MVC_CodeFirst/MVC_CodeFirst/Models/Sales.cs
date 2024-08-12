using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst.Models
{
    public class Sales
    {
        [Key]
        public int SaleId { get; set; }
        public DateTime dtofSale { get; set; }
        public int QtySold { get; set; }
        public double ToTalampunt { get; set; }
        public ICollection<Products> Product { get; set; }
    }
}