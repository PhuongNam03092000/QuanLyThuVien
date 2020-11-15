using Application.DTOs;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface ISachService
    {
        IEnumerable<SachDto> GetSachs(string sortOrder, string theLoaiSach, string searchString, int pageIndex, int pageSize, out int count);

        SachDto GetSach(int sachId);

        IEnumerable<string> GetTheLoais();

        void ThemSach(SachDto sach);

        void SuaSach(SachDto sach);

        void XoaSach(int sachId);
    }
}