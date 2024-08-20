using Core_EF_DB.Models;
using Microsoft.EntityFrameworkCore;
using Core_EF_DB.Repository;

namespace Core_EF_DB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Fetch the connection string from Appsettings.json
            builder.Services.AddDbContext<NorthwindContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Northwinddbconn")));

            //DI Service Lifetime
            builder.Services.AddScoped<ICategoryRepository, CategoryService>();
            builder.Services.AddScoped<IProductRepository, ProductService>();
            builder.Services.AddScoped<IOrdersRepository, OrderService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
           

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
