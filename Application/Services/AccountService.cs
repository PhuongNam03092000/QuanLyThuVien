using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateUserAsync(SignUpDTO signUpDTO)
        {
            var user = new AppUser()
            {
                //mapping trực tiếp
                HoNV = signUpDTO.HoNV,
                TenNV = signUpDTO.TenNV,
                DoBNV = signUpDTO.DoBNV,
                PhoneNumber = signUpDTO.PhoneNumber,
                Email = signUpDTO.Email,
                UserName = signUpDTO.Email
            };

            var result = await _userManager.CreateAsync(user, signUpDTO.Password);
            return result;
        }

        public async Task<SignInResult> PasswordSignInAsync(LogInDTO logInDTO)
        {
            return await _signInManager.PasswordSignInAsync(logInDTO.Email, logInDTO.Password, logInDTO.RememberMe, true);
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}