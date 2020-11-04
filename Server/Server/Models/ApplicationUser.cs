﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName="nvarchar(100)")]
        public string FirstName { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string LastName { get; set; }

        [ForeignKey("Id")]
        public virtual ICollection<UserScore> UserScore { get; set; }
    }
}
