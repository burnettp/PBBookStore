using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PBBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        //IDK why we need the configuration stuff, but it's used below when the connection string is established for the BookDBConnection
        public IConfiguration Configuration { get; set; }

        public Startup (IConfiguration temp)
        {
            Configuration = temp;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //This line allows us to make an MVC app
            services.AddControllersWithViews();

            //Sets up the connection string for BookDBConnection which is in Appsettings.json. Connects the database to our program.
            services.AddDbContext<BookstoreContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:BookDBConnection"]);
            });
            
            //Repository pattern setup
            services.AddScoped<IBookstoreRepository, EFBookstoreRepository>();
            services.AddScoped<IPurchaseRepository, EFPurchaseRepository>();

            services.AddRazorPages();

            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddScoped<Basket>(x => SessionBasket.GetBasket(x)); //Any time we are looking at a Basket, this line will call the GetBasket method which will either create a new one or use an existing one
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Tells the project to use the files in the wwwroot folder
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //Enpoints are executed in order, so if we did default first, the MapControllerRoute ep wouldn't work
                //You can also write endpoints in different ways. Below are two ways to write them

                //This endpoint cleans up URL when user passes book category and page number
                endpoints.MapControllerRoute("categorypage",
                    "{bookCategory}/Page{pageNum}",
                    new { Controller = "Home", action = "Index" });

                //This endpoint cleans up our URL and shows what we put on pattern in the URL instead of the parameters and ? etc
                endpoints.MapControllerRoute(
                    name: "Paging",
                    pattern: "Page{pageNum}",
                    defaults: new { Controller = "Home", action = "Index", pageNum = 1});

                //This endpoint cleans up the URL when we only get a category passed
                endpoints.MapControllerRoute("category",
                    "{bookCategory}",
                    new { Controller = "Home", action = "Index", pageNum = 1 });

                //This line sets the endpoint to be default, which is Controller -> Action -> ID
                endpoints.MapDefaultControllerRoute();

                //Enables razor pages
                endpoints.MapRazorPages();
            });
        }
    }
}
