using AutoGlassMarket.Content;
using AutoGlassMarket.Interface;
using AutoGlassMarket.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGlassMarket
{
    public class Startup
    {

        private IConfigurationRoot _connectionString;

        public Startup(IHostEnvironment hostEnv)
        {
            _connectionString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbSettings.json").Build();
        }




        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDBContext>(options => options.UseSqlServer(_connectionString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllBrands, CarBrandRepository>();
            services.AddTransient<IAllGlasses, GlassesRepository>();
            services.AddTransient<IBuyers, BuyersRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();



           // services.AddScoped(sp => ShopCart.GetCart(sp));



            services.AddMvc( 
            );


            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();



            /*
              using (var scop = app.ApplicationServices.CreateScope())
              {
                  AppDBContext context = scop.ServiceProvider.GetRequiredService<AppDBContext>();
                  DBobjects.Initial(context);
              }  
            */
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "CategoryFilter",
                    pattern:"{controller}/{action}/{Brand?}/{Mdoel?}");


            });
        }
    }
}
