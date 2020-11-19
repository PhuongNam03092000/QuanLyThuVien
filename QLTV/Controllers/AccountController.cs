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
        private readonly UserManager<AppUser> userManager;
        public AccountController(SignInManager<AppUser> signInManager,UserManager<AppUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        // GET: LoginController
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginRequest,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginRequest.UserName, loginRequest.Password, true, false);
                if (result.Succeeded)
                {
                    if(!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToRoute("trangchu");
                    }
                }
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không hợp lệ");
            }
            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginRequest loginRequest)
        {
            if(ModelState.IsValid)
            {
                var user = new AppUser {UserName=loginRequest.UserName,Email = loginRequest.UserName ,DiaChiNV="123",HoNV="Truong",TenNV="Dat Nhan"};
                var result = await userManager.CreateAsync(user, loginRequest.Password);
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không hợp lệ");
                if(result.Succeeded)
                {
                    RedirectToAction("index");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index");
        }
        

    }
}
   