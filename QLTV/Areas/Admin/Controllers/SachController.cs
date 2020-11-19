using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QLTV.Areas.Admin.Models;

namespace QLTV.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SachController : Controller
    {
        // gọi hàm lấy dữ liệu từ app
        private readonly ISachService sachService;  
        public SachController(ISachService sachService)
        {
            this.sachService = sachService;
        }
        public IActionResult Index()
        {
            var sach = new SachModels();
            sach.tempList = this.sachService.GetAll().ToList();
            return View(sach);
        } 
    }
}
