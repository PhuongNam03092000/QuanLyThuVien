using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;
using System.Collections.Generic;

namespace Application.Services
{
    public class NhanVienService : INhanVienService
    {
        private readonly INhanVienRepository _nhanVienRepository; 

        public NhanVienService(INhanVienRepository nhanVienRepository)
        {
            _nhanVienRepository = nhanVienRepository;
        }

        public IEnumerable<NhanVienDTO> GetNhanViens(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var nhanViens = _nhanVienRepository.Filter(sortOrder, searchString, pageIndex, pageSize, out count);
            return nhanViens.MappingNhanVienDtos();
        }

        public NhanVienDTO GetNhanVien(int maNV)
        {
            var nhanvien = _nhanVienRepository.GetBy(maNV);

            return nhanvien.MappingNhanVienDto();
        }

        public void SuaNhanVien(NhanVienDTO nhanVienDto)
        {
            var nhanVien = _nhanVienRepository.GetBy(nhanVienDto.MaNV);

            nhanVienDto.MappingNhanVien(nhanVien);

            _nhanVienRepository.Update(nhanVien);
        }

        public void ThemNhanVien(NhanVienDTO nhanVienDto)
        {
            var nhanVien = nhanVienDto.MappingNhanVien();

            _nhanVienRepository.Add(nhanVien);
        }

        public void XoaNhanVien(int maNV)
        {
            var nhanVien = _nhanVienRepository.GetBy(maNV);

            _nhanVienRepository.Delete(nhanVien);
        }
    }
}
