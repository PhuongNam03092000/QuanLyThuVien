using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class PhieuNhapConfiguration : IEntityTypeConfiguration<PhieuNhap>
    {
        public void Configure(EntityTypeBuilder<PhieuNhap> builder)
        {
            builder.ToTable("PhieuNhap");
            builder.HasKey(pn => pn.MaPN);
            builder.HasOne(ncc => ncc.NhaCungCap).WithMany(pn => pn.PhieuNhaps).HasForeignKey(ncc => ncc.MaNCC);
            builder.Property(pn => pn.NgayNhap).HasColumnType("Date");
            builder.Property(pn => pn.TongTienNhap);
            builder.HasOne(us => us.AppUser).WithMany(pn => pn.PhieuNhaps).HasForeignKey(us => us.UserId);
        }
    }
}