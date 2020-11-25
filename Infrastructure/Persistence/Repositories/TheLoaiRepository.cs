using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Persistence.Repositories
{
    public class TheLoaiRepository : EFRepository<TheLoai>, ITheLoaiRepository
    {
        public TheLoaiRepository(QLTVContext context) : base(context)
        {
        }

        public IEnumerable<TheLoai> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.TheLoais.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(tl => tl.TenTL.Contains(searchString));
            }

            SortTheLoais(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        private static void SortTheLoais(string sortOrder, ref IQueryable<TheLoai> query)
        {
            switch (sortOrder)
            {
                case "matl_desc":
                    query = query.OrderByDescending(tl => tl.MaTL);
                    break;
                case "matl":
                    query = query.OrderBy(tl => tl.MaTL);
                    break;
                case "tentl_desc":
                    query = query.OrderByDescending(tl => tl.TenTL);
                    break;
                case "tentl":
                    query = query.OrderBy(tl => tl.TenTL);
                    break;
            }
        }
    }
}