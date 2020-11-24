using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Persistence.Repositories
{
    public class NhaXuatBanRepository : EFRepository<NhaXuatBan>, INhaXuaBanRepository
    {
        public NhaXuatBanRepository(QLTVContext context) : base(context)
        {
        }

        public IEnumerable<NhaXuatBan> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.NhaXuatBans.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(nxb => nxb.TenNXB.Contains(searchString));
            }

            SortNhaXuatBans(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        private static void SortNhaXuatBans(string sortOrder, ref IQueryable<NhaXuatBan> query)
        {
            switch (sortOrder)
            {
                case "tennxb_desc":
                    query = query.OrderByDescending(nxb => nxb.TenNXB);
                    break;

                case "tennxb":
                    query = query.OrderBy(nxb => nxb.TenNXB);
                    break;
            }
        }
    }
}