using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Application.Services
{
    public class SachService : ISachService
    {
        private readonly ISachRepository sachRepository;
        public SachService(ISachRepository sachRepository)
        {
            this.sachRepository = sachRepository;
        }
        public void CreateSach(SachDTO sachDTO)
        {
            var sach = sachDTO.MappingSach();
            sachRepository.Add(sach);
        }

        public void DeleteSach(int Masach)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SachDTO> GetAll()
        {
            var temp = this.sachRepository.GetAll().MappingDtos();
            return temp;
        }

        public SachDTO GetSach(int Masach)
        {
            throw new NotImplementedException();
        }

        public void UpdateSach(SachDTO sach)
        {
            throw new NotImplementedException();
        }
    }
}
