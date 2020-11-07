using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Config
{
    public class SachImageConfiguration : IEntityTypeConfiguration<SachImage>
    {
        public void Configure(EntityTypeBuilder<SachImage> builder)
        {
            builder.ToTable("SachImage");
            builder.HasKey(si => si.ImageId);
            builder.Property(si => si.ImagePath).HasMaxLength(256).IsRequired();
            builder.Property(si => si.ImageCaption).HasMaxLength(256);
            builder.HasOne(si => si.Sach).WithMany(si => si.SachImages).HasForeignKey(si => si.MaSach);
        }
    }
}
