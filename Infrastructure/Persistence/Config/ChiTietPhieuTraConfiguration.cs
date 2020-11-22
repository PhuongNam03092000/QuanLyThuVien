using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class ChiTietPhieuTraConfiguration : IEntityTypeConfiguration<ChiTietPhieuTra>
    {
        public void Configure(EntityTypeBuilder<ChiTietPhieuTra> builder)
        {
            builder.ToTable("ChiTietPhieuTra");
            builder.HasKey(ctpt => new { ctpt.MaPT, ctpt.MaSach });
            builder.HasOne(pt => pt.PhieuTra).WithMany(ctpt => ctpt.ChiTietPhieuTras).HasForeignKey(pt => pt.MaPT);
            builder.HasOne(s => s.Sach).WithMany(ctpt => ctpt.ChiTietPhieuTras).HasForeignKey(s => s.MaSach);
        }
    }
}