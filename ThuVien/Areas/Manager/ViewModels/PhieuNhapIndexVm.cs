using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.ViewModels
{
    public class PhieuNhapIndexVm
    {
        public PaginatedList<PhieuNhapDTO> PhieuNhaps { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
        public PhieuNhapDTO phieunhap { get; set; }
        public ChiTietPhieuNhapDTO ctpn { get; set; }
    }
}
