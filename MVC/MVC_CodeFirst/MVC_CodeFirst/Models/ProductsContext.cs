using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_CodeFirst.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext():base("connectstr")
        { }

        public DbSet<Products> Product { get; set; }


    }
}