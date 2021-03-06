
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sampekey.Model.Identity
{
    [Table("T_USER")]
    public class User : IdentityUser
    {
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public Boolean Active { get; set; } = true;
        public Boolean userFromActiveDirectory { get; set; } = false;
    }
}