using Domain.Entities;
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
            builder.Property(s => s.MaSach).HasMaxLength(10).IsUnicode(false);
            builder.HasOne(ds => ds.DauSach).WithMany(s => s.DSSach).HasForeignKey(ds => ds.MaDS);
            builder.Property(s => s.TrangThaiSach).HasDefaultValue(TrangThaiSach.Khong);
            builder.Property(s => s.ViTri).HasMaxLength(50).IsUnicode(false).IsRequired();
        }
    }
}