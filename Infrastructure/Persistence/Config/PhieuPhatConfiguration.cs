using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class PhieuPhatConfiguration : IEntityTypeConfiguration<PhieuPhat>
    {
        public void Configure(EntityTypeBuilder<PhieuPhat> builder)
        {
            builder.ToTable("PhieuPhat");
            builder.HasKey(pp => pp.MaPP);
            builder.Property(pp => pp.MaPP).HasMaxLength(10).IsUnicode(false);
            builder.HasOne(dg => dg.DocGia).WithMany(pt => pt.DSPhieuPhat).HasForeignKey(dg => dg.MaDG);
            builder.Property(pp => pp.TongPhiPhat);
            builder.HasOne(us => us.AppUser).WithMany(pp => pp.DSPhieuPhat).HasForeignKey(us => us.UserId);
        }
    }
}