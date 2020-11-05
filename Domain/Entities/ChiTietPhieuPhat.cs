namespace Domain.Entities
{
    public class ChiTietPhieuPhat
    {
        public PhieuPhat PhieuPhat { get; set; }
        public string MaPP { set; get; }
        public Sach Sach { get; set; }
        public string MaSach { set; get; }
        public string NoiDungViPham { set; get; }
        public string XuLyViPham { set; get; }
        public int PhiPhat { set; get; }
    }
}