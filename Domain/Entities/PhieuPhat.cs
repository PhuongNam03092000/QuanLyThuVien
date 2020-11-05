using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PhieuPhat
    {
        public string MaPP { set; get; }
        public DocGia DocGia { set; get; }
        public string MaDG { set; get; }
        public int TongPhiPhat { set; get; }
        public List<ChiTietPhieuPhat> DSChiTietPhieuPhat { get; set; }
        public AppUser AppUser { get; set; }
        public Guid UserId { set; get; }
    }
}