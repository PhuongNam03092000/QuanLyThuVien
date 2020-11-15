using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IDocGiaService
    {
        DocGiaDTO GetDocGia(int MaDG);
        void CreateDocGia(DocGiaDTO docGia);
        void UpdateDocGia(DocGiaDTO docGia);
        void DeleteDocGia(int Madocgia);
    }
}
