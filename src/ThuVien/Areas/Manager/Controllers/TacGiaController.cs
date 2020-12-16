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
    public class TacGiaController : Controller
    {
        private readonly ITacGiaService tacGiaService;

        public TacGiaController(ITacGiaService tacGiaService)
        {
            this.tacGiaService = tacGiaService;
        }

        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 8;
            int count;
            var tacGias = tacGiaService.GetTacGias(sortOrder, searchString, pageIndex, pageSize, out count);
            var tacGiaNew = new TacGiaDTO();

            var tacGiaVM = new TacGiaIndexVm()
            {
                TacGias = new PaginatedList<TacGiaDTO>(tacGias, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                tacGia = tacGiaNew
            };

            return View(tacGiaVM);
        }

        [HttpPost]
        public IActionResult Them(TacGiaIndexVm tacGiaVM)
        {
            if (ModelState.IsValid)
            {
                tacGiaService.ThemTacGia(tacGiaVM.tacGia);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Sua(TacGiaIndexVm tacGiaVm)
        {
            if (ModelState.IsValid)
            {
                tacGiaService.SuaTacGia(tacGiaVm.tacGia);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Xoa(TacGiaIndexVm tacGiaVm)
        {
            tacGiaService.XoaTacGia(tacGiaVm.tacGia.MaTG);
            return RedirectToAction("Index");
        }
    }
}