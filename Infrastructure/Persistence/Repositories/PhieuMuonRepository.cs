using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Persistence.Repositories
{
    public class PhieuMuonRepository : EFRepository<PhieuMuon>,IPhieuMuonRepository
    {
        public PhieuMuonRepository(QLTVContext context) : base(context)
        {
        }

     

        public IEnumerable<PhieuMuon> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.PhieuMuons.AsQueryable();
            count = query.Count();
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }
    }
}
