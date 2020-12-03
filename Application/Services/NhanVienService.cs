using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Application.Services
{
    public class NhanVienService : INhanVienService
    {
        private readonly INhanVienRepository _nhanVienRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAccountService _accountService;

        public NhanVienService(INhanVienRepository nhanVienRepository, UserManager<AppUser> userManager, IAccountService accountService)
        {
            _nhanVienRepository = nhanVienRepository;
            _userManager = userManager;
            _accountService = accountService;
        }

        public IEnumerable<NhanVienDTO> GetNhanViens(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var nhanViens = _nhanVienRepository.Filter(sortOrder, searchString, pageIndex, pageSize, out count);
            return nhanViens.MappingNhanVienDtos();
        }

        public NhanVienDTO GetNhanVien(int Id)
        {
            var nhanvien = _nhanVienRepository.GetBy(Id);

            return nhanvien.MappingNhanVienDto();
        }

        public void SuaNhanVien(NhanVienDTO nhanVienDto)
        {
        /*    var nhanVien = _nhanVienRepository.GetBy(nhanVienDto.Id);

            nhanVienDto.MappingNhanVien(nhanVien);

            _nhanVienRepository.Update(nhanVien);*/
        }

        public void ThemNhanVien(NhanVienDTO nhanVienDto)
        {
            var nhanVien = nhanVienDto.MappingNhanVien();
            //var result = _userManager.CreateAsync(nhanVien, nhanVienDto.PasswordNV);
            _accountService.CreateUserAsync(nhanVienDto);
            /*if(result.Succeeded)
            {
                System.Console.WriteLine("Thành công");
            } else
            {
                System.Console.WriteLine("Thất bại"); 
            }*/
            //_nhanVienRepository.Add(nhanVien);
        }

        public void XoaNhanVien(int Id)
        {
            var nhanVien = _nhanVienRepository.GetBy(Id);

            _nhanVienRepository.Delete(nhanVien);
        }
    }
}
