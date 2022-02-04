using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderManagement.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.UI
{
    public class Startup
    {
        private readonly IConfiguration _config;
        // Here we are using Dependency Injection to inject the Configuration object
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container. used for Registering Services
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(_config.GetConnectionString("SQLDB")));
            services.AddControllersWithViews();
            //services.AddScoped<IProdcuctRepository, MockProductRepository>();
            services.AddScoped<IProdcuctRepository, SQLProductRepository>();
            //services.AddScoped<ICategoryRepository, MockCategoryRepository>();
            services.AddScoped<ICategoryRepository, SQLCategoryRepository>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddHttpContextAccessor();
            services.AddSession();

            //services.AddSingleton
            //services.AddTransient
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("MiddleWare1: Incomming Request\n");
            //    await next();
            //    await context.Response.WriteAsync("MiddleWare1: Outcomming Request\n");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("MiddleWare2: Incomming Request\n");
            //    await next();
            //    await context.Response.WriteAsync("MiddleWare2: Outcomming Request\n");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("MiddleWare3: Incomming Request\n");
            //    await next();
            //    await context.Response.WriteAsync("MiddleWare3: Outcomming Request\n");
            //});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=Index}/{id?}");
                /*    The MapGet method is going to handle the GET HTTP Requests whereas the Map method is going to handle all types of HTTP requests such as GET, POST, PUT, & DELETE, etc.
                      endpoints.Map("/", async context => */
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World! = " + System.Diagnostics.Process.GetCurrentProcess().ProcessName + "\n" + _config.GetConnectionString("SQLDB"));
                //});
            });
        }
    }
}
