using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Persistence.Repositories
{
    public class TacGiaRepository : EFRepository<TacGia>,ITacGiaRepository
    {
        public TacGiaRepository(QLTVContext context) : base(context)
        {
        }

        public IEnumerable<TacGia> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.TacGias.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(tg => tg.TenTG.Contains(searchString));
            }

            SortTacGias(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }
        private static void SortTacGias(string sortOrder, ref IQueryable<TacGia> query)
        {
            switch (sortOrder)
            {
                case "tentg_desc":
                    query = query.OrderByDescending(tg => tg.TenTG);
                    break;

                case "tentg":
                    query = query.OrderBy(tg => tg.TenTG);
                    break;
            }
        }
    }
}
