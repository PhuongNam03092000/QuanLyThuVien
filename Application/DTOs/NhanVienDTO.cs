using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTOs
{
    public class NhanVienDTO
    {
        [Display(Name = "Mã nhân viên")]
        public int MaNV { get; set; }
      
        [Required]
        [Display(Name = "UserName")]
        public string UsernameNV { get; set; }
        
        [Display(Name = "Password")]
        public string PasswordNV { get; set; }
        

        [Display(Name = "Họ nhân viên")]
        public string HoNV { get; set; }

        [Display(Name = "Tên nhân viên")]
        public string TenNV { get; set; }
      
        [Display(Name = "Ngày sinh nhân viên")]
        public DateTime DoBNV { get; set; }

        [Display(Name = "Số điện thoại")]
        public int SdtNV { get; set; }

        [Display(Name = "Email nhân viên")]
        public string EmailNV { get; set; }

        [Display(Name = "Địa chỉ nhân viên")]
        public string DiaChiNV { get; set; }
        
    }
}
