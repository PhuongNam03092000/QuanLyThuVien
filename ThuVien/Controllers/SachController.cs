using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThuVien.Helpers;
using ThuVien.ViewModels;

namespace ThuVien.Controllers
{
    public class SachController : Controller
    {
        private readonly ISachService sachService;

        public SachController(ISachService sachService)
        {
            this.sachService = sachService;
        }

        public IActionResult Index(string sortOrder, string theloaiSach, string searchString, int pageIndex = 1)
        {
            int pageSize = 5;
            int count;
            var sachs = sachService.GetSachs(sortOrder, theloaiSach, searchString, pageIndex, pageSize, out count);
            var theloais = sachService.GetTheLoais();

            var indexVM = new IndexViewModel()
            {
                Sachs = new PaginatedList<SachDto>(sachs, count, pageIndex, pageSize),
                TheLoais = new SelectList(theloais),
                TheLoaiSach = theloaiSach,
                SearchString = searchString,
                SortOrder = sortOrder
            };

            return View(indexVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SachDto sach)
        {
            if (ModelState.IsValid)
            {
                sachService.ThemSach(sach);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            var sach = sachService.GetSach(id);

            return View(sach);
        }

        [HttpPost]
        public IActionResult Edit(SachDto sach)
        {
            if (ModelState.IsValid)
            {
                sachService.SuaSach(sach);

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Details(int id)
        {
            var sach = sachService.GetSach(id);

            return View(sach);
        }

        public IActionResult Delete(int id)
        {
            var sach = sachService.GetSach(id);

            return View(sach);
        }

        [HttpPost]
        public IActionResult Delete(int id, bool notUsed)
        {
            sachService.XoaSach(id);

            return RedirectToAction("Index");
        }
    }
}