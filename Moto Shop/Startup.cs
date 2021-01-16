using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moto_Shop.Data;
using Moto_Shop.Data.Interfaces;
using Moto_Shop.Data.Mocks;
using Moto_Shop.Data.Models;
using Moto_Shop.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_Shop
{
    public class Startup
    {
        private IConfigurationRoot ConfigString;
        public Startup(IHostingEnvironment hosting)
        {
            ConfigString = new ConfigurationBuilder().SetBasePath(hosting.ContentRootPath).AddJsonFile("MotoDBSettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MotoDBContext>(option =>option.UseSqlServer(ConfigString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllProducts, MotoRepos>();
            services.AddTransient<IMotoModel, ModelRepos>();
            services.AddTransient<IAllOrders, OrderRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopBasket.GetBasket(sp));

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(rout =>
                {
                    rout.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                    rout.MapRoute(name: "modelFilter", template: "Moto/{action}/{model?}", defaults: new { Controller = "Moto", action = "List" });
                }
            );
            using (var scope = app.ApplicationServices.CreateScope())
            {
                MotoDBContext db = scope.ServiceProvider.GetRequiredService<MotoDBContext>();
                DBObjects.Initial(db);
            }
            
        }
    }
}
