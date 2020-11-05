using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class DocGiaConfiguration : IEntityTypeConfiguration<DocGia>
    {
        public void Configure(EntityTypeBuilder<DocGia> builder)
        {
            builder.ToTable("DocGia");
            builder.HasKey(dg => dg.MaDG);
            builder.Property(dg => dg.MaDG).HasMaxLength(10).IsUnicode(false);
            builder.Property(dg => dg.HoDG).HasMaxLength(50).IsUnicode().IsRequired();
            builder.Property(dg => dg.TenDG).HasMaxLength(50).IsUnicode().IsRequired();
            builder.Property(dg => dg.DoBDG).HasColumnType("Date");
            builder.Property(dg => dg.EmailDG).HasMaxLength(50).IsUnicode(false).IsRequired();
            builder.Property(dg => dg.DiaChiDG).HasMaxLength(100).IsUnicode().IsRequired();
            builder.Property(dg => dg.NgayDK).HasColumnType("Date");
            builder.Property(dg => dg.NgayHetHanDK).HasColumnType("Date");
            builder.Property(dg => dg.TrangThaiThe).HasDefaultValue(TrangThaiThe.DangHoatDong);
        }
    }
}