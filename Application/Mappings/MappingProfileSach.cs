using Application.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public static class MappingProfileSach
    {
        public static SachDTO MappingDTO(this Sach sach)
        {
            return new SachDTO
            {
                MaSach = sach.MaSach,
                TenSach = sach.TenSach,
                MaTG = sach.MaTG,
                MaNXB = sach.MaNXB,
                MaTL = sach.MaTL,
                GiaBia = sach.GiaBia
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
                GiaBia = sachDTO    .GiaBia
            };
        }
        public static void MappingSach(this SachDTO sachDTO,Sach sach)
        {

            sach.MaSach = sachDTO.MaSach;
            sach.TenSach = sachDTO.TenSach;
            sach.MaTG = sachDTO.MaTG;
            sach.MaNXB = sachDTO.MaNXB;
            sach.MaTL = sachDTO.MaTL;
            sach.GiaBia = sachDTO.GiaBia;
        }
        public static IEnumerable<SachDTO> MappingDtos(this IEnumerable<Sach> dssach)
        {
            foreach (var sach in dssach)
            {
                yield return sach.MappingDTO();
            }
        }
    }
}
