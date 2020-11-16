using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        public UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _dbContext;

        public UserProfileController(UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
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

        [HttpGet("{userId}")]
        public List<UserProfileDTO> GetUserProfile([FromRoute] string userId)
        {
            var result = _dbContext.ApplicationUsers.Where(ap => ap.Id == userId)
           .Select(ap => new UserProfileDTO
           {
               FirstName = ap.FirstName,
               LastName = ap.LastName,
           }).ToList();

            return result;
        }
    }
}
