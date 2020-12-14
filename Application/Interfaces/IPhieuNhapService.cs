using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IPhieuNhapService
    {
        IEnumerable<PhieuNhapDTO> GetPhieuNhaps(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);
        PhieuNhapDTO GetPhieuNhap(int maPN);
        void CreatePhieuNhap(PhieuNhapDTO phieunhap);
        void UpdatePhieuNhap(PhieuNhapDTO phieunhap);
        void DeletePhieuNhap(int maPN);
        void AddCTPN(ChiTietPhieuNhapDTO ctpnDTO);
        void UpdateCTPN(ChiTietPhieuNhapDTO ctpnDTO);
        void DeleteCTPN(IEnumerable<ChiTietPhieuNhapDTO> ctpnDTOList);
    }
}
