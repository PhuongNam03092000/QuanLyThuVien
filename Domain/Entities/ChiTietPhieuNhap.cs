namespace Domain.Entities
{
    public class ChiTietPhieuNhap
    {
        public PhieuNhap PhieuNhap { set; get; }
        public char MaPN { set; get; }
        public DauSach DauSach { set; get; }
        public char MaDS { set; get; }
        public int SoLuongNhap { set; get; }
        public int DonGiaSach { set; get; }
    }
}