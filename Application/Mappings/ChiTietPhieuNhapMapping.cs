using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public static class ChiTietPhieuNhapMapping
    {
        public static ChiTietPhieuNhapDTO MappingDTO(this ChiTietPhieuNhap ctpn)
        {
            return new ChiTietPhieuNhapDTO
            {
                MaPN = ctpn.MaPN,
                MaSach = ctpn.MaSach,
                SoLuongNhap = ctpn.SoLuongNhap,
                DonGiaSach = ctpn.DonGiaSach
            };
        }
        public static ChiTietPhieuNhap MappingCTPN(this ChiTietPhieuNhapDTO ctpnDTO)
        {
            return new ChiTietPhieuNhap
            {
                MaPN = ctpnDTO.MaPN,
                MaSach = ctpnDTO.MaSach,
                SoLuongNhap = ctpnDTO.SoLuongNhap,
                DonGiaSach = ctpnDTO.DonGiaSach
            };
        }
        public static void MappingCTPN(this ChiTietPhieuNhapDTO ctpnDTO, ChiTietPhieuNhap ctpn)
        {
            ctpn.MaPN = ctpnDTO.MaPN;
            ctpn.MaSach = ctpnDTO.MaSach;
            ctpn.SoLuongNhap = ctpnDTO.SoLuongNhap;
            ctpn.DonGiaSach = ctpnDTO.DonGiaSach;
        }

        public static IEnumerable<ChiTietPhieuNhapDTO> MappingDtos(this IEnumerable<ChiTietPhieuNhap> DSCTPN)
        {
            foreach (var ctpn in DSCTPN)
            {
                yield return ctpn.MappingDTO();
            }
        }
        public static IEnumerable<ChiTietPhieuNhap> MappingCTPNs(this IEnumerable<ChiTietPhieuNhapDTO> DSCTPNDTO)
        {
            foreach (var ctpnDTO in DSCTPNDTO)
            {
                yield return ctpnDTO.MappingCTPN();
            }
        }
    }
}
