using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Storedproc_Prj.Models
{
    public class EDContext : DbContext
    {
        public EDContext() : base("name=edmodel") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        //public virtual IList<EmployeeDepartment>GetEmployeeDepartments()
        //{
        //    IList<EmployeeDepartment> eddetails = ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<EmployeeDepartment>
        //        ("GetEmployeeDepartment").ToList<EmployeeDepartment>();
        //    return eddetails;
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Employee>().MapToStoredProcedures(sp=>sp.Insert(s=>s.HasName("InsertEmployee","dbo"))
                                                                   .Update(s=>s.HasName("UpdateEmployee","dbo"))
                                                                   .Delete(s=>s.HasName("DeleteEmplaoyee","dbo")));
        }
    }
}