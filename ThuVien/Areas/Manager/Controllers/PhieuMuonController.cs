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

        public PhieuMuonController(IPhieuMuonService phieumuonService)
        {
            this.phieuMuonService = phieumuonService;
        }

        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 4;
            int count;
            var dsdocgia = phieuMuonService.GetPhieuMuons(sortOrder, searchString, pageIndex, pageSize, out count);
            var phieumuon = new PhieuMuonDTO();
            var ctpm = new ChiTietPhieuMuonDTO();
            var phieumuonVM = new PhieuMuonIndexVm()
            {
                PhieuMuons = new PaginatedList<PhieuMuonDTO>(dsdocgia, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                phieumuon = phieumuon,
                ctpm = ctpm
            };
            return View(phieumuonVM);
        }

        public IActionResult AddCTPM(int i, PhieuMuonIndexVm vm)
        {
            System.Console.WriteLine(vm.ctpm.MaSach);
            return View();
        }
    }
}