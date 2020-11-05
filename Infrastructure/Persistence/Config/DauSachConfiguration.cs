using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class DauSachConfiguration : IEntityTypeConfiguration<DauSach>
    {
        public void Configure(EntityTypeBuilder<DauSach> builder)
        {
            builder.ToTable("DauSach");
            builder.HasKey(ds => ds.MaDS);
            builder.Property(ds => ds.MaDS).HasMaxLength(10).IsUnicode(false);
            builder.HasOne(tg => tg.TacGia).WithMany(ds => ds.DSDauSach).HasForeignKey(tg => tg.MaTG);
            builder.HasOne(tl => tl.TheLoai).WithMany(ds => ds.DSDauSach).HasForeignKey(tl => tl.MaTL);
            builder.HasOne(nxb => nxb.NhaXuatBan).WithMany(ds => ds.DSDauSach).HasForeignKey(nxb => nxb.MaNXB);
            builder.Property(ds => ds.TenDS).HasMaxLength(100).IsRequired();
            builder.Property(ds => ds.SoLuongDS);
        }
    }
}