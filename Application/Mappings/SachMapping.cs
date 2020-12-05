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
                MaNXB = sach.MaNXB,
                MaTL = sach.MaTL,
                GiaBia = sach.GiaBia,
                SachImage = sach.SachImage,
                ViTri = sach.ViTri,
                TrangThaiSach = sach.TrangThaiSach
            };
        }

        public static Sach MappingSach(this SachDTO sachDTO)
        {
            return new Sach
            {
                MaSach = sachDTO.MaSach,
                TenSach = sachDTO.TenSach,
                MaTG = sachDTO.MaTG,
                MaNXB = sachDTO.MaNXB,
                MaTL = sachDTO.MaTL,
                GiaBia = sachDTO.GiaBia,
                SachImage = sachDTO.SachImage,
                ViTri = sachDTO.ViTri,
                TrangThaiSach = sachDTO.TrangThaiSach
            };
        }

        public static void MappingSach(this SachDTO sachDTO, Sach sach)
        {
            sach.MaSach = sachDTO.MaSach;
            sach.TenSach = sachDTO.TenSach;
            sach.MaTG = sachDTO.MaTG;
            sach.MaNXB = sachDTO.MaNXB;
            sach.MaTL = sachDTO.MaTL;
            sach.GiaBia = sachDTO.GiaBia;
            sach.SachImage = sachDTO.SachImage;
            sach.ViTri = sachDTO.ViTri;
            sach.TrangThaiSach = sachDTO.TrangThaiSach;
        }

        public static IEnumerable<SachDTO> MappingSachDTOs(this IEnumerable<Sach> sachs)
        {
            foreach (var sach in sachs)
            {
                yield return sach.MappingSachDto();
            }
        }
    }
}
