using Application.DTOs;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Mappings
{
    public static class NhanVienMapping
    {        
        public static NhanVienDTO MappingNhanVienDto(this AppUser nhanvien)
        {
            return new NhanVienDTO
            {
                HoNV = nhanvien.HoNV,
                TenNV = nhanvien.TenNV,              
                DoBNV = nhanvien.DoBNV             
            };
        }

        public static AppUser MappingNhanVien(this NhanVienDTO nhanvienDto)
        {
            return new AppUser
            {
                HoNV = nhanvienDto.HoNV,
                TenNV = nhanvienDto.TenNV,               
                DoBNV = nhanvienDto.DoBNV               
            };
        }

        public static void MappingNhanVien(this NhanVienDTO nhanvienDto, AppUser nhanVien)
        {
            nhanVien.HoNV = nhanvienDto.HoNV;
            nhanVien.TenNV = nhanvienDto.TenNV;           
            nhanVien.DoBNV = nhanvienDto.DoBNV;          
        }

        public static IEnumerable<NhanVienDTO> MappingNhanVienDtos(this IEnumerable<AppUser> nhanviens)
        {
            foreach (var nhanVien in nhanviens)
            {
                yield return nhanVien.MappingNhanVienDto();
            }
        }
    }
}
