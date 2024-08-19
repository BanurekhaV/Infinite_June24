namespace CoreApp_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationOptions webApplicationOptions = new WebApplicationOptions
            {
                WebRootPath = "Mywebroot1",
                Args = args,
                EnvironmentName = "Staging",
            };
            var builder = WebApplication.CreateBuilder(webApplicationOptions);
            var app = builder.Build();
            //app.MapGet("/", () => "Worker Process name :" +
            //System.Diagnostics.Process.GetCurrentProcess().ProcessName);

            //string? MyKeyVal = builder.Configuration["MyKey"];
            //app.MapGet("/", () => $"{MyKeyVal}");
            // if(app.Environment.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }

            // app.UseRouting();

            //app.MapGet("/", () => "Hello World!");
            // app.MapGet("/Wish", () => "Hello this is a Wish from /Wish Endpoint");
            // app.MapGet("/Wish/{uname}", (string uname) => $"Hello, {uname}");

            //1. running an async task as a middleware
            //app.Run(async (context)=>
            //{
            //    await context.Response.WriteAsync("This is Response from First Middleware");
            //});

            //2. running async task as a method call
            //app.Run(FirstMiddleware

            // 3. chain of async middlewares
            //app.Use(async (context, next)=>
            //{
            //    await context.Response.WriteAsync("This is Response from First Middleware  " );
            //    await next();
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("This is Response from Second Middleware   ");
            //    await next();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("This is Response from last Middleware");

            //});

            //5. middleware for rendering static files
            app.UseStaticFiles();

            //4. WebapplicationOptions properties
            app.MapGet("/", () => $"enVironmentName : {app.Environment.EnvironmentName}\n" +
            $"Application name : {app.Environment.ApplicationName}\n " +
            $"ContentRootpath :{app.Environment.ContentRootPath}");
            app.Run();
        }

        public static async Task FirstMiddleware(HttpContext context)
        {
            await context.Response.WriteAsync("This is Response from First Middleware as a function call");
        }
    }
}
