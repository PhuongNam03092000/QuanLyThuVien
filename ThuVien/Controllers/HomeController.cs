using Microsoft.AspNetCore.Mvc;

namespace ThuVien.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}