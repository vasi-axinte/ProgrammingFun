using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        public UserManager<ApplicationUser> _userManager;

        public UserProfileController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
    
    
       [HttpGet]
       [Authorize(Roles = "Admin")]
       [Route("AdminRole")]
       public string GetForAdmin()
       {
            return "Web method for Admin";
       }

       [HttpGet]
       [Authorize(Roles = "User")]
       [Route("UserRole")]
       public string GetForUser()
       {
            return "Web method for User";
       }
    }
}
