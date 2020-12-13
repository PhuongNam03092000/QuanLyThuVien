using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class PhieuNhapService : IPhieuNhapService
    {
        private readonly IPhieuNhapRepository phieunhapRepository; 
        private readonly IChiTietPhieuNhapRepository chiTietPhieuNhapRepository;
        private readonly ISachRepository sachRepository;

        public PhieuNhapService(IPhieuNhapRepository phieuNhapRepository, IChiTietPhieuNhapRepository chiTietPhieuNhapRepository, ISachRepository sachRepository)
        {
            this.phieunhapRepository = phieuNhapRepository;
            this.chiTietPhieuNhapRepository = chiTietPhieuNhapRepository;
            this.sachRepository = sachRepository;
        }

        public void AddCTPN(ChiTietPhieuNhapDTO ctpnDTO)
        {
            var ctpn = ctpnDTO.MappingCTPN();

            for(int i = 0; i<ctpnDTO.SoLuongNhap; i++)
            {
                var sach = sachRepository.GetBy(ctpnDTO.MaSach);
                var sachNew = new SachDTO
                {
                    TenSach = sach.TenSach,
                    GiaBia = sach.GiaBia,
                    MaTG = sach.MaTG,
                    MaNXB = sach.MaNXB,
                    MaTL = sach.MaTL
                };
            }
            chiTietPhieuNhapRepository.Add(ctpn);
        }

        public void DeleteCTPN(IEnumerable<ChiTietPhieuNhapDTO> ctpnDTOList)
        {
            var list = ctpnDTOList.Where(c => c.IsSelected == true);

            list.ToList().ForEach(c =>
            {
                var ctpn = chiTietPhieuNhapRepository.GetBy(c.MaPN, c.MaSach);
                var sach = sachRepository.GetBy(c.MaSach);
                sach.TrangThaiSach = "Còn";
                sachRepository.Update(sach);
                chiTietPhieuNhapRepository.Delete(ctpn);
            });
        }

        public void UpdateCTPN(ChiTietPhieuNhapDTO ctpnDTO)
        {
            var ctpn = chiTietPhieuNhapRepository.GetBy(ctpnDTO.MaPN, ctpnDTO.MaSach);
            ctpnDTO.MappingCTPN(ctpn);
            chiTietPhieuNhapRepository.Update(ctpn);
        }

        public void CreatePhieuNhap(PhieuNhapDTO phieunhapDTO)
        {
            var phieunhap = phieunhapDTO.MappingPhieuNhap();
            phieunhapRepository.Add(phieunhap);
        }


        public void DeletePhieuNhap(int maPN)
        {
            var phieunhap = phieunhapRepository.GetBy(maPN);
            phieunhapRepository.Delete(phieunhap);
        }

        public PhieuNhapDTO GetPhieuNhap(int maPN)
        {
            var phieunhap = phieunhapRepository.GetBy(maPN);
            var ctpns = chiTietPhieuNhapRepository.CTPNs(phieunhap.MaPN);
            if (ctpns.Any())
            {
                phieunhap.ChiTietPhieuNhaps = (List<ChiTietPhieuNhap>)ctpns;
            }

            return phieunhap.MappingDTO();
        }

        public IEnumerable<PhieuNhapDTO> GetPhieuNhaps(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var phieuNhaps = phieunhapRepository.Filter(sortOrder, searchString, pageIndex, pageSize, out count);
            foreach (PhieuNhap pn in phieuNhaps)
            {
                var ctpns = chiTietPhieuNhapRepository.CTPNs(pn.MaPN);
                if (ctpns.Any())
                {
                    pn.ChiTietPhieuNhaps = (List<ChiTietPhieuNhap>)ctpns;
                }
            }
            return phieuNhaps.MappingDtos();
        }

        public void UpdatePhieuNhap(PhieuNhapDTO phieunhapDTO)
        {
            var phieunhap = phieunhapRepository.GetBy(phieunhapDTO.MaPN);
            phieunhapDTO.MappingPhieuNhap(phieunhap);
            phieunhapRepository.Update(phieunhap);
        }
    }
}
