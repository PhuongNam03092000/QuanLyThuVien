using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Repositories
{
    public class PhieuMuonRepository : EFRepository<PhieuMuon>, IPhieuMuonRepository
    {
        public PhieuMuonRepository(QLTVContext context) : base(context)
        {
        }

        public IEnumerable<PhieuMuon> Filter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            throw new NotImplementedException();
        }
    }
}
