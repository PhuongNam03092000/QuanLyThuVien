using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IChiTietPhieuNhapRepository : IEFRepository<ChiTietPhieuNhap>
    {
        IEnumerable<ChiTietPhieuNhap> CTPNs(int maPN);
        ChiTietPhieuNhap GetBy(int maPN, int maSach);
    }
}
