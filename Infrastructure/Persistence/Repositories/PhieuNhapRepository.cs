using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Persistence.Repositories
{
    public class PhieuNhapRepository : EFRepository<PhieuNhap>, IPhieuNhapRepository
    {
        public PhieuNhapRepository(QLTVContext context) : base(context)
        {
        }
        public IEnumerable<PhieuNhap> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.PhieuNhaps.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(pn => pn.MaPN == Int32.Parse(searchString));
            }

            SortPhieuNhaps(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        private static void SortPhieuNhaps(string sortOrder, ref IQueryable<PhieuNhap> query)
        {            
        }
    }
}
