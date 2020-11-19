using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Repositories;
using System;


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
