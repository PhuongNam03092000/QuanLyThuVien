using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class NhaCungCapDTO
    {
        [Display(Name = "Mã nhà cung cấp")]
        public int MaNCC { get; set; }

        [Display(Name = "Tên nhà cung cấp")]
        public string TenNCC { get; set; }

        [Display(Name = "Địa chỉ nhà cung cấp")]
        public string DiaChiNCC { get; set; }

        [Display(Name = "SĐT nhà cung cấp")]
        public string SdtNCC { get; set; }
    }
}
