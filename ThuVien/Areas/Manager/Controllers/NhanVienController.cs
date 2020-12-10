using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ThuVien.Areas.Manager.ViewModels;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Authorize]
    public class NhanVienController : Controller
    {
        private readonly INhanVienService nhanVienService;

        public NhanVienController(INhanVienService nhanVienService)
        {
            this.nhanVienService = nhanVienService;
        }

        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 10;
            int count;
            var nhanViens = nhanVienService.GetNhanViens(sortOrder, searchString, pageIndex, pageSize, out count);
            var nhanVienNew = new NhanVienDTO();

            var nhanVienVM = new NhanVienIndexVm()
            {
                NhanViens = new PaginatedList<NhanVienDTO>(nhanViens, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                nhanVien = nhanVienNew
            };

            return View(nhanVienVM);
        }       

        [HttpPost]
        public async Task<IActionResult> Them(NhanVienIndexVm nhanVienVM)
        {
            if (ModelState.IsValid)
            {
                await nhanVienService.ThemNhanVien(nhanVienVM.nhanVien);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Sua(NhanVienIndexVm nhanVienVM)
        {
            if (ModelState.IsValid)
            {
                await nhanVienService.SuaNhanVien(nhanVienVM.nhanVien);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
