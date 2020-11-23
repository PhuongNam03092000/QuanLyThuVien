using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class SachDTO
    {
        public int MaSach { set; get; }
        public string TenSach { set; get; }
        public int MaTG { set; get; }
        public int MaNXB { set; get; }
        public int MaTL { set; get; }
        public int GiaBia { set; get; }
        public string SachImage { get; set; }
        public string ViTri { set; get; }
        public string TrangThaiSach { set; get; }
    }
}
