using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Core.Entitys.identity
{

    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(250)]
        public string FirstName { get; set; }
        [Required, MaxLength(250)]

        public string LastName { get; set; }

        public DateTime LastloginTime { get; set; }

        public List<RefreshToken>? RefreshTokens { get; set; }

    }
}
