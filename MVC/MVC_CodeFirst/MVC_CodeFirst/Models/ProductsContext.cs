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
        public DbSet<Sales> Sale { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //map the products entity to a procedure
        //    modelBuilder.Entity<Products>().MapToStoredProcedures(p=>p.Insert(pr=>
        //    pr.HasName("product_Insert").Parameter(pm=>pm.Name,"pname").Parameter(pm=>
        //    pm.Price,"price").Parameter(pm=>pm.Qty,"qty"))
        //    );
        //}
    }
}