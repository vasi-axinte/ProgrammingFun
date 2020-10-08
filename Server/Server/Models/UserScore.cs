using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class UserScore
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public int Score { get; set; }
    }
}
