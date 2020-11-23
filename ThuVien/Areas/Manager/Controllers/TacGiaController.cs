using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThuVien.Areas.Manager.ViewModels;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.Controllers
{

    [Area("Manager")]
    //[Route("[Area]/[Controller]/[Action]")]
    [Authorize]
    public class TacGiaController : Controller
    {
        private readonly ITacGiaService tacGiaService;

        public TacGiaController(ITacGiaService tacgiaService)
        {
            this.tacGiaService = tacgiaService;
        }
        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 10;
            int count;
            var tacgias = tacGiaService.GetTacGias(sortOrder, searchString, pageIndex, pageSize, out count);
            var tacgiaDTO = new TacGiaDTO();

            var tacgiaVM = new TacGiaIndexVm()
            {
                TacGias = new PaginatedList<TacGiaDTO>(tacgias, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                tacgiaDto = tacgiaDTO
            };

            return View(tacgiaVM);
        }
    }
}
