using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreMvc5_Pillars_Clone.Data;
using CoreMvc5_Pillars_Clone.Models;

namespace CoreMvc5_Pillars_Clone
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddSessionStateTempDataProvider();

            services.AddSession();

            services.AddDbContext<CoreMvc5_Pillars_CloneContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("CoreMvc5_Pillars_CloneContext")));
            services.AddDbContext<NorthwindContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("NorthwindContext")));
            
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

            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "women",
                    pattern: "Women",
                    defaults: new {controller="Lady",action="portal",});

                endpoints.MapControllerRoute(
                    name: "men",
                    pattern: "Men",
                    defaults: new { controller = "Sir", action = "entrypoint", });
            });
        }
    }
}
