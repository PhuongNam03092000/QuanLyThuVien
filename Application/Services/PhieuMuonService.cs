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
        public PhieuMuonService(IPhieuMuonRepository phieuMuonRepository, IChiTietPhieuMuonRepository chiTietPhieuMuonRepository)
        {
            this.phieumuonRepository = phieuMuonRepository;
            this.chiTietPhieuMuonRepository = chiTietPhieuMuonRepository;
        }
        public void AddCTPM(ChiTietPhieuMuonDTO ctpm)
        {
            chiTietPhieuMuonRepository.Add(ctpm.MappingCTPM());
        }

        public void DeleteCTPM(ChiTietPhieuMuonDTO ctpm)
        {
            chiTietPhieuMuonRepository.Delete(ctpm.MappingCTPM());
        }

        public void UpdateCTPM(ChiTietPhieuMuonDTO ctpm)
        {
            chiTietPhieuMuonRepository.Update(ctpm.MappingCTPM());
        }

        public void CreatePhieuMuon(PhieuMuonDTO phieumuonDTO)
        {
            var phieumuon = phieumuonDTO.MappingPhieuMuon();
            phieumuonRepository.Add(phieumuon);
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

        public void UpdatePhieuMuon(PhieuMuonDTO phieumuonDTO)
        {
            var phieumuon = phieumuonRepository.GetBy(phieumuonDTO.MaPM);
            phieumuonDTO.MappingPhieuMuon(phieumuon);
            phieumuonRepository.Update(phieumuon);
        }
    }
}
