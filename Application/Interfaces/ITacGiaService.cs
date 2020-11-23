using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface ITacGiaService
    {
        IEnumerable<TacGiaDTO> GetTacGias(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);

        TacGiaDTO GetTacGia(int maTG);

        void CreateTacGia(TacGiaDTO tacGia);

        void UpdateTacGia(TacGiaDTO tacGia);

        void DeleteTacGia(int maTG);
    }
}