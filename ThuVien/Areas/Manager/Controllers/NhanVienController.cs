﻿using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ThuVien.Areas.Manager.ViewModels;
using ThuVien.Helper;

namespace ThuVien.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Authorize]
    public class NhanVienController : Controller
    {
        private readonly INhanVienService nhanVienService;
        private readonly UserManager<AppUser> userManager;

        public NhanVienController(INhanVienService nhanVienService, UserManager<AppUser> userManager)
        {
            this.nhanVienService = nhanVienService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 10;
            int count;
            var nhanViens = nhanVienService.GetNhanViens(sortOrder, searchString, pageIndex, pageSize, out count);
            var nhanVienNew = new NhanVienDTO();

            

            var test = nhanViens.ToList();

            foreach (var nhanVien in test)
            {
                var user = await userManager.FindByIdAsync(nhanVien.Id.ToString());
                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with ID= {nhanVien.Id.ToString()} not found.";
                }

                var currentUserClaims = await userManager.GetClaimsAsync(user);

                foreach (Claim claim in ClaimsStore.AllClaims.Where(c => c.Type != "Role"))
                {
                    var userClaim = new UserClaim
                    {
                        ClaimType = claim.Type
                    };

                    if (currentUserClaims.Any(c => c.Type == claim.Type))
                    {
                        userClaim.IsSelected = true;
                    }
                    nhanVien.UserClaims.Add(userClaim);
                }

                if (currentUserClaims.Any(c => c.Type == "Role" && c.Value == "Librarian"))
                {
                    nhanVien.Role = Role.Librarian;
                    nhanVien.UserClaims.RemoveRange(3, 2);
                }
                else
                {
                    if (currentUserClaims.Any(c => c.Type == "Role" && c.Value == "Admin") )
                    {
                        nhanVien.Role = Role.Admin;
                    }
                }
            }


            var nhanVienVM = new NhanVienIndexVm()
            {
                NhanViens = new PaginatedList<NhanVienDTO>(test, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder,
                nhanVien = nhanVienNew
            };

            return View(nhanVienVM);
        }       

        [HttpPost]
        public async Task<IActionResult> Them(NhanVienIndexVm nhanVienVM)
        {
            if (ModelState.IsValid)
            {
                await nhanVienService.ThemNhanVien(nhanVienVM.nhanVien);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Sua(NhanVienIndexVm nhanVienVM)
        {
            if (ModelState.IsValid)
            {
                await nhanVienService.SuaNhanVien(nhanVienVM.nhanVien);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Permission(NhanVienIndexVm vm)
        {
            var user = await userManager.FindByIdAsync(vm.nhanVien.Id.ToString());

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with ID= {vm.nhanVien.Id} not found.";
                RedirectToAction("index");
            }

            var currentUserClaims = await userManager.GetClaimsAsync(user);
            /*var result = await userManager.RemoveClaimsAsync(user, currentUserClaims);

            if(!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Can't remove existing user claims");
                return View(model);
            }*/

            // result = await userManager.AddClaimsAsync(user, 
            //    model.UserClaims.Where(c => c.IsSelected).Select(c => new Claim(c.ClaimType, "true")));

            if (currentUserClaims.Any(c => c.Type == "Role" && c.Type == "Admin"))
            {
                if (vm.nhanVien.Role == Role.Librarian)
                {
                    vm.nhanVien.UserClaims.RemoveRange(3, 2);
                    var result = await userManager.RemoveClaimsAsync(user, currentUserClaims);

                    if (!result.Succeeded)
                    {
                        ModelState.AddModelError(string.Empty, "Can't remove existing user claims");
                        return View(vm);
                    }
                    result = await userManager.AddClaimsAsync(user,
                    vm.nhanVien.UserClaims.Where(c => c.IsSelected).Select(c => new Claim(c.ClaimType, "true")));
                    var result1 = await userManager.AddClaimAsync(user, new Claim("Role", "Librarian"));
                    if (!result.Succeeded && !result1.Succeeded)
                    {
                        ModelState.AddModelError(string.Empty, "Can't add user claims");
                        return View(vm);
                    }
                }
            }
            else
            {
                var result = await userManager.RemoveClaimsAsync(user, currentUserClaims);

                if (!result.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "Can't remove existing user claims");
                    return View(vm);
                }
                result = await userManager.AddClaimsAsync(user,
                vm.nhanVien.UserClaims.Where(c => c.IsSelected).Select(c => new Claim(c.ClaimType, "true")));
                var result1 = await userManager.AddClaimAsync(user, new Claim("Role", vm.nhanVien.Role.ToString()));
                if (!result.Succeeded && !result1.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "Can't add user claims");
                    return View(vm);
                }
            }



            return View(vm);
        }

    }
}
