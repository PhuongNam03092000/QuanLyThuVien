using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ThuVien.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [Route("signup")]
        public IActionResult Signup()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> Signup(SignUpDTO signUpDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountService.CreateUserAsync(signUpDTO);
                if (!result.Succeeded)
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }

                    return View(signUpDTO);
                }

                ModelState.Clear();
                return RedirectToAction("Login", "Account");
            }

            return View(signUpDTO);
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(LogInDTO logInDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountService.PasswordSignInAsync(logInDTO);
                if (result.Succeeded)
                {
                    return RedirectToRoute("manager");
                }

                ModelState.AddModelError("", "Invalid credentials");
            }

            return View(logInDTO);
        }

        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            await _accountService.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}