using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class SachService : ISachService
    {
        private readonly ISachRepository _sachRepository; //Lấy từ Domain

        public SachService(ISachRepository sachRepository)
        {
            _sachRepository = sachRepository;
        }

        public IEnumerable<SachDTO> GetSachs(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var sachs = _sachRepository.Filter(sortOrder, searchString, pageIndex, pageSize, out count);
            return sachs.MappingSachDtos();
        }

        public SachDTO GetSach(int maS)
        {
            var sach = _sachRepository.GetBy(maS);

            return sach.MappingSachDto();
        }

        public void SuaSach(SachDTO sachDto)
        {
            var sach = _sachRepository.GetBy(sachDto.MaSach);

            sachDto.MappingSach(sach);

            _sachRepository.Update(sach);
        }

        public void ThemSach(SachDTO sachDto)
        {
            var sach = sachDto.MappingSach();

            _sachRepository.Add(sach);
        }

        public void XoaSach(int maS)
        {
            var sach = _sachRepository.GetBy(maS);

            _sachRepository.Delete(sach);
        }
    }
}