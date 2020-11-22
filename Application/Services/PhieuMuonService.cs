using Application.DTOs;
using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class PhieuMuonService : IPhieuMuonService
    {
        private readonly IPhieuMuonRepository phieumuonRepository; //Lấy từ Domain
        public PhieuMuonService(IPhieuMuonRepository phieuMuonRepository)
        {
            this.phieumuonRepository = phieuMuonRepository;
        }
        public void AddCTPM(int maPM, ChiTietPhieuMuonDTO ctpm)
        {
            throw new NotImplementedException();
        }

        public void CreatePhieuMuon(PhieuMuonDTO phieumuon)
        {
            throw new NotImplementedException();
        }

        public void DeletePhieuMuon(int maPM)
        {
            throw new NotImplementedException();
        }

        public PhieuMuonDTO GetPhieuMuon(int maPM)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PhieuMuonDTO> GetPhieuMuons(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            throw new NotImplementedException();
        }

        public void UpdatePhieuMuon(PhieuMuonDTO phieumuon)
        {
            throw new NotImplementedException();
        }
    }
}
