using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public static class SachMapping
    {
        public static SachDTO MappingSachDto(this Sach sach)
        {
            return new SachDTO
            {
                MaSach = sach.MaSach,
                TenSach = sach.TenSach,
                MaTG = sach.MaTG,
                MaTL = sach.MaTL,
                MaNXB = sach.MaNXB,
                GiaBia = sach.GiaBia,
                ViTri = sach.ViTri,
                TenTL = sach.TheLoai.TenTL,
                TenTG = sach.TacGia.TenTG,
                TenNXB = sach.NhaXuatBan.TenNXB,
                SachImageUrl = sach.SachImageUrl
            };
        }

        public static Sach MappingSach(this SachDTO sachDto)
        {
            return new Sach
            {
                MaSach = sachDto.MaSach,
                TenSach = sachDto.TenSach,
                MaTG = sachDto.MaTG,
                MaTL = sachDto.MaTL,
                MaNXB = sachDto.MaNXB,
                GiaBia = sachDto.GiaBia,
                ViTri = sachDto.ViTri,
                SachImageUrl = sachDto.SachImageUrl
            };
        }

        public static void MappingSach(this SachDTO sachDto, Sach sach)
        {
            sach.MaSach = sachDto.MaSach;
            sach.TenSach = sachDto.TenSach;
            sach.MaTG = sachDto.MaTG;
            sach.MaTL = sachDto.MaTL;
            sach.MaNXB = sachDto.MaNXB;
            sach.GiaBia = sachDto.GiaBia;
            sach.ViTri = sachDto.ViTri;
            sach.SachImageUrl = sachDto.SachImageUrl;
        }

        public static IEnumerable<SachDTO> MappingSachDtos(this IEnumerable<Sach> sachs)
        {
            foreach (var sach in sachs)
            {
                yield return sach.MappingSachDto();
            }
        }
    }
}