using Application.Interfaces;
using Application.Services;
using Domain.Repositories;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddDbContext<QLTVContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ThuVienDB")));

            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
            services.AddScoped<ISachRepository, SachRepository>();
            services.AddScoped<ISachService, SachService>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{controller=Sach}/{action=Index}/{id?}"
                );
            });
        }
    }
}