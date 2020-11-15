using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public static class SachMapping
    {
        public static SachDto MappingDto(this Sach sach)
        {
            return new SachDto
            {
                Id = sach.Id,
                TenSach = sach.TenSach,
                TheLoai = sach.TheLoai,
                TacGia = sach.TacGia,
                NhaXuatBan = sach.NhaXuatBan,
                GiaBia = sach.GiaBia,
                ViTri = sach.ViTri
            };
        }

        public static Sach MappingSach(this SachDto sachDto)
        {
            return new Sach
            {
                Id = sachDto.Id,
                TenSach = sachDto.TenSach,
                TheLoai = sachDto.TheLoai,
                TacGia = sachDto.TacGia,
                NhaXuatBan = sachDto.NhaXuatBan,
                GiaBia = sachDto.GiaBia,
                ViTri = sachDto.ViTri
            };
        }

        public static void MappingSach(this SachDto sachDto, Sach sach)
        {
            sach.TenSach = sachDto.TenSach;
            sach.TheLoai = sachDto.TheLoai;
            sach.TacGia = sachDto.TacGia;
            sach.NhaXuatBan = sachDto.NhaXuatBan;
            sach.GiaBia = sachDto.GiaBia;
            sach.ViTri = sachDto.ViTri;
        }

        public static IEnumerable<SachDto> MappingDtos(this IEnumerable<Sach> sachs)
        {
            foreach (var sach in sachs)
            {
                yield return sach.MappingDto();
            }
        }
    }
}