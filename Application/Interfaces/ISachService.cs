using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface ISachService
    {
        IEnumerable<SachDTO> GetSachs(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);

        SachDTO GetSach(int maS);

        void ThemSach(SachDTO sach);

        void SuaSach(SachDTO sach);

        void XoaSach(int maS);
    }
}