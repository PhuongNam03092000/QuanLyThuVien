using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class DocGia
    {
        public string MaDG { set; get; }
        public string HoDG { set; get; }
        public string TenDG { set; get; }
        public DateTime DoBDG { set; get; }
        public string EmailDG { set; get; }
        public string DiaChiDG { set; get; }
        public DateTime NgayDK { set; get; }
        public DateTime NgayHetHanDK { set; get; }
        public TrangThaiThe TrangThaiThe { set; get;}
        public List<PhieuMuon> DSPhieuMuon { get; set;}
        public List<PhieuTra> DSPhieuTra { get; set;}
        public List<PhieuPhat> DSPhieuPhat { get; set;}
    }
}