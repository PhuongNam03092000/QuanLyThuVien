using Application.DTOs;
using QLTV.Helpers;

namespace QLTV.ViewModel
{
    public class IndexViewModelDocGia
    {
        public PaginatedList<DocGiaDTO> DSDocGia { get; set; }
        public DocGiaDTO docgiamoi { set; get; }
    }
}
