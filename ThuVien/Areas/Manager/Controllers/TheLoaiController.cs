using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThuVien.Areas.Manager.ViewModels;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Route("[Area]/[Controller]/[Action]")]
    public class TheLoaiController : Controller
    {
        private readonly ITheLoaiService theLoaiService;

        public TheLoaiController(ITheLoaiService theLoaiService)
        {
            this.theLoaiService = theLoaiService;
        }

        //[Route("manager/theloai/index")]
        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 2;
            int count;
            var theLoais = theLoaiService.GetTheLoais(sortOrder, searchString, pageIndex, pageSize, out count);

            var theLoaiVM = new TheLoaiIndexVm()
            {
                TheLoais = new PaginatedList<TheLoaiDTO>(theLoais, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder
            };

            return View(theLoaiVM);
        }

        public IActionResult Them()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Them(TheLoaiDTO theLoai)
        {
            if (ModelState.IsValid)
            {
                theLoaiService.TaoTheLoai(theLoai);
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
        public IActionResult Sua(TheLoaiDTO theLoai)
        {
            if (ModelState.IsValid)
            {
                theLoaiService.SuaTheLoai(theLoai);
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