using Application.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThuVien.Helpers;

namespace ThuVien.ViewModels
{
    public class IndexViewModel
    {
        public PaginatedList<SachDto> Sachs { get; set; }
        public SelectList TheLoais { get; set; }
        public string TheLoaiSach { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
    }
}