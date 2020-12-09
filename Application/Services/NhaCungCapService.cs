using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class NhaCungCapService : INhaCungCapService
    {
        private readonly INhaCungCapRepository _nhacungCapRepository;

        public NhaCungCapService(INhaCungCapRepository nhacungCapRepository)
        {
            _nhacungCapRepository = nhacungCapRepository;
        }
        public IEnumerable<NhaCungCapDTO> GetNhaCungCaps(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var nhacungCaps = _nhacungCapRepository.Filter(sortOrder, searchString, pageIndex, pageSize, out count);
            return nhacungCaps.MappingNhaCungCapDtos();
        }

        public NhaCungCapDTO GetNhaCungCap(int maNCC)
        {
            var nhacungCap = _nhacungCapRepository.GetBy(maNCC);

            return nhacungCap.MappingNhaCungCapDto();
        }

        public void ThemNhaCungCap(NhaCungCapDTO nhacungCapDto)
        {
            var nhacungCap = nhacungCapDto.MappingNhaCungCap();

            _nhacungCapRepository.Add(nhacungCap);
        }
        public void SuaNhaCungCap(NhaCungCapDTO nhacungCapDto)
        {
            var nhacungCap = _nhacungCapRepository.GetBy(nhacungCapDto.MaNCC);

            nhacungCapDto.MappingNhaCungCap(nhacungCap);

            _nhacungCapRepository.Update(nhacungCap);
        }
        public void XoaNhaCungCap(int maNCC)
        {
            var nhacungCap = _nhacungCapRepository.GetBy(maNCC);

            _nhacungCapRepository.Delete(nhacungCap);
        }
    }
}
