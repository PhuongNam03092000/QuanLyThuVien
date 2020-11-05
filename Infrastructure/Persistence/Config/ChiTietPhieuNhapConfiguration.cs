using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class ChiTietPhieuNhapConfiguration : IEntityTypeConfiguration<ChiTietPhieuNhap>
    {
        public void Configure(EntityTypeBuilder<ChiTietPhieuNhap> builder)
        {
            builder.ToTable("ChiTietPhieuNhap");
            builder.HasKey(ctpn => new {ctpn.MaPN, ctpn.MaDS});
            builder.HasOne(pn => pn.PhieuNhap).WithMany(ctpn => ctpn.DSChiTietPhieuNhap).HasForeignKey(pn => pn.MaPN);
            builder.HasOne(ds => ds.DauSach).WithMany(ctpn => ctpn.DSChiTietPhieuNhap).HasForeignKey(ds => ds.MaDS);
            builder.Property(ctpn => ctpn.SoLuongNhap);
            builder.Property(ctpn => ctpn.DonGiaSach);
        }
    }
}