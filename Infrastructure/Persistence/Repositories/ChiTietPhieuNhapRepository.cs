using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Persistence.Repositories
{
    public class ChiTietPhieuNhapRepository : EFRepository<ChiTietPhieuNhap>, IChiTietPhieuNhapRepository
    {
        public ChiTietPhieuNhapRepository(QLTVContext context) : base(context)
        {

        }

        public IEnumerable<ChiTietPhieuNhap> CTPNs(int maPN)
        {
            var query = context.ChiTietPhieuNhaps.AsQueryable();

            if (!(maPN == 0))
            {
                query = query.Where(ctpn => ctpn.MaPN == maPN);
            }

            return query.ToList();
        }


        public ChiTietPhieuNhap GetBy(int maPN, int maSach)
        {
            return context.Set<ChiTietPhieuNhap>().Find(maPN, maSach);
        }
    }
}
