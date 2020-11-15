using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QLTV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SachController : Controller
    {
        private readonly ISachService sachService;
        public SachController(ISachService sachService)
        {
            this.sachService = sachService;
        }

       

        [HttpPost]
        public IActionResult Create(SachDTO sach)
        {
            if (ModelState.IsValid)
            {
                sachService.CreateSach(sach);
                return RedirectToAction("Index");
            }
            return View();
        }
        
    
      

        

        
    }
}
