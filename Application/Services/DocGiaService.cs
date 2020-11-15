using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class DocGiaService :IDocGiaService
    {
        private readonly IDocGiaRepository docgiaRepository;
        public DocGiaService(IDocGiaRepository docgiaRepository)
        {
            this.docgiaRepository = docgiaRepository;
        }

        public void CreateDocGia(DocGiaDTO docGiaDTO)
        {
            var docgia = docGiaDTO.MappingDocGia();
            docgiaRepository.Add(docgia);
        }

        public void DeleteDocGia(int MaDG)
        {
            var docgia = docgiaRepository.GetBy(MaDG);
            docgiaRepository.Delete(docgia);
        }

        public DocGiaDTO GetDocGia(int MaDG)
        {
            var docGia = docgiaRepository.GetBy(MaDG);
            return docGia.MappingDTO();
        }

        public void UpdateDocGia(DocGiaDTO docGia)
        {
            var docgia = docgiaRepository.GetBy(docGia.MaDG);
        }
    }
}
