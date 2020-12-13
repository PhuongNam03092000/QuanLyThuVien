using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuVien.Areas.Manager.ViewModels;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Authorize]
    public class SachController : Controller
    {
        private readonly ISachService sachService;
        private readonly ITheLoaiRepository theLoaiRepository;
        private readonly ITacGiaRepository tacGiaRepository;
        private readonly INhaXuatBanRepository nhaXuatBanRepository;

        public SachController(ISachService sachService, ITheLoaiRepository theLoaiRepository, ITacGiaRepository tacGiaRepository, 
            INhaXuatBanRepository nhaXuatBanRepository)
        {
            this.sachService = sachService;
            this.theLoaiRepository = theLoaiRepository;
            this.tacGiaRepository = tacGiaRepository;
            this.nhaXuatBanRepository = nhaXuatBanRepository;
        }

        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 10;
            int count;
            var sachs = sachService.GetSachs(sortOrder, searchString, pageIndex, pageSize, out count);
            var sachNew = new SachDTO();

            var sachVM = new SachIndexVm()
            {
                Sachs = new PaginatedList<SachDTO>(sachs, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                sach = sachNew,
            };

            ViewBag.laytheloai = theLoaiRepository.LayTheLoai();
            ViewBag.laytacgia = tacGiaRepository.LayTacGia();
            ViewBag.laynxb = nhaXuatBanRepository.LayNXB();

            return View(sachVM);
        }

        [HttpPost]
        public IActionResult Them(SachIndexVm sachVM)
        {
            if (ModelState.IsValid)
            {
                sachService.ThemSach(sachVM.sach);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Sua(SachIndexVm sachVm)
        {
            if (ModelState.IsValid)
            {
                sachService.SuaSach(sachVm.sach);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Xoa(SachIndexVm sachVm)
        {
            sachService.XoaSach(sachVm.sach.MaSach);
            return RedirectToAction("Index");
        }
    }
}