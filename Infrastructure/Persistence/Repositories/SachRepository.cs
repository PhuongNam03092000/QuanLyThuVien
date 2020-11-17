using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistence.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Repositories
{
    public class SachRepository : EFRepository<Sach>, ISachRepository
    {
        public SachRepository(QLTVDbContext context) : base(context)
        {
        }

    }
}
