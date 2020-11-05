using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(us => us.HoNV).HasMaxLength(50).IsRequired();
            builder.Property(us => us.TenNV).HasMaxLength(50).IsRequired();
            builder.Property(us => us.DoBNV).HasColumnType("Date");
            builder.Property(us => us.DiaChiNV).HasMaxLength(100).IsRequired();
        }
    }
}