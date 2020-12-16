using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PhieuTra
    {
        public int MaPT { set; get; }
        public DocGia DocGia { get; set; }
        public int MaDG { set; get; }
        public DateTime NgayTra { set; get; }
        public int TongPhiTra { set; get; }
        public List<ChiTietPhieuTra> ChiTietPhieuTras { get; set; }
        public AppUser AppUser { get; set; }
        public int UserId { set; get; }

    }
}