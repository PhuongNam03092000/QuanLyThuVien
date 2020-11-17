using Application.DTOs;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface INXBService
    {
        IEnumerable<NhaXuatBanDTO> GetDSNXB();
        NhaXuatBanDTO GetNXB(int MaNXB);
        void CreateNXB(NhaXuatBanDTO nxb);
        void UpdateNXB(NhaXuatBanDTO nxb);
        void DeleteNXB(int MaNXB);
    }
}
