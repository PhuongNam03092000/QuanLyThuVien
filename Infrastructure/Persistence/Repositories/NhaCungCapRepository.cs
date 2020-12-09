using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class NhaCungCapRepository : EFRepository<NhaCungCap>, INhaCungCapRepository
    {
        public NhaCungCapRepository(QLTVContext context) : base(context)
        {
        }
        public IEnumerable<NhaCungCap> LayNhaCungCap()
        {
            List<NhaCungCap> ncc = new List<NhaCungCap>();
            ncc = (from t in context.NhaCungCaps select t).ToList();
            ncc.Insert(0, new NhaCungCap { MaNCC = 0, TenNCC = "Chọn nhà cung cấp" });
            return ncc;
        }

        public IEnumerable<NhaCungCap> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.NhaCungCaps.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(ncc => ncc.TenNCC.Contains(searchString));
            }

            SortNhaCungCaps(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        private static void SortNhaCungCaps(string sortOrder, ref IQueryable<NhaCungCap> query)
        {
            switch (sortOrder)
            {
                case "mancc_desc":
                    query = query.OrderByDescending(ncc => ncc.MaNCC);
                    break;

                case "mancc":
                    query = query.OrderBy(ncc => ncc.MaNCC);
                    break;

                case "tenncc_desc":
                    query = query.OrderByDescending(ncc => ncc.TenNCC);
                    break;

                case "tenncc":
                    query = query.OrderBy(ncc => ncc.TenNCC);
                    break;

                case "diachincc_desc":
                    query = query.OrderByDescending(ncc => ncc.DiaChiNCC);
                    break;

                case "diachincc":
                    query = query.OrderBy(ncc => ncc.DiaChiNCC);
                    break;

                case "sdtncc_desc":
                    query = query.OrderByDescending(ncc => ncc.SdtNCC);
                    break;

                case "sdtncc":
                    query = query.OrderBy(ncc => ncc.SdtNCC);
                    break;
            }
        }
    }
}
