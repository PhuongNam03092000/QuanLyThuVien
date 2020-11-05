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
            builder.Property(pt => pt.MaPT).HasMaxLength(10).IsUnicode(false);
            builder.HasOne(dg => dg.DocGia).WithMany(pt => pt.DSPhieuTra).HasForeignKey(dg => dg.MaDG);
            builder.Property(pt => pt.NgayTra).HasColumnType("Date");
            builder.Property(pt => pt.TongPhiTra);
            builder.HasOne(us => us.AppUser).WithMany(pt => pt.DSPhieuTra).HasForeignKey(us => us.UserId);
        }
    }
}