using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PhieuMuon
    {
        public char MaPM { set; get; }
        public DocGia DocGia { get; set; }
        public char MaDG { set; get; }
        public DateTime NgayMuon { set; get; }
        public int TongPhiMuon { set; get; }       
        public List<ChiTietPhieuMuon> DSChiTietPhieuMuon { get; set; } 
        public AppUser AppUser { get; set; }
        public Guid UserId { set; get; }
    }
}