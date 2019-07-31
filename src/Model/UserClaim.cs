using System;
using Microsoft.AspNetCore.Identity;

namespace Sampekey.Model
{
    public class UserClaim : IdentityUserClaim<string>
    {
        public User User { get; set; }
    }
}