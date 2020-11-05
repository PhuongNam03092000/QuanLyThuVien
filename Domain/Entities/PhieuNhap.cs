using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PhieuNhap
    {
        public string MaPN { set; get; }
        public NhaCungCap NhaCungCap {set; get; }
        public string MaNCC { set; get; }
        public DateTime NgayNhap { set; get; }
        public int TongTienNhap { set; get; }
        public List<ChiTietPhieuNhap> DSChiTietPhieuNhap { get; set; }
        public AppUser AppUser { get; set; }
        public Guid UserId { set; get; }
    }
}