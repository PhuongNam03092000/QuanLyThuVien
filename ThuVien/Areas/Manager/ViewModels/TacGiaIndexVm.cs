using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.ViewModels
{
    public class TacGiaIndexVm
    {
        public PaginatedList<TacGiaDTO> TacGias { get; set; }
        public TacGiaDTO tacgiaDto { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
    }
}
