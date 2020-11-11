using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class SachConfiguration : IEntityTypeConfiguration<Sach>
    {
        public void Configure(EntityTypeBuilder<Sach> builder)
        {
            builder.ToTable("Sach");
            builder.HasKey(s => s.MaSach);
            builder.Property(s => s.TenSach).HasMaxLength(100).IsRequired();
            builder.HasOne(tg => tg.TacGia).WithMany(s => s.Sachs).HasForeignKey(tg => tg.MaTG);
            builder.HasOne(tl => tl.TheLoai).WithMany(s => s.Sachs).HasForeignKey(tl => tl.MaTL);
            builder.HasOne(nxb => nxb.NhaXuatBan).WithMany(s => s.Sachs).HasForeignKey(nxb => nxb.MaNXB);            
            builder.Property(s => s.GiaBia);
            builder.Property(s => s.TrangThaiSach).HasDefaultValue(TrangThaiSach.Khong);
            builder.Property(s => s.ViTri).HasMaxLength(50).IsUnicode(false).IsRequired();
            builder.HasOne(ctpn => ctpn.ChiTietPhieuNhap).WithOne(s => s.Sach).HasForeignKey<ChiTietPhieuNhap>(ctpn => ctpn.MaPN);      
        }
    }
}