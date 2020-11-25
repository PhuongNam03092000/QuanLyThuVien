using Application.DTOs;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class SachService : ISachService
    {
        public void Create(SachDTO sach)
        {
            throw new NotImplementedException();
        }

        public void Delete(int maS)
        {
            throw new NotImplementedException();
        }

        public SachDTO GetSach(int maS)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SachDTO> GetSachs(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            throw new NotImplementedException();
        }

        public void Update(SachDTO sach)
        {
            throw new NotImplementedException();
        }
    }
}
