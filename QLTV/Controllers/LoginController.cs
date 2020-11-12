using Microsoft.AspNetCore.Mvc;
using QLTV.Services;
using System.Threading.Tasks;

namespace QLTV.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("index","admin");
            }
            return RedirectToAction("index");
        }

    }
}
   