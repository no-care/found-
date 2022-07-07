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
using found.Data;
using Microsoft.EntityFrameworkCore.SqlServer;
using found.Data.Interfaces;
using found.Data.Rep;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Microsoft.OpenApi.Models;

namespace found
{
    public class Startup
    {
        private IConfigurationRoot _conf;

        public Startup(IWebHostEnvironment env)
        {
            _conf = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("DBSettings.json").Build();
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DBContent>(options => options.UseSqlServer(_conf.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllAdverts, AdvertRep>();
            services.AddTransient<IAllUsers, UserRep>();
            services.AddTransient<IAllDialogs, DialogsRep>();
            services.AddTransient<IAllMessages, MessagesRep>();
            services.AddMvc();
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            services.AddSession(options => 
            {
                options.Cookie.Name = ".MyApp.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
                options.Cookie.IsEssential = true;
            });
            services.AddHttpContextAccessor();

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
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Users}/{action=Login}/{id?}");
            });

        }
    }
}
