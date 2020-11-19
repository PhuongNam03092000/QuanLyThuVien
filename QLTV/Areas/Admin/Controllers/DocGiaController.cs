using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
            return View();
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
        public IActionResult Create(DocGiaDTO docGia)
        {
            if (ModelState.IsValid)
            {
                docgiaService.CreateDocGia(docGia);
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

