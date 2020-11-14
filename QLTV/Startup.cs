using Domain.Entities;
using FluentValidation.AspNetCore;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;

namespace QLTV
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
            services.AddIdentity<AppUser, AppRole>()
             .AddEntityFrameworkStores<QLTVDbContext>()
             .AddDefaultTokenProviders();
            services.AddControllersWithViews().AddFluentValidation(fv => { fv.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()); });
            services.AddDbContextPool<QLTVDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("QuanLyThuVienDB")));
            services.AddRazorPages();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1",new OpenApiInfo { Title ="My API",Version="v1"});
            });

        } 

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{controller=Account}/{action=Index}/{id?}"

                );
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}");
            });
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
