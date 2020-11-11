using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class PhieuTraConfiguration : IEntityTypeConfiguration<PhieuTra>
    {
        public void Configure(EntityTypeBuilder<PhieuTra> builder)
        {
            builder.ToTable("PhieuTra");
            builder.HasKey(pt => pt.MaPT);
            builder.HasOne(dg => dg.DocGia).WithMany(pt => pt.PhieuTras).HasForeignKey(dg => dg.MaDG);
            builder.Property(pt => pt.NgayTra).HasColumnType("Date");
            builder.Property(pt => pt.TongPhiTra);
            builder.HasOne(us => us.AppUser).WithMany(pt => pt.PhieuTras).HasForeignKey(us => us.UserId);
        }
    }
}