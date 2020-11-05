using System.Collections.Generic;

namespace Domain.Entities
{
    public class TheLoai
    {
        public string MaTL { set; get; }
        public string TenTL { set; get; }
        public List<DauSach> DSDauSach { get; set; }
    }
}