using Application.DTOs;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface INhaCungCapService
    {
        IEnumerable<NhaCungCapDTO> GetNhaCungCaps(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);

        NhaCungCapDTO GetNhaCungCap(int maNCC);

        void ThemNhaCungCap(NhaCungCapDTO nhacungCap);

        void SuaNhaCungCap(NhaCungCapDTO nhacungCap);

        void XoaNhaCungCap(int maNCC);
    }
}
