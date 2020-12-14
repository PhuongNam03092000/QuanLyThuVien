using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class PhieuNhapDTO
    {
        public int MaPN { get; set; }
        public int MaNCC { set; get; }
        public DateTime NgayNhap { set; get; }
        public int TongTienNhap { set; get; }
        public int UserId { set; get; }
        public List<ChiTietPhieuNhapDTO> ChiTietPhieuNhaps { get; set; }
    }
}
