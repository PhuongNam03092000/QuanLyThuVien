using System.Collections.Generic;

namespace Domain.Entities
{
    public class DauSach
    {
        public string MaDS { set; get; }
        public TheLoai TheLoai { set; get; }
        public string MaTL { set; get; }
        public TacGia TacGia { set; get; }
        public string MaTG { set; get; }
        public NhaXuatBan NhaXuatBan { set; get; }
        public string MaNXB { set; get; }
        public string TenDS { set; get; }
        public int SoLuongDS { set; get; }
        public string HinhAnh { set; get; }
        public List<Sach> DSSach { get; set; }
        public List<ChiTietPhieuNhap> DSChiTietPhieuNhap { get; set; }
    }
}