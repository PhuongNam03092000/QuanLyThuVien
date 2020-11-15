using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface ISachRepository : IRepository<Sach>
    {
        IEnumerable<string> GetTheLoais();

        IEnumerable<Sach> Filter(string sortOrder, string theLoaiSach, string searchString, int pageIndex, int pageSize, out int count);
    }
}