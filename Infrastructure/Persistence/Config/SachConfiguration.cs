using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Config
{
    public class SachConfiguration : IEntityTypeConfiguration<Sach>
    {
        public void Configure(EntityTypeBuilder<Sach> builder)
        {
            builder.Property(s => s.TenSach).HasMaxLength(100).IsRequired();
            builder.Property(s => s.TheLoai).HasMaxLength(50).IsRequired();
            builder.Property(s => s.TacGia).HasMaxLength(50).IsRequired();
            builder.Property(s => s.NhaXuatBan).HasMaxLength(50).IsRequired();
            builder.Property(s => s.ViTri).HasMaxLength(50).IsRequired();
            builder.Property(s => s.GiaBia).IsRequired();
        }
    }
}