using System;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}