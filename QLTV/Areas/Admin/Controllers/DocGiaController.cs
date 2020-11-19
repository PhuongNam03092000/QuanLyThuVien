using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QLTV.Helpers;
using QLTV.ViewModel;

namespace QLTV.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class DocGiaController : Controller
    {
        private readonly IDocGiaService docgiaService;
        public DocGiaController(IDocGiaService docgiaService)
        {
            this.docgiaService = docgiaService;
        }

        public IActionResult Index()
            
        {
            var dsdocgia = docgiaService.GetDSDocGia();
            var newDG = new DocGiaDTO();
            var indexVM = new IndexViewModelDocGia()
            {
                DSDocGia = new PaginatedList<DocGiaDTO>(dsdocgia, 0, 0, 3),
                docgiamoi = newDG
            };
            return View(indexVM);
        }

        public IActionResult GetAll()
        {
            var model = docgiaService.GetDSDocGia();
            return View(model);
        }
        [HttpGet("MaDG")]
        public IActionResult Get(int MaDG)
        {
            var docgia = docgiaService.GetDocGia(MaDG);
            return RedirectToAction("Index");
        }


        [HttpPost]
        //public IActionResult Create(DocGiaDTO docGia)
        public IActionResult Create(IndexViewModelDocGia vm)
        {
            if (ModelState.IsValid)
            {
                docgiaService.CreateDocGia(vm.docgiamoi);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPut("{id}")]
        public IActionResult Edit([FromBody] DocGiaDTO docgia)
        {
            if (ModelState.IsValid)
            {
                docgiaService.UpdateDocGia(docgia);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpDelete("{MaDG}")]
        public IActionResult Delete(int MaDG)
        {
            docgiaService.DeleteDocGia(MaDG);
            return RedirectToAction("Index");
        }
    }
}

