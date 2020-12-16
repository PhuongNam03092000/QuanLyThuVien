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
    public class PhieuMuonService : IPhieuMuonService
    {
        private readonly IPhieuMuonRepository phieumuonRepository; //Lấy từ Domain
        private readonly IChiTietPhieuMuonRepository chiTietPhieuMuonRepository;
        private readonly ISachRepository sachRepository;

        public PhieuMuonService(IPhieuMuonRepository phieuMuonRepository, IChiTietPhieuMuonRepository chiTietPhieuMuonRepository, ISachRepository sachRepository)
        {
            this.phieumuonRepository = phieuMuonRepository;
            this.chiTietPhieuMuonRepository = chiTietPhieuMuonRepository;
            this.sachRepository = sachRepository;
        }

        public void AddCTPM(ChiTietPhieuMuonDTO ctpmDTO)
        {
            var ctpm = ctpmDTO.MappingCTPM();
            var sach = sachRepository.GetBy(ctpmDTO.MaSach);
            sach.TrangThaiSach = "Đã mượn";
            sachRepository.Update(sach);
            var pm = phieumuonRepository.GetBy(ctpm.MaPM);
            ctpm.PhiMuon = (int)(sach.GiaBia * 0.2);
            pm.TongPhiMuon = pm.TongPhiMuon + ctpm.PhiMuon;
            phieumuonRepository.Update(pm);
            chiTietPhieuMuonRepository.Add(ctpm);
        }

        public void DeleteCTPM(IEnumerable<ChiTietPhieuMuonDTO> ctpmDTOList)
        {
            var list = ctpmDTOList.Where(c => c.IsSelected == true);
            var pm = phieumuonRepository.GetBy(ctpmDTOList.FirstOrDefault().MaPM);
            list.ToList().ForEach(c =>
            {
                var ctpm = chiTietPhieuMuonRepository.GetBy(c.MaPM, c.MaSach);
                var sach = sachRepository.GetBy(c.MaSach);
                sach.TrangThaiSach = "Còn";
                sachRepository.Update(sach);
                pm.TongPhiMuon -= ctpm.PhiMuon;
                chiTietPhieuMuonRepository.Delete(ctpm);
            });
            phieumuonRepository.Update(pm);
            /*var ctpm = chiTietPhieuMuonRepository.GetBy(c.MaPM, c.MaSach);
            chiTietPhieuMuonRepository.Delete(ctpm);*/

        }

        public void UpdateCTPM(ChiTietPhieuMuonDTO ctpmDTO)
        {
            var ctpm = chiTietPhieuMuonRepository.GetBy(ctpmDTO.MaPM, ctpmDTO.MaSach);
            ctpmDTO.MappingCTPM(ctpm);
            chiTietPhieuMuonRepository.Update(ctpm);
        }

        public void CreatePhieuMuon(PhieuMuonDTO phieumuonDTO)
        {
            var phieumuon = phieumuonDTO.MappingPhieuMuon();
            phieumuon.TrangThai = 1;
            phieumuonRepository.Add(phieumuon);
        }
        public void UpdatePhieuMuon(PhieuMuonDTO phieumuonDTO)
        {
            var phieumuon = phieumuonRepository.GetBy(phieumuonDTO.MaPM);
            phieumuon.TrangThai = 0;
            phieumuonRepository.Update(phieumuon);
        }

        public void DeletePhieuMuon(int maPM)
        {
            var phieumuon = phieumuonRepository.GetBy(maPM);
            phieumuonRepository.Delete(phieumuon);
        }

        public PhieuMuonDTO GetPhieuMuon(int maPM)
        {
            var phieumuon = phieumuonRepository.GetBy(maPM);
            var ctpms = chiTietPhieuMuonRepository.CTPMs(phieumuon.MaPM);
            if (ctpms.Any())
            {
                phieumuon.ChiTietPhieuMuons = (List<ChiTietPhieuMuon>)ctpms;
            }

            return phieumuon.MappingDTO();
        }

        public IEnumerable<PhieuMuonDTO> GetPhieuMuons(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var phieuMuons = phieumuonRepository.Filter(sortOrder, searchString, pageIndex, pageSize, out count);
            foreach(PhieuMuon pm in phieuMuons)
            {
                var ctpms = chiTietPhieuMuonRepository.CTPMs(pm.MaPM);
                if(ctpms.Any())
                {
                    pm.ChiTietPhieuMuons = (List<ChiTietPhieuMuon>)ctpms;
                }
            }
            return phieuMuons.MappingDtos();
        }
    }
}
