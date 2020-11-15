using Domain.Common;

namespace Domain.Entities
{
    public class Sach : EntityBase, IAggregateRoot
    {
        public string TenSach { set; get; }
        public string TheLoai { get; set; }
        public string TacGia { get; set; }
        public string NhaXuatBan { get; set; }
        public int GiaBia { set; get; }
        public string ViTri { set; get; }
    }
}