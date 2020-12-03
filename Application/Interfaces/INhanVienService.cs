using Application.DTOs;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface INhanVienService
    {
        IEnumerable<NhanVienDTO> GetNhanViens(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);

        NhanVienDTO GetNhanVien(int Id);

        void ThemNhanVien(NhanVienDTO nhanvien);

        void SuaNhanVien(NhanVienDTO nhanvien);

        void XoaNhanVien(int Id);
    }
}
