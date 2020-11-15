using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Repositories;
using System.Collections.Generic;

namespace Application.Services
{
    public class SachService : ISachService
    {
        private readonly ISachRepository sachRepository;

        public SachService(ISachRepository sachRepository)
        {
            this.sachRepository = sachRepository;
        }

        public SachDto GetSach(int sachId)
        {
            var sach = sachRepository.GetBy(sachId);

            return sach.MappingDto();
        }

        public IEnumerable<SachDto> GetSachs(string sortOrder, string theLoaiSach, string searchString, int pageIndex, int pageSize, out int count)
        {
            var sachs = sachRepository.Filter(sortOrder, theLoaiSach, searchString, pageIndex, pageSize, out count);

            return sachs.MappingDtos();
        }

        public IEnumerable<string> GetTheLoais()
        {
            return sachRepository.GetTheLoais();
        }

        public void SuaSach(SachDto sachDto)
        {
            var sach = sachRepository.GetBy(sachDto.Id);

            sachDto.MappingSach(sach);

            sachRepository.Update(sach);
        }

        public void ThemSach(SachDto sachDto)
        {
            var sach = sachDto.MappingSach();
            sachRepository.Add(sach);
        }

        public void XoaSach(int sachId)
        {
            var sach = sachRepository.GetBy(sachId);

            sachRepository.Delete(sach);
        }
    }
}