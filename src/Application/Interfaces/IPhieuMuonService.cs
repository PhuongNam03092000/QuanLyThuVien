using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IPhieuMuonService
    {
        IEnumerable<PhieuMuonDTO> GetPhieuMuons(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);
        PhieuMuonDTO GetPhieuMuon(int maPM);
        void CreatePhieuMuon(PhieuMuonDTO phieumuon);
        void UpdatePhieuMuon(PhieuMuonDTO phieumuon);
        void DeletePhieuMuon(int maPM);
        void AddCTPM(ChiTietPhieuMuonDTO ctpmDTO);
        void UpdateCTPM(ChiTietPhieuMuonDTO ctpmDTO);
        void DeleteCTPM(IEnumerable<ChiTietPhieuMuonDTO> ctpmDTOList);
    }
}