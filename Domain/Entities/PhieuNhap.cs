using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PhieuNhap
    {
        public int MaPN { set; get; }
        public NhaCungCap NhaCungCap {set; get; }
        public int MaNCC { set; get; }
        public DateTime NgayNhap { set; get; }
        public int TongTienNhap { set; get; }
        public List<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public AppUser AppUser { get; set; }
        public Guid UserId { set; get; }
    }
}