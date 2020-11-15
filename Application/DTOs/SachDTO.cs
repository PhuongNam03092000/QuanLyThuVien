using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
// Entity là dùng để lưu dữ liệu còn DTO là dùng để lấy ra và hiển thị dữ liệu lên View

namespace Application.Dtos
{
    public class SachDTO
    {

        public int MaSach { set; get; }
        public string TenSach { set; get; }
        public int MaTG { set; get; }
        public int MaNXB { set; get; }
        public int MaTL { set; get; }
        public int GiaBia { set; get; }
    }
}
