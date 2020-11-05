using System.Collections.Generic;

namespace Domain.Entities
{
    public class NhaXuatBan
    {
        public char MaNXB { set; get; }
        public string TenNXB { set; get; }
        public List<DauSach> DSDauSach { get; set; }
    }
}