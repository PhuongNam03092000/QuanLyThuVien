using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ITheLoaiRepository : IEFRepository<TheLoai>
    {
        IEnumerable<TheLoai> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);
    }
}