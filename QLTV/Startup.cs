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
using System.Data;
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
                // Tạo các Router để rút gọn - làm đẹp URL 
                //URL Trang chủ
                endpoints.MapControllerRoute(
                    name:"trangchu",
                    pattern:"/QuanLyThuVien",
                    defaults: new { area = "Admin", Controller = "Home", Action = "index" }
                    );
                //URL Quản lý sách
                endpoints.MapControllerRoute(
                    name:"sach",
                    pattern:"/QuanLySach",
                    defaults: new { area = "Admin", Controller = "Sach", Action = "Index" }
                    );
                //URL quản lý tài khoản
                endpoints.MapControllerRoute(
                    name:"nhanvien",
                    pattern: "/QuanLyNhanVien",
                    defaults:new { area = "Admin", Controller = "NV", Action = "Index" }
                    );
                //URL quản lý đầu sách
                endpoints.MapControllerRoute(
                    name: "dausach",
                    pattern: "/QuanLyDauSach",
                    defaults: new { area = "Admin", Controller = "DauSach", Action = "Index" }
                    );
                //URL quản lý nhà cc
                endpoints.MapControllerRoute(
                    name: "nhacungcap",
                    pattern: "/QuanLyNhaCC",
                    defaults: new { area = "Admin", Controller = "NCC_", Action = "Index" }
                    );
                //URL Nhập sách
                endpoints.MapControllerRoute(
                    name: "nhapsach",
                    pattern: "/NhapSach",
                    defaults: new { area = "Admin", Controller = "NhapSach", Action = "Index" }
                    );
                //URL thống kê 
                endpoints.MapControllerRoute(
                    name: "thongke",
                    pattern: "/ThongKe",
                    defaults: new { area = "Admin", Controller = "ThongKe", Action = "Index" }
                    );
                //URL nhân viên
                endpoints.MapControllerRoute(
                    name: "taikhoan",
                    pattern: "/QuanLyTaiKhoan",
                    defaults: new { area = "Admin", Controller = "TaiKhoan", Action = "Index" }
                    );
                //URL quản lý độc giả
                endpoints.MapControllerRoute(
                    name: "docgia",
                    pattern: "/QuanLyDocGia",
                    defaults: new { area = "Admin", Controller = "DocGia", Action = "Index" }
                    );
                endpoints.MapControllerRoute(
                    name: "xuly",
                    pattern: "/XuLy",
                    defaults: new { area = "Admin", Controller = "XuLy", Action = "Index" }
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
