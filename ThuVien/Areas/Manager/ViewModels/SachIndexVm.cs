using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.ViewModels
{
    public class SachIndexVm
    {
        public PaginatedList<SachDTO> Sachs { get; set; }
        public SachDTO sachDto { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
    }
}
