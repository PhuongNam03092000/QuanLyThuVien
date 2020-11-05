using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class PhieuMuonConfiguration : IEntityTypeConfiguration<PhieuMuon>
    {
        public void Configure(EntityTypeBuilder<PhieuMuon> builder)
        {
            builder.ToTable("PhieuMuon");
            builder.HasKey(pm => pm.MaPM);
            builder.Property(pm => pm.MaPM).HasMaxLength(10).IsUnicode(false);
            builder.HasOne(dg => dg.DocGia).WithMany(pm => pm.DSPhieuMuon).HasForeignKey(dg => dg.MaDG);
            builder.Property(pm => pm.NgayMuon).HasColumnType("Date");
            builder.Property(pm => pm.TongPhiMuon);
            builder.HasOne(us => us.AppUser).WithMany(pm => pm.DSPhieuMuon).HasForeignKey(us => us.UserId);
        }
    }
}