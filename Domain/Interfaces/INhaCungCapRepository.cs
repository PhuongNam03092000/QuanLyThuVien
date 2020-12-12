using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface INhaCungCapRepository : IEFRepository<NhaCungCap>
    {
        IEnumerable<NhaCungCap> LayNhaCungCap();
        IEnumerable<NhaCungCap> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);
    }
}
