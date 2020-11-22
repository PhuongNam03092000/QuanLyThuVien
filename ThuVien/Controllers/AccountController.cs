using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ThuVien.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly UserManager<AppUser> userManager;

        public AccountController(IAccountService accountService, UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
            _accountService = accountService;
        }

        [Route("signup")]
        [HttpGet]
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

        [Route("signuppro")]
        [HttpPost]
        public async Task<IActionResult> SignupPro(SignUpDTO signUpDTO)
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
                var user = await userManager.FindByNameAsync(signUpDTO.Email);
                var claim = await userManager.AddClaimAsync(user, new System.Security.Claims.Claim("Admin", "Admin"));

                if(claim.Succeeded)
                {
                    System.Diagnostics.Debug.WriteLine(claim);
                    return RedirectToAction("Login", "Account");
                }
                return View(signUpDTO);
            }

            return View(signUpDTO);
        }

        [Route("login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(LogInDTO logInDTO,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountService.PasswordSignInAsync(logInDTO);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToRoute("manager");
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid credentials");
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