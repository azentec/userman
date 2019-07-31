using System;
using Microsoft.AspNetCore.Identity;

namespace Sampekey.Model
{
    public class UserRole : IdentityUserRole<string>
    {
        public Role Role { get; set; }
        public User User { get; set; }
    }
}