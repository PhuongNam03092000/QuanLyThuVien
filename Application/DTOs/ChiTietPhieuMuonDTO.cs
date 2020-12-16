using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTOs
{
    public class ChiTietPhieuMuonDTO
    {
        public int MaPM { set; get; }
        public int MaSach { set; get; }
        public int PhiMuon { set; get; }
        public DateTime NgayHetHan { set; get; }
        public DateTime GiaHan { set; get; }
        public bool IsSelected { get; set; }
    }
}
