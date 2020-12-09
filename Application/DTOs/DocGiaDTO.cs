using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTOs
{
    public class DocGiaDTO
    {
        [Display(Name="Mã độc giả")]
        public int MaDG { set; get; }

        [Required]
        [Display(Name ="Họ độc giả")]
        public string HoDG { set; get; }
        
        [Required]
        [Display(Name = "Tên độc giả")]
        public string TenDG { set; get; }
        
        [DataType(DataType.Date)]
        public DateTime DoBDG { set; get; }

        public string EmailDG { set; get; }
        
        public string DiaChiDG { set; get; }
        
        [DataType(DataType.Date)]
         public DateTime NgayDK { set; get; }
        
        [DataType(DataType.Date)]
        public DateTime NgayHetHanDK { set; get; }

    }
}
