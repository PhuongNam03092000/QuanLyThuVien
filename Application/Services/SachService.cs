using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class SachService : ISachService
    {
        private readonly ISachRepository _sachRepository;

        public SachService(ISachRepository sachRepository)
        {
            _sachRepository = sachRepository;
        }

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
            var sachs = _sachRepository.Filter(sortOrder,searchString, pageIndex, pageSize, out count);
            return sachs.MappingSachDTOs();
        }

        public void Update(SachDTO sach)
        {
            throw new NotImplementedException();
        }
    }
}
