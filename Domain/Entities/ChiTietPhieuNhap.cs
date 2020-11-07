namespace Domain.Entities
{
    public class ChiTietPhieuNhap
    {
        public PhieuNhap PhieuNhap { set; get; }
        public int MaPN { set; get; }
        public Sach Sach { set; get; }
        public int MaSach { set; get; }
        public int SoLuongNhap { set; get; }
        public int DonGiaSach { set; get; }
    }
}