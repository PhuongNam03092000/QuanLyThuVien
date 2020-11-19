using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface ISachService
    {
        //IEnumerable<MovieDto> GetMovies(string sortOrder, string movieGenre, string searchString, int pageIndex, int pageSize, out int count);
        SachDTO GetSach(int Masach);
        //IEnumerable<string> GetGenres();
        IEnumerable<SachDTO> GetAll();
        void CreateSach(SachDTO sach);
        void UpdateSach(SachDTO sach);
        void DeleteSach(int Masach);
    }
}
