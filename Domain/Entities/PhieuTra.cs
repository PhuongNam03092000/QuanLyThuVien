using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PhieuTra
    {
        public string MaPT { set; get; }
        public DocGia DocGia { get; set; }
        public string MaDG { set; get; }
        public DateTime NgayTra { set; get; }
        public int TongPhiTra { set; get; }
        public List<ChiTietPhieuTra> DSChiTietPhieuTra { get; set; }
        public AppUser AppUser { get; set; }
        public Guid UserId { set; get; }
    }
}