using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
