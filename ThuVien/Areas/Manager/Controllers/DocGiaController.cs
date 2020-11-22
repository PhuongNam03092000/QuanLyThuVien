using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThuVien.Areas.Manager.ViewModels;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.Controllers
{
    [Area("Manager")]
    //[Route("[Area]/[Controller]/[Action]")]
    [Authorize]
    public class DocGiaController : Controller
    {
        private readonly IDocGiaService docGiaService;

        public DocGiaController(IDocGiaService docgiaService)
        {
            this.docGiaService = docgiaService;
        }

        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 4;
            int count;
            var dsdocgia = docGiaService.GetDSDocGia(sortOrder, searchString, pageIndex, pageSize, out count);
            var docGia = new DocGiaDTO();
            var docgiaVM = new DocGiaIndexVm()
            {
                DocGias = new PaginatedList<DocGiaDTO>(dsdocgia, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                docgia = docGia
            };

            return View(docgiaVM);
        }

        public IActionResult Create(DocGiaIndexVm vm)
        {
            if (ModelState.IsValid)
            {
                docGiaService.CreateDocGia(vm.docgia);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(DocGiaIndexVm vm)
        {
            docGiaService.DeleteDocGia(vm.docgia.MaDG);

            return RedirectToAction("Index");
        }

        /*public string Delete(DocGiaIndexVm vm)
        {
            if(vm.docgia.HoDG.Length ==0 || vm.docgia.HoDG == null)
            {
                return "Cặt";
            } else
            {
                return vm.docgia.HoDG;
            }
        }*/

        public IActionResult Update(DocGiaIndexVm vm)
        {
            if (ModelState.IsValid)
            {
                docGiaService.UpdateDocGia(vm.docgia);

                return RedirectToAction("Index");
            }

            return View("index");
        }
    }
}