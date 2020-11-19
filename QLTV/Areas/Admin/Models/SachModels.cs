using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;

namespace QLTV.Areas.Admin.Models
{
    public class SachModels
    {
        public IEnumerable<SachDTO> tempIE { get; set; }
        public List<SachDTO> tempList { set; get; }
    }
}
