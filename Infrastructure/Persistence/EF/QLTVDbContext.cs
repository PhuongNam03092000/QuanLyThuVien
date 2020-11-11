using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace Infrastructure.Persistence
{
    //chuyển từ DbContext sang IdentityDbContext, dùng cho Authentication và Authorization
    public class QLTVDbContext : IdentityDbContext<AppUser,AppRole,Guid>//TUser, TRole, TKey
    {
        public QLTVDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //apply tất cả mà không phải thêm từng cái config

            builder.Seed();
        }
        //Dùng để làm Infrastruture/Persistence/Config

        //Lấy từ Domain/Entities
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public DbSet<PhieuMuon> PhieuMuons { get; set;}
        public DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set;}
        public DbSet<PhieuTra> PhieuTras { get; set;}
        public DbSet<ChiTietPhieuTra> ChiTietPhieuTras { get; set;}
        public DbSet<PhieuPhat> PhieuPhats { get; set;}
        public DbSet<ChiTietPhieuPhat> ChiTietPhieuPhats { get; set;}
        public DbSet<SachImage> SachImages { get; set; }
    }
}