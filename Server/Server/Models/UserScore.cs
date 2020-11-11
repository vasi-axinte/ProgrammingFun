using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class UserScore
    {
        public string UserId { get; set; }

        public int QuizId { get; set; }

        public int Score { get; set; }

        public Quiz Quiz { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
