using Domain.Entities;
using Microsoft.AspNetCore.Http;
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
        [Display(Name = "Tên sách")]
        public string TenSach { set; get; }
        public int MaTG { set; get; }
        public string TenTG { set; get; }
        public int MaNXB { set; get; }
        public string TenNXB { get; set; }
        public int MaTL { set; get; }
        public string TenTL { set; get; }
        public int GiaBia { set; get; }
        public string ViTri { set; get; }
        public IFormFile SachImage { set; get; }
        public string SachImageUrl { get; set; }
    }
}