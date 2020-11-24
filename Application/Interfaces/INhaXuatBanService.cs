﻿using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface INhaXuatBanService
    {
        IEnumerable<NhaXuatBanDTO> GetNhaXuatBans(string sortOrder, string searchString, int pageIndex, int pageSize, out int count);

        NhaXuatBanDTO GetNhaXuatBan(int maNXB);

        void ThemNhaXuatBan(TheLoaiDTO theLoai);

        void SuaTheLoai(TheLoaiDTO theLoai);

        void XoaTheLoai(int maTL);
    }
}