using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class SachImage
    {
        public int ImageId { get; set; }
        public Sach Sach { get; set; }
        public int MaSach { get; set; }
        public string ImagePath { get; set; }
        public string ImageCaption { get; set; }        
    }
}
