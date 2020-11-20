using Application.DTOs;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Mappings
{
    public static class TheLoaiMapping
    {
        public static TheLoaiDTO MappingTheLoaiDto(this TheLoai theLoai)
        {
            return new TheLoaiDTO
            {
                MaTL = theLoai.MaTL,
                TenTL = theLoai.TenTL
            };
        }

        public static TheLoai MappingTheLoai(this TheLoaiDTO theLoaiDTO)
        {
            return new TheLoai
            {
                MaTL = theLoaiDTO.MaTL,
                TenTL = theLoaiDTO.TenTL
            };
        }

        public static void MappingTheLoai(this TheLoaiDTO theLoaiDTO, TheLoai theLoai)
        {
            theLoai.MaTL = theLoaiDTO.MaTL;
            theLoai.TenTL = theLoaiDTO.TenTL;
        }

        public static IEnumerable<TheLoaiDTO> MappingTheLoaiDtos(this IEnumerable<TheLoai> theLoais)
        {
            foreach (var theLoai in theLoais)
            {
                yield return theLoai.MappingTheLoaiDto();
            }
        }
    }
}