namespace Domain.Entities
{
    public class ChiTietPhieuNhap
    {
        public PhieuNhap PhieuNhap { set; get; }
        public string MaPN { set; get; }
        public DauSach DauSach { set; get; }
        public string MaDS { set; get; }
        public int SoLuongNhap { set; get; }
        public int DonGiaSach { set; get; }
    }
}