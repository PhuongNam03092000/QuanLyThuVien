using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistence.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Repositories
{
    public class DocGiaRepository : EFRepository<DocGia>, IDocGiaRepository
    {
        public DocGiaRepository(QLTVDbContext context) : base(context)
        {
        }
    }
}
