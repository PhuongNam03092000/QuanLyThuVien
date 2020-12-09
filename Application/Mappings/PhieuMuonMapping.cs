using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public static class PhieuMuonMapping
    {
        public static PhieuMuonDTO MappingDTO(this PhieuMuon pm)
        {
            return new PhieuMuonDTO
            {
                MaPM = pm.MaPM,
                MaDG = pm.MaDG,
                NgayMuon = pm.NgayMuon,
                TongPhiMuon = pm.TongPhiMuon,
                UserId = pm.UserId
              
            };
        }

        public static PhieuMuon MappingDocGia(this PhieuMuonDTO pmDTO)
        {
            return new PhieuMuon
            {
                MaPM = pmDTO.MaPM,
                MaDG = pmDTO.MaDG,
                NgayMuon = pmDTO.NgayMuon,
                TongPhiMuon = pmDTO.TongPhiMuon,
                UserId = pmDTO.UserId
               
            };
        }
        public static void MappingDocGia(this PhieuMuonDTO pmDTO, PhieuMuon pm)
        {
            pm.MaPM = pmDTO.MaPM;
            pm.MaDG = pmDTO.MaDG;
            pm.NgayMuon = pmDTO.NgayMuon;
            pm.TongPhiMuon = pmDTO.TongPhiMuon;
            pm.UserId = pmDTO.UserId;
            
        }
        public static IEnumerable<PhieuMuonDTO> MappingDtos(this IEnumerable<PhieuMuon> DSPhieuMuon)
        {
            foreach (var phieumuon in DSPhieuMuon)
            {
                yield return phieumuon.MappingDTO();
            }
        }
    }
}
