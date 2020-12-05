using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTOs
{
    public class SachDTO
    {
        [Display(Name = "Mã sách")]
        public int MaSach { set; get; }

        [Required]
        [Display(Name = "Tên sách")]
        public string TenSach { set; get; }

        public int MaTG { set; get; }
        public int MaNXB { set; get; }
        public int MaTL { set; get; }
        public int GiaBia { set; get; }
        public string ViTri { set; get; }
    }
}