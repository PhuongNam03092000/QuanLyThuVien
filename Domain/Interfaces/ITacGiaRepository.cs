using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ITacGiaRepository : IEFRepository<TacGia>
    {
        IEnumerable<TacGia> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);
    }
}
