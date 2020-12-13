using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class ChiTietPhieuNhapDTO
    {
        public int MaPN { set; get; }
        public int MaSach { set; get; }
        public int SoLuongNhap { set; get; }
        public int DonGiaSach { set; get; }
        public bool IsSelected { get; set; }
    }
}
