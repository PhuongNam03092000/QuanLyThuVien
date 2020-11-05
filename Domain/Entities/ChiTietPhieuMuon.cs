using System;

namespace Domain.Entities
{
    public class ChiTietPhieuMuon
    {
        public PhieuMuon PhieuMuon { get; set; }
        public string MaPM { set; get; }
        public Sach Sach { get; set; }
        public string MaSach { set; get; }
        public int PhiMuon { set; get; }
        public DateTime NgayHetHan {set; get;}
        public DateTime GiaHan {set; get;}
    }
}