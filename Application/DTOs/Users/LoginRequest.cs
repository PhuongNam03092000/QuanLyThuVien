using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class LoginRequest
    {
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}
