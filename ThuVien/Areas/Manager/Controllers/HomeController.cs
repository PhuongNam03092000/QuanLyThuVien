using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ThuVien.Areas.Manager.Controllers
{
    [Area("manager")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}