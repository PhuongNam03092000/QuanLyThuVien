using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITheLoaiRepository : IEFRepository<TheLoai>
    {
        IEnumerable<TheLoai> LayTheLoai();

        IEnumerable<TheLoai> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);
    }
}