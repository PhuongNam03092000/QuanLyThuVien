using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Application.Mappings
{
    public static class PhieuPhatMapping
    {
        public static PhieuPhatDTO MappingDTO(this PhieuPhat pp)
        {
            if (!(pp.ChiTietPhieuPhats == null))
            {
                return new PhieuPhatDTO
                {
                    MaPP = pp.MaPP,
                    MaDG = pp.MaDG,
                    TongPhiPhat = pp.TongPhiPhat,
                    UserId = pp.UserId,
                    ChiTietPhieuPhats = pp.ChiTietPhieuPhats.MappingDtos().ToList()
                };
            }
            else
            {
                return new PhieuPhatDTO
                {
                    MaPP = pp.MaPP,
                    MaDG = pp.MaDG,
                    TongPhiPhat = pp.TongPhiPhat,
                    UserId = pp.UserId,
                };
            }
        }

        public static PhieuPhat MappingPhieuPhat(this PhieuPhatDTO ppDTO)
        {
            if (!(ppDTO.ChiTietPhieuPhats == null))
            {
                return new PhieuPhat
                {
                    MaPP = ppDTO.MaPP,
                    MaDG = ppDTO.MaDG,
                    TongPhiPhat = ppDTO.TongPhiPhat,
                    UserId = ppDTO.UserId,
                    ChiTietPhieuPhats = ppDTO.ChiTietPhieuPhats.MappingCTPPs().ToList()
                };
            }
            else
            {
                return new PhieuPhat
                {
                    MaPP = ppDTO.MaPP,
                    MaDG = ppDTO.MaDG,
                    TongPhiPhat = ppDTO.TongPhiPhat,
                    UserId = ppDTO.UserId,
                };
            }
        }

        public static void MappingPhieuPhat(this PhieuPhatDTO ppDTO, PhieuPhat pp)
        {
            pp.MaPP = ppDTO.MaPP;
            pp.MaDG = ppDTO.MaDG;
            pp.TongPhiPhat = ppDTO.TongPhiPhat;
            pp.UserId = ppDTO.UserId;
            if (ppDTO.ChiTietPhieuPhats != null)
            {
                pp.ChiTietPhieuPhats = ppDTO.ChiTietPhieuPhats.MappingCTPPs().ToList();
            }

        }
        public static IEnumerable<PhieuPhatDTO> MappingDtos(this IEnumerable<PhieuPhat> DSPhieuPhat)
        {
            foreach (var phieuphat in DSPhieuPhat)
            {
                yield return phieuphat.MappingDTO();
            }
        }
    }
}
