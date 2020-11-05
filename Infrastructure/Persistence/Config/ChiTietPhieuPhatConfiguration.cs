using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class ChiTietPhieuPhatConfiguration : IEntityTypeConfiguration<ChiTietPhieuPhat>
    {
        public void Configure(EntityTypeBuilder<ChiTietPhieuPhat> builder)
        {
            builder.ToTable("ChiTietPhieuPhat");
            builder.HasKey(ctpp => new { ctpp.MaPP, ctpp.MaSach });
            builder.HasOne(pp => pp.PhieuPhat).WithMany(ctpp => ctpp.DSChiTietPhieuPhat).HasForeignKey(pp => pp.MaPP);
            builder.HasOne(s => s.Sach).WithMany(ctpp => ctpp.DSChiTietPhieuPhat).HasForeignKey(s => s.MaSach);
            builder.Property(pp => pp.NoiDungViPham).HasMaxLength(256).IsRequired();
            builder.Property(pp => pp.XuLyViPham).HasMaxLength(256).IsRequired();
            builder.Property(pp => pp.PhiPhat);
        }
    }
}