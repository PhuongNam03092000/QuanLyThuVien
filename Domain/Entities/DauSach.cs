using System.Collections.Generic;

namespace Domain.Entities
{
    public class DauSach
    {
        public char MaDS { set; get; }
        public TheLoai TheLoai { set; get; }
        public char MaTL { set; get; }
        public TacGia TacGia { set; get; }
        public char MaTG { set; get; }
        public NhaXuatBan NhaXuatBan { set; get; }
        public char MaNXB { set; get; }
        public string TenDS { set; get; }
        public int SoLuongDS { set; get; }
        public List<Sach> DSSach { get; set; }
        public List<ChiTietPhieuNhap> DSChiTietPhieuNhap { get; set; }
    }
}