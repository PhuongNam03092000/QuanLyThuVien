using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Persistence.Repositories;

namespace ThuVien
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddIdentity<AppUser, AppRole>()
             .AddEntityFrameworkStores<QLTVContext>()
             .AddDefaultTokenProviders();

            services.AddDbContextPool<QLTVContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ThuVienDB")));

            //EF
            services.AddScoped(typeof(IEFRepository<>), typeof(EFRepository<>));

            //TheLoai
            services.AddScoped<ITheLoaiRepository, TheLoaiRepository>();
            services.AddScoped<ITheLoaiService, TheLoaiService>();

            //Account
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountService, AccountService>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                //chỉnh sửa lại quy tắc tạo mật khẩu của Identity
            });

            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = "/login";
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{area:exists}/{controller}/{action}/{id?}");

                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "Manager",
                    pattern: "Manager",
                    defaults: new { area = "Manager", Controller = "Home", Action = "Index" });
            });
        }
    }
}