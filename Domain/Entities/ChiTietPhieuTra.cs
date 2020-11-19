namespace Domain.Entities
{
    public class ChiTietPhieuTra
    {
        public PhieuTra PhieuTra { get; set; }
        public int MaPT { set; get; }
        public Sach Sach { get; set; }
        public int MaSach { set; get; }
        public string TrangThaiSachTra { set; get; }
        public int PhiTra { set; get; }
    }
}