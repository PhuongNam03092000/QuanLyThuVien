
using System.Threading.Tasks;
using Application.DTOs;
using Application.Service.Users;
using Microsoft.AspNetCore.Mvc;
namespace QLTV.Controllers
{
   
    public class LoginController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid)
                return View(ModelState);

            var token = await _userApiClient.Authenticate(request);

            return View(token);
        }
    }
   
}
