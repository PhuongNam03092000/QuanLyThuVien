﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Entities;

namespace ThuVien.Areas.Manager.ViewModels
{
    public class UserClaimsViewModel
    {
        public string userID { get; set; }
        public List<UserClaim> UserClaims { get; set; }

        public UserClaimsViewModel()
        {
            UserClaims = new List<UserClaim>();
        }

    }
}
