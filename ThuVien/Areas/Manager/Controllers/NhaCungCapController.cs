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
    public class NhaCungCapController : Controller
    {
        private readonly INhaCungCapService nhacungCapService;

        public NhaCungCapController(INhaCungCapService nhacungCapService)
        {
            this.nhacungCapService = nhacungCapService;
        }

        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 10;
            int count;
            var nhacungCaps = nhacungCapService.GetNhaCungCaps(sortOrder, searchString, pageIndex, pageSize, out count);
            var nhacungCapNew = new NhaCungCapDTO();

            var nhacungCapVM = new NhaCungCapIndexVm()
            {
                NhaCungCaps = new PaginatedList<NhaCungCapDTO>(nhacungCaps, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                nhacungCap = nhacungCapNew
            };

            return View(nhacungCapVM);
        }

        [HttpPost]
        public IActionResult Them(NhaCungCapIndexVm nhacungCapVM)
        {
            if (ModelState.IsValid)
            {
                nhacungCapService.ThemNhaCungCap(nhacungCapVM.nhacungCap);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Sua(NhaCungCapIndexVm nhacungCapVM)
        {
            if (ModelState.IsValid)
            {
                nhacungCapService.SuaNhaCungCap(nhacungCapVM.nhacungCap);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Xoa(NhaCungCapIndexVm nhacungCapVM)
        {
            nhacungCapService.XoaNhaCungCap(nhacungCapVM.nhacungCap.MaNCC);
            return RedirectToAction("Index");
        }
    }
}
