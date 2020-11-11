using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        /*public async Task<IActionResult> Login()
        {
            return View();
        }*/
        public string Login(string email,string password)
        {
            return "đã nhận get"+email + password;
        }

    }
}
