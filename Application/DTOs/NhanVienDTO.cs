using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTOs
{
    public class NhanVienDTO
    {

        public int Id { get; set; }


        [Display(Name = "Password")]
        public string PasswordNV { get; set; }

        [Display(Name = "Họ nhân viên")]
        public string HoNV { get; set; }

        [Display(Name = "Tên nhân viên")]
        public string TenNV { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh nhân viên")]
        public DateTime DoBNV { get; set; }

        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }


        [Display(Name = "Email nhân viên")]
        public string Email { get; set; }


        [Display(Name = "Địa chỉ nhân viên")]
        public string DiaChiNV { get; set; }

        public List<UserClaim> UserClaims { get; set; }
        public Role Role { get; set; }

        public NhanVienDTO()
        {
            UserClaims = new List<UserClaim>();
        }
    }
}
