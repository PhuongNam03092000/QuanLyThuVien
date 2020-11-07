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
            builder.HasKey(ctpn => new {ctpn.MaPN, ctpn.MaSach});
            builder.HasOne(pn => pn.PhieuNhap).WithMany(ctpn => ctpn.ChiTietPhieuNhaps).HasForeignKey(pn => pn.MaPN);
            builder.Property(ctpn => ctpn.SoLuongNhap);
            builder.Property(ctpn => ctpn.DonGiaSach);
        }
    }
}