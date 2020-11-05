using System.Collections.Generic;

namespace Domain.Entities
{
    public class Sach
    {
        public string MaSach { set; get; }
        public string MaDS { set; get; }
        public int GiaBia { set; get; }
        public string ViTri { set; get; }
        public TrangThaiSach TrangThaiSach { set; get; }
        public DauSach DauSach { get; set; }
        public List<ChiTietPhieuMuon> DSChiTietPhieuMuon { get; set; }
        public List<ChiTietPhieuTra> DSChiTietPhieuTra { get; set; }
        public List<ChiTietPhieuPhat> DSChiTietPhieuPhat { get; set; }
    }
}