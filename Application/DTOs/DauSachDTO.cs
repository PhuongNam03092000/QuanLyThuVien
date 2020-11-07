using System;
using System.Collections.Generic;
using System.Text;
// Entity là dùng để lưu dữ liệu còn DTO là dùng để lấy ra và hiển thị dữ liệu lên View

namespace Application.Dtos
{
    public class DauSachDTO
    {
        public string MaDS { set; get; }
        public string MaTL { set; get; }
        public string MaTG { set; get; }
        public string MaNXB { set; get; }
        public string TenDS { set; get; }
        public int SoLuongDS { set; get; }
        public string HinhAnh { set; get; }
    }
}
