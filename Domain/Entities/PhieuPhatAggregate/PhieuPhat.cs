using Domain.Entities.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PhieuPhat : IAggregateRoot
    {
        public int MaPP { set; get; }
        public DocGia DocGia { set; get; }
        public int MaDG { set; get; }
        public int TongPhiPhat { set; get; }
        public List<ChiTietPhieuPhat> ChiTietPhieuPhats { get; set; }
        public AppUser AppUser { get; set; }
        public Guid UserId { set; get; }
    }
}