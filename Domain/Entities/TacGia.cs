using System.Collections.Generic;

namespace Domain.Entities
{
    public class TacGia
    {
        public string MaTG { set; get; }    
        public string TenTG { set; get; }
        public List<DauSach> DSDauSach { get; set; }
    }
}