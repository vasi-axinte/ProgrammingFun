using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class UserModel
    {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
    }
}
