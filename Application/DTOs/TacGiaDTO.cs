﻿using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class TacGiaDTO
    {
        [Display(Name = "Mã tác giả")]
        public int MaTL { get; set; }

        [Required]
        [Display(Name = "Tên tác giả")]
        public string TenTL { get; set; }
    }
}