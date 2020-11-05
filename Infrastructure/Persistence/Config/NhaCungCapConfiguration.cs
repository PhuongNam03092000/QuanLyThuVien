using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class NhaCungCapConfiguration : IEntityTypeConfiguration<NhaCungCap>
    {
        public void Configure(EntityTypeBuilder<NhaCungCap> builder)
        {
            builder.ToTable("NhaCungCap");
            builder.HasKey(ncc => ncc.MaNCC);
            builder.Property(ncc => ncc.MaNCC).HasMaxLength(10).IsUnicode(false);
            builder.Property(ncc => ncc.TenNCC).HasMaxLength(100).IsRequired();
            builder.Property(ncc => ncc.DiaChiNCC).HasMaxLength(100).IsRequired();
            builder.Property(ncc => ncc.SdtNCC).HasMaxLength(10).IsRequired();
        }
    }
}