using Domain.Entities.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class NhaXuatBan : IAggregateRoot
    {
        public int MaNXB { set; get; }
        public string TenNXB { set; get; }
        public List<Sach> Sachs { get; set; }
    }
}