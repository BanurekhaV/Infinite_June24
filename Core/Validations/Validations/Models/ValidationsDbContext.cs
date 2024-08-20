using Microsoft.EntityFrameworkCore;
using Validations.Models;
namespace Validations.Models
{
    public class ValidationsDbContext : DbContext
    {
        public ValidationsDbContext(DbContextOptions<ValidationsDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }  
        public DbSet<Validations.Models.RegisterViewModel> RegisterViewModel { get; set; } = default!;
    }
}
