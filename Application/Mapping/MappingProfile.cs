/*using Application.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mapping
    // chuyển đổi dữ liệu từ giữa DTO và Entity
{
    public static class MappingProfile
    {
        public static DauSachDTO MappingDto(this DauSach dausach) 
        {
            return new DauSachDTO
            {
                MaDS = dausach.MaDS,
                TenDS = dausach.TenDS,
                MaTG = dausach.MaTG,
                MaTL = dausach.MaTL,
                MaNXB = dausach.MaNXB,
                HinhAnh = dausach.HinhAnh
            };
        }

        public static DauSach MappingDauSach(this DauSachDTO dausachDTO)
        {
            return new DauSach
            {
                MaDS = dausachDTO.MaDS,
                TenDS = dausachDTO.TenDS,
                MaTG = dausachDTO.MaTG,
                MaTL = dausachDTO.MaTL,
                MaNXB = dausachDTO.MaNXB,
                HinhAnh = dausachDTO.HinhAnh
            };
        }

        public static void MappingDauSach(this DauSachDTO dausachDTO,DauSach dausach)
        {
            dausachDTO.MaDS = dausach.MaDS;
            dausachDTO.TenDS = dausach.TenDS;
            dausachDTO.MaTG = dausach.MaTG;
            dausachDTO.MaTL = dausach.MaTL;
            dausachDTO.MaNXB = dausach.MaNXB;
            dausachDTO.HinhAnh = dausach.HinhAnh;
        }

        public static IEnumerable<DauSachDTO> MappingDtos(this IEnumerable<DauSach> DSDauSach)
        {
            foreach(var dausach in DSDauSach)
            {
                yield return dausach.MappingDto();
            }
        }
    }
}
*/