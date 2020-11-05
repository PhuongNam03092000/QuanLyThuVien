using System;

namespace Domain.Entities
{
    public class ChiTietPhieuTra
    {
        public PhieuTra PhieuTra { get; set; }
        public char MaPT { set; get; }
        public Sach Sach { get; set; }
        public char MaSach { set; get; }
        public TrangThaiSach TrangThaiSachTra {set; get; }   
        public int PhiTra { set; get; }
    }
}