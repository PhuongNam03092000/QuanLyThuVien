using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class PhieuMuonDTO
    {
        public int MaPM { get; set; }
        public int MaDG { set; get; }
        public DateTime NgayMuon { set; get; }
        public int TongPhiMuon { set; get; }
        public int UserId { set; get; }
        public List<ChiTietPhieuMuonDTO> ChiTietPhieuMuons { get; set; }
    }
}
