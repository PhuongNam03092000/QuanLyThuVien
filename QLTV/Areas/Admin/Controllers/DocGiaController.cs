using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QLTV.Helpers;
using QLTV.ViewModel;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QLTV.Controllers
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
            var newDocGiaDTO = new DocGiaDTO();
            var indexVM = new IndexViewModelDocGia()
            {
                DSDocGia = new PaginatedList<DocGiaDTO>(dsdocgia, 0, 0, 3),
                docgiamoi = newDocGiaDTO
            };
            return View(indexVM);
        }

        [HttpPost]
        public IActionResult Create([FromBody] DocGiaDTO docGia)
        {
            if (!ModelState.IsValid)
            {
                docgiaService.CreateDocGia(docGia);
                return BadRequest();
            }
            return View();
        }

        [HttpGet("MaDG")]
        public IActionResult Get(int MaDG)
        {
            var docgia = docgiaService.GetDocGia(MaDG);
            return RedirectToAction("Index");
        }

       
        [HttpPut("{MaDG}")]
        public IActionResult Edit([FromBody] DocGiaDTO docgia)
        {
            if (!ModelState.IsValid)
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
