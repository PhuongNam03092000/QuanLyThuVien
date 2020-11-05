using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class TheLoaiConfiguration : IEntityTypeConfiguration<TheLoai>
    {
        public void Configure(EntityTypeBuilder<TheLoai> builder)
        {
            builder.ToTable("TheLoai");
            builder.HasKey(tl => tl.MaTL);
            builder.Property(tl => tl.MaTL).HasMaxLength(10).IsUnicode(false);
            builder.Property(tl => tl.TenTL).HasMaxLength(50).IsRequired();       
        }
    }
}