using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QLTV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocGiaController : Controller
    {
        private readonly IDocGiaService docgiaService;
        public DocGiaController(IDocGiaService docgiaService)
        {
            this.docgiaService = docgiaService;
        }



        [HttpPost]

       
        public async Task<IActionResult> Create(DocGiaDTO docGia)
        {
            if (ModelState.IsValid)
            {
                docgiaService.CreateDocGia(docGia);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int MaDG)
        {
            docgiaService.DeleteDocGia(MaDG);
            return RedirectToAction("index", "admin");
        }
        
    }
}
