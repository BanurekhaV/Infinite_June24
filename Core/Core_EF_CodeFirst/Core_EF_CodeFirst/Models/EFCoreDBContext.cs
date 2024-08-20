using Microsoft.EntityFrameworkCore;

namespace Core_EF_CodeFirst.Models
{
    public class EFCoreDBContext : DbContext
    {
        public EFCoreDBContext(DbContextOptions<EFCoreDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        //add the model class objects
        public DbSet<Employee> Employees { get; set; }
        public  DbSet<Department> Departments { get; set; }
    }
}
