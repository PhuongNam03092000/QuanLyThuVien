using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Mappings
{
    public static class PhieuNhapMapping
    {
        public static PhieuNhapDTO MappingDTO(this PhieuNhap pn)
        {
            if (!(pn.ChiTietPhieuNhaps == null))
            {
                return new PhieuNhapDTO
                {
                    MaPN = pn.MaPN,
                    MaNCC = pn.MaNCC,
                    NgayNhap = pn.NgayNhap,
                    TongTienNhap = pn.TongTienNhap,
                    UserId = pn.UserId,
                    ChiTietPhieuNhaps = pn.ChiTietPhieuNhaps.MappingDtos().ToList()
                };
            }
            else
            {
                return new PhieuNhapDTO
                {
                    MaPN = pn.MaPN,
                    MaNCC = pn.MaNCC,
                    NgayNhap = pn.NgayNhap,
                    TongTienNhap = pn.TongTienNhap,
                    UserId = pn.UserId
                };
            }           
        }
        public static PhieuNhap MappingPhieuNhap(this PhieuNhapDTO pnDTO)
        {
            if (!(pnDTO.ChiTietPhieuNhaps == null))
            {
                return new PhieuNhap
                {
                    MaPN = pnDTO.MaPN,
                    MaNCC = pnDTO.MaNCC,
                    NgayNhap = pnDTO.NgayNhap,
                    TongTienNhap = pnDTO.TongTienNhap,
                    UserId = pnDTO.UserId,
                    ChiTietPhieuNhaps = pnDTO.ChiTietPhieuNhaps.MappingCTPNs().ToList()
                };
            }
            else
            {
                return new PhieuNhap
                {
                    MaPN = pnDTO.MaPN,
                    MaNCC = pnDTO.MaNCC,
                    NgayNhap = pnDTO.NgayNhap,
                    TongTienNhap = pnDTO.TongTienNhap,
                    UserId = pnDTO.UserId
                };
            }
        }

        public static void MappingPhieuNhap(this PhieuNhapDTO pnDTO, PhieuNhap pn)
        {
            pn.MaPN = pnDTO.MaPN;
            pn.MaNCC = pnDTO.MaNCC;
            pn.NgayNhap = pnDTO.NgayNhap;
            pn.TongTienNhap = pnDTO.TongTienNhap;
            pn.UserId = pnDTO.UserId;

            if (pnDTO.ChiTietPhieuNhaps != null)
            {
                pn.ChiTietPhieuNhaps = pnDTO.ChiTietPhieuNhaps.MappingCTPNs().ToList();
            }

        }
        public static IEnumerable<PhieuNhapDTO> MappingDtos(this IEnumerable<PhieuNhap> DSPhieuNhap)
        {
            foreach (var phieunhap in DSPhieuNhap)
            {
                yield return phieunhap.MappingDTO();
            }
        }
    }
}
