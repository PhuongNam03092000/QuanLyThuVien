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
        public DbSet<DauSach> DSDauSach { get; set; }
        public DbSet<TheLoai> DSTheLoai { get; set; }
        public DbSet<TacGia> DSTacGia { get; set; }
        public DbSet<NhaXuatBan> DSNhaXuatBan { get; set; }
        public DbSet<Sach> DSSach { get; set; }
        public DbSet<DocGia> DSDocGia { get; set; }
        public DbSet<NhaCungCap> DSNhaCungCap { get; set; }
        public DbSet<PhieuNhap> DSPhieuNhap { get; set; }
        public DbSet<ChiTietPhieuNhap> DSChiTietPhieuNhap { get; set; }
        public DbSet<PhieuMuon> DSPhieuMuon { get; set;}
        public DbSet<ChiTietPhieuMuon> DSChiTietPhieuMuon { get; set;}
        public DbSet<PhieuTra> DSPhieuTra { get; set;}
        public DbSet<ChiTietPhieuTra> DSChiTietPhieuTra { get; set;}
        public DbSet<PhieuPhat> DSPhieuPhat { get; set;}
        public DbSet<ChiTietPhieuPhat> DSChiTietPhieuPhat { get; set;}
    }
}