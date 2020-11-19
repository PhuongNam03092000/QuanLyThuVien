using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QLTV.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class NVController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
