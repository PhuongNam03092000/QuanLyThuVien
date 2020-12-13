using System.Collections.Generic;

namespace Domain.Entities
{
    public class Sach
    {
        public int MaSach { set; get; }
        public string TenSach { set; get; }
        public TacGia TacGia { set; get; }
        public int MaTG { set; get; }
        public NhaXuatBan NhaXuatBan { set; get; }
        public int MaNXB { set; get; }
        public TheLoai TheLoai { set; get; }
        public int MaTL { set; get; }
        public int GiaBia { set; get; }
        public string SachImageUrl { get; set; }
        public string ViTri { set; get; }
        public string TrangThaiSach { set; get; }
        public ChiTietPhieuNhap ChiTietPhieuNhap { get; set; }
        public List<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
        public List<ChiTietPhieuTra> ChiTietPhieuTras { get; set; }
        public List<ChiTietPhieuPhat> ChiTietPhieuPhats { get; set; }
    }
}