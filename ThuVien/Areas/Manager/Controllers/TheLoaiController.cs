using Application.DTOs;
using Application.Interfaces;
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
                theLoaiDto = theLoaiNew
            };

            return View(theLoaiVM);
        }

        public IActionResult Them()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Them(TheLoaiIndexVm theLoaiVM)
        {
            if (ModelState.IsValid)
            {
                theLoaiService.TaoTheLoai(theLoaiVM.theLoaiDto);
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
        public IActionResult Sua(TheLoaiIndexVm theLoaiVM)
        {
            if (ModelState.IsValid)
            {
                theLoaiService.SuaTheLoai(theLoaiVM.theLoaiDto);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult ChiTiet(int maTL)
        {
            var theLoai = theLoaiService.GetTheLoai(maTL);
            return View(theLoai);
        }

        public IActionResult Xoa(int maTL)
        {
            var theLoai = theLoaiService.GetTheLoai(maTL);
            return View(theLoai);
        }

        [HttpPost]
        public IActionResult Xoa(int maTL, bool notUsed)
        {
            theLoaiService.XoaTheLoai(maTL);
            return RedirectToAction("Index");
        }
    }
}