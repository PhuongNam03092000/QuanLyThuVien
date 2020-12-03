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

namespace QLTV.Controllers
{
    [Area("Manager")]
    //[Route("[Area]/[Controller]/[Action]")]
    [Authorize]
    public class PhieuMuonController : Controller
    {
        private readonly IPhieuMuonService phieuMuonService;
        private readonly ISachService sachService;

        public PhieuMuonController(IPhieuMuonService phieumuonService, ISachService sachService)
        {
            this.phieuMuonService = phieumuonService;
            this.sachService = sachService;
        }

        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 4;
            int count;
            var dsphieumuon = phieuMuonService.GetPhieuMuons(sortOrder, searchString, pageIndex, pageSize, out count);
            var phieumuon = new PhieuMuonDTO();
            var ctpm = new ChiTietPhieuMuonDTO();
            var listSach = sachService.GetSachs(sortOrder, searchString, pageIndex, pageSize, out count);
            var phieumuonVM = new PhieuMuonIndexVm()
            {
                PhieuMuons = new PaginatedList<PhieuMuonDTO>(dsphieumuon, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                phieumuon = phieumuon,
                ctpm = ctpm
            };
            return View(phieumuonVM);
        }

        [HttpPost]
        public IActionResult Create(PhieuMuonIndexVm vm)
        {
            if (ModelState.IsValid)
            {
                phieuMuonService.CreatePhieuMuon(vm.phieumuon);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(PhieuMuonIndexVm vm)
        {
            if (ModelState.IsValid)
            {
                phieuMuonService.UpdatePhieuMuon(vm.phieumuon);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(PhieuMuonIndexVm vm)
        {
            if(ModelState.IsValid)
            {
                phieuMuonService.DeletePhieuMuon(vm.phieumuon.MaPM);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreateCTPM(PhieuMuonIndexVm vm)
        {
            System.Console.WriteLine(vm.ctpm.MaSach);
            return View();
        }
    }
}