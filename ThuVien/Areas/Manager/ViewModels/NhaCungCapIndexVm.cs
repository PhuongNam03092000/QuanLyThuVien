using Application.DTOs;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.ViewModels
{
    public class NhaCungCapIndexVm
    {
        public PaginatedList<NhaCungCapDTO> NhaCungCaps { get; set; }
        public NhaCungCapDTO nhacungCap { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
    }
}
