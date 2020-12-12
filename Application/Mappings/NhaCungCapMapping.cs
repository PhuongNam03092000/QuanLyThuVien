using Application.DTOs;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Mappings
{
    public static class NhaCungCapMapping
    {
        public static NhaCungCapDTO MappingNhaCungCapDto(this NhaCungCap nhacungCap)
        {
            return new NhaCungCapDTO
            {
                MaNCC = nhacungCap.MaNCC,
                TenNCC = nhacungCap.TenNCC,
                DiaChiNCC = nhacungCap.DiaChiNCC,
                SdtNCC = nhacungCap.SdtNCC
            };
        }

        public static NhaCungCap MappingNhaCungCap(this NhaCungCapDTO nhacungCapDto)
        {
            return new NhaCungCap
            {
                MaNCC = nhacungCapDto.MaNCC,
                TenNCC = nhacungCapDto.TenNCC,
                DiaChiNCC = nhacungCapDto.DiaChiNCC,
                SdtNCC = nhacungCapDto.SdtNCC
            };
        }

        public static void MappingNhaCungCap(this NhaCungCapDTO nhacungCapDto, NhaCungCap nhacungCap)
        {
            nhacungCap.MaNCC = nhacungCapDto.MaNCC;
            nhacungCap.TenNCC = nhacungCapDto.TenNCC;
            nhacungCap.DiaChiNCC = nhacungCapDto.DiaChiNCC;
            nhacungCap.SdtNCC = nhacungCapDto.SdtNCC;
        }

        public static IEnumerable<NhaCungCapDTO> MappingNhaCungCapDtos(this IEnumerable<NhaCungCap> nhaCungCaps)
        {
            foreach (var nhacungCap in nhaCungCaps)
            {
                yield return nhacungCap.MappingNhaCungCapDto();
            }
        }
    }
}

