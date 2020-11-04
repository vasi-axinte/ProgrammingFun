using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class UserScoreDTO
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string QuizName { get; set; }

        public int Score { get; set; }
    }
}
