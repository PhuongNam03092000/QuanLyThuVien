using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class PhieuPhatService : IPhieuPhatService
    {
        private readonly IPhieuPhatRepository phieuphatRepository;
        private readonly IChiTietPhieuPhatRepository chiTietPhieuPhatRepository;
        private readonly ISachRepository sachRepository;

        public PhieuPhatService(IPhieuPhatRepository phieuPhatRepository, IChiTietPhieuPhatRepository chiTietPhieuPhatRepository, ISachRepository sachRepository)
        {
            this.phieuphatRepository = phieuPhatRepository;
            this.chiTietPhieuPhatRepository = chiTietPhieuPhatRepository;
            this.sachRepository = sachRepository;
        }

        public void AddCTPP(ChiTietPhieuPhatDTO ctppDTO)
        {
            var ctpp = ctppDTO.MappingCTPP();
            var sach = sachRepository.GetBy(ctppDTO.MaSach);
            sach.TrangThaiSach = "Đã mượn";
            sachRepository.Update(sach);
            chiTietPhieuPhatRepository.Add(ctpp);
        }

        public void DeleteCTPP(IEnumerable<ChiTietPhieuPhatDTO> ctppDTOList)
        {
            var list = ctppDTOList.Where(c => c.IsSelected == true);

            list.ToList().ForEach(c =>
            {
                var ctpp = chiTietPhieuPhatRepository.GetBy(c.MaPP, c.MaSach);
                var sach = sachRepository.GetBy(c.MaSach);
                sach.TrangThaiSach = "Còn";
                sachRepository.Update(sach);
                chiTietPhieuPhatRepository.Delete(ctpp);
            });

        }

        public void UpdateCTPP(ChiTietPhieuPhatDTO ctppDTO)
        {
            var ctpp = chiTietPhieuPhatRepository.GetBy(ctppDTO.MaPP, ctppDTO.MaSach);
            ctppDTO.MappingCTPP(ctpp);
            chiTietPhieuPhatRepository.Update(ctpp);
        }
        public void CreatePhieuPhat(PhieuPhatDTO phieuphatDTO)
        {
            var phieuphat = phieuphatDTO.MappingPhieuPhat();
            phieuphatRepository.Add(phieuphat);
        }
        public void DeletePhieuPhat(int maPP)
        {
            var phieuphat = phieuphatRepository.GetBy(maPP);
            phieuphatRepository.Delete(phieuphat);
        }

        public PhieuPhatDTO GetPhieuPhat(int maPP)
        {
            var phieuphat = phieuphatRepository.GetBy(maPP);
            var ctpps = chiTietPhieuPhatRepository.CTPPs(phieuphat.MaPP);
            if (ctpps.Any())
            {
                phieuphat.ChiTietPhieuPhats = (List<ChiTietPhieuPhat>)ctpps;
            }

            return phieuphat.MappingDTO();
        }

        public IEnumerable<PhieuPhatDTO> GetPhieuPhats(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var phieuPhats = phieuphatRepository.Filter(sortOrder, searchString, pageIndex, pageSize, out count);
            foreach (PhieuPhat pp in phieuPhats)
            {
                var ctpps = chiTietPhieuPhatRepository.CTPPs(pp.MaPP);
                if (ctpps.Any())
                {
                    pp.ChiTietPhieuPhats = (List<ChiTietPhieuPhat>)ctpps;
                }
            }
            return phieuPhats.MappingDtos();
        }

        public void UpdatePhieuPhat(PhieuPhatDTO phieuphatDTO)
        {
            var phieuphat = phieuphatRepository.GetBy(phieuphatDTO.MaPP);
            phieuphatDTO.MappingPhieuPhat(phieuphat);
            phieuphatRepository.Update(phieuphat);
        }
    }
}
