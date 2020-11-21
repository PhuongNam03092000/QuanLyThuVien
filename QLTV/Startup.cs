﻿using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Domain.Repositories;
using FluentValidation.AspNetCore;
using Infrastructure.Persistence;
using Infrastructure.Persistence.EF;
using Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Application.Services;
using Application.Interfaces;
using Domain.Repositories;
using Infrastructure.Persistence.Repositories;
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
            // add scope của sách
            services.AddScoped<ISachService, SachService>();
            services.AddScoped<ISachRepository, SachRepository>();

            //==========================================================================================//
            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
            //==========================================================================================//
            services.AddScoped<IDocGiaRepository, DocGiaRepository>();
            services.AddScoped<IDocGiaService, DocGiaService>();
            //==========================================================================================//
            //==========================================================================================//
            //==========================================================================================//
            //==========================================================================================//
            //==========================================================================================//
            //==========================================================================================//

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
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}");
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
                    defaults: new { area = "Admin", Controller = "PhieuMuon", Action = "Index" }
                    );
                //URL quản lý tài khoản
                endpoints.MapControllerRoute(
                    name:"taikhoan",
                    pattern: "/QuanLyTaiKhoan",
                    defaults:new { area = "Admin", Controller = "Home", Action = "Index" }
                    );
                //URL quản lý đầu sách
                endpoints.MapControllerRoute(
                    name: "dausach",
                    pattern: "/QuanLyDauSach",
                    defaults: new { area = "Admin", Controller = "Home", Action = "Index" }
                    );
                //URL quản lý nhà cc
                endpoints.MapControllerRoute(
                    name: "nhacungcap",
                    pattern: "/QuanLyNhaCC",
                    defaults: new { area = "Admin", Controller = "Home", Action = "Index" }
                    );
                //URL Nhập sách
                endpoints.MapControllerRoute(
                    name: "nhapsach",
                    pattern: "/NhapSach",
                    defaults: new { area = "Admin", Controller = "Home", Action = "Index" }
                    );
                //URL thống kê 
                endpoints.MapControllerRoute(
                    name: "thongke",
                    pattern: "/ThongKe",
                    defaults: new { area = "Admin", Controller = "Home", Action = "Index" }
                    );
                //URL nhân viên
                endpoints.MapControllerRoute(
                    name: "nhanvien",
                    pattern: "/QuanLyNhanVien",
                    defaults: new { area = "Admin", Controller = "Home", Action = "Index" }
                    );
                //URL quản lý độc giả
                endpoints.MapControllerRoute(
                    name: "docgia",
                    pattern: "/QuanLyDocGia",
                    defaults: new { area = "Admin", Controller = "DocGia", Action = "Index" }
                    );
                
            });
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
