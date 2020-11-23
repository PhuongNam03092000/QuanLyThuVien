using Application.DTOs;
using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class TacGiaService : ITacGiaService
    {
        private readonly ITacGiaRepository tacgiaRepository; //Lấy từ Domain

        public TacGiaService(ITacGiaRepository tacgiaRepository)
        {
            this.tacgiaRepository = tacgiaRepository;
        }
        public void CreateTacGia(TacGiaDTO tacGia)
        {
            throw new NotImplementedException();
        }

        public void DeleteTacGia(int maTG)
        {
            throw new NotImplementedException();
        }

        public TacGiaDTO GetTacGia(int maTG)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TacGiaDTO> GetTacGias(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var tacgias = tacgiaRepository.Filter(sortOrder, searchString, pageIndex, pageSize, out count);
            return tacgias;
        }

        public void UpdateTacGia(TacGiaDTO tacGia)
        {
            throw new NotImplementedException();
        }
    }
}
