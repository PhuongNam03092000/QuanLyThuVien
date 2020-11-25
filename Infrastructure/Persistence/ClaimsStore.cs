using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Persistence
{
    class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
            new Claim("Borrow","Borrow"),
            new Claim("Create Member","Create Member"),
            new Claim("Edit Member","Edit Member"),
            new Claim("Delete Member","Delete Member"),
            new Claim("Create Employee","Member"),
            new Claim("Role","Member"),
            new Claim("Role","Librarian"),
            new Claim("Role","Admin")
        };
    }
}
