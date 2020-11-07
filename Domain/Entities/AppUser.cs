using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class AppUser : IdentityUser<Guid> //Guid: kiểu duy nhất cho toàn hệ thống
    {
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public DateTime DoBNV { get; set; }
        public string DiaChiNV { get; set; }
        public List<PhieuNhap> PhieuNhaps { get; set; }
        public List<PhieuMuon> PhieuMuons { get; set; }
        public List<PhieuTra> PhieuTras { get; set; }
        public List<PhieuPhat> PhieuPhats { get; set; }
    }
}