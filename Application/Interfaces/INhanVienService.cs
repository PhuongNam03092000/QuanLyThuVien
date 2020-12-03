using Application.DTOs;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface INhanVienService
    {
        IEnumerable<NhanVienDTO> GetNhanViens(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);

        NhanVienDTO GetNhanVien(int Id);

        Task<IdentityResult> ThemNhanVien(NhanVienDTO nhanvien);

        void SuaNhanVien(NhanVienDTO nhanvien);

        void XoaNhanVien(int Id);
    }
}
