using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThuVien.Areas.Manager.ViewModels;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Authorize]
    public class TheLoaiController : Controller
    {
        private readonly ITheLoaiService theLoaiService;

        public TheLoaiController(ITheLoaiService theLoaiService)
        {
            this.theLoaiService = theLoaiService;
        }

        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 10;
            int count;
            var theLoais = theLoaiService.GetTheLoais(sortOrder, searchString, pageIndex, pageSize, out count);
            var theLoaiNew = new TheLoaiDTO();

            var theLoaiVM = new TheLoaiIndexVm()
            {
                TheLoais = new PaginatedList<TheLoaiDTO>(theLoais, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                theLoai = theLoaiNew
            };

            return View(theLoaiVM);
        }

        [HttpPost]
        public IActionResult Them(TheLoaiIndexVm theLoaiVM)
        {
            if (ModelState.IsValid)
            {
                theLoaiService.TaoTheLoai(theLoaiVM.theLoai);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Sua(int maTL)
        {
            var theLoai = theLoaiService.GetTheLoai(maTL);

            return View(theLoai);
        }

        [HttpPost]
        public IActionResult Sua(TheLoaiIndexVm theLoaiVm)
        {
            if (ModelState.IsValid)
            {
                theLoaiService.SuaTheLoai(theLoaiVm.theLoai);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Xoa(TheLoaiIndexVm theLoaiVm)
        {
            theLoaiService.XoaTheLoai(theLoaiVm.theLoai.MaTL);
            return RedirectToAction("Index");
        }
    }
}