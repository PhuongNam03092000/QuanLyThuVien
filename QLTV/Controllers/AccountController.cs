using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QLTV.Services;
using System.Threading.Tasks;

namespace QLTV.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;
        public AccountController(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;   
        }

        // GET: LoginController
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if(ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginRequest.UserName, loginRequest.Password,true,false);
                if(result.Succeeded)
                {
                    return RedirectToAction("index", "admin");
                }
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không hợp lệ");
            }
            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginRequest loginRequest)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginRequest.UserName, loginRequest.Password, true, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "admin");
                }
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không hợp lệ");
            }
            return RedirectToAction("index");
        }

    }
}
   