using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PhieuTra
    {
        public char MaPT { set; get; }
        public DocGia DocGia { get; set; }
        public char MaDG { set; get; }
        public DateTime NgayTra { set; get; }
        public int TongPhiTra { set; get; }
        public List<ChiTietPhieuTra> DSChiTietPhieuTra { get; set; }
        public AppUser AppUser { get; set; }
        public Guid UserId { set; get; }
    }
}