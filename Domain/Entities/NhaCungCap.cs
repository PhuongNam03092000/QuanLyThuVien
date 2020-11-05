using System.Collections.Generic;

namespace Domain.Entities
{
    public class NhaCungCap
    {
        public char MaNCC { set; get; }        
        public string TenNCC { set; get; }        
        public string DiaChiNCC { set; get; }        
        public string SdtNCC { set; get; }      
        public List<PhieuNhap> DSPhieuNhap { get; set; }
    }
}