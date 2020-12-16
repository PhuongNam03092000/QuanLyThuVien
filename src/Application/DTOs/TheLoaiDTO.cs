using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class TheLoaiDTO
    {
        [Display(Name = "Mã thể loại")]
        public int MaTL { get; set; }

        [Required]
        [Display(Name = "Tên thể loại")]
        public string TenTL { get; set; }
    }
}