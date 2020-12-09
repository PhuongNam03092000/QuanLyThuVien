using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface INhaXuatBanRepository : IEFRepository<NhaXuatBan>
    {
        IEnumerable<NhaXuatBan> LayNXB();

        IEnumerable<NhaXuatBan> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);
    }
}