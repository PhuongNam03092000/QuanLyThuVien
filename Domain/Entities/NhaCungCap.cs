using System.Collections.Generic;

namespace Domain.Entities
{
    public class NhaCungCap
    {
        public int MaNCC { set; get; }        
        public string TenNCC { set; get; }        
        public string DiaChiNCC { set; get; }        
        public string SdtNCC { set; get; }      
        public List<PhieuNhap> PhieuNhaps { get; set; }
    }
}