using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class PhieuNhapController : Controller
    {        
        private readonly IPhieuNhapService phieuNhapService;
        private readonly ISachService sachService;

        public PhieuNhapController(IPhieuNhapService phieunhapService, ISachService sachService)
        {
            this.phieuNhapService = phieunhapService;
            this.sachService = sachService;
        }

        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 4;
            int count;
            var dsphieunhap = phieuNhapService.GetPhieuNhaps(sortOrder, searchString, pageIndex, pageSize, out count);
            var phieunhap = new PhieuNhapDTO();
            var ctpn = new ChiTietPhieuNhapDTO();

            var phieunhapVM = new PhieuNhapIndexVm()
            {
                PhieuNhaps = new PaginatedList<PhieuNhapDTO>(dsphieunhap, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                phieunhap = phieunhap,
                ctpn = ctpn
            };
            return View(phieunhapVM);
        }
        [HttpPost]
        public IActionResult Create(PhieuNhapIndexVm vm)
        {
            if (ModelState.IsValid)
            {
                phieuNhapService.CreatePhieuNhap(vm.phieunhap);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(PhieuNhapIndexVm vm)
        {
            if (ModelState.IsValid)
            {
                phieuNhapService.UpdatePhieuNhap(vm.phieunhap);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(PhieuNhapIndexVm vm)
        {
            if (ModelState.IsValid)
            {
                phieuNhapService.DeletePhieuNhap(vm.phieunhap.MaPN);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreateCTPN(PhieuNhapIndexVm vm)
        {
            if (ModelState.IsValid)
            {
                phieuNhapService.AddCTPN(vm.ctpn);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult UpdateCTPN(PhieuNhapIndexVm vm)
        {
            if (ModelState.IsValid)
            {
                phieuNhapService.AddCTPN(vm.ctpn);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCTPN(PhieuNhapIndexVm vm)
        {
            if (ModelState.IsValid)
            {
                phieuNhapService.DeleteCTPN(vm.phieunhap.ChiTietPhieuNhaps);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
