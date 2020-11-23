using Application.DTOs;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Mappings
{
    public static class TacGiaMapping
    {
        public static TacGiaDTO MappingTacGiaDto(this TacGia tacgia)
        {
            return new TacGiaDTO
            {
                MaTG = tacgia.MaTG,
                TenTG = tacgia.TenTG
            };
        }
            
        public static TacGia MappingTacGia(this TacGiaDTO tacgiaDTO)
        {
            return new TacGia
            {
                MaTG = tacgiaDTO.MaTG,
                TenTG = tacgiaDTO.TenTG
            };
        }

        public static void MappingTacGia(this TacGiaDTO tacgiaDTO, TacGia tacgia)
        {
            tacgia.MaTG = tacgiaDTO.MaTG;
            tacgia.TenTG = tacgiaDTO.TenTG;
        }

        public static IEnumerable<TacGiaDTO> MappingTacGiaDtos(this IEnumerable<TacGia> tacgias)
        {
            foreach (var tacgia in tacgias)
            {
                yield return tacgia.MappingTacGiaDto();
            }
        }
    }
}