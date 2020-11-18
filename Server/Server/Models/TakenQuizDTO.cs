using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class TakenQuizDTO
    {
        public string UserId { get; set; }

        public int QuizId { get; set; }

        public int Score { get; set; }
    }
}
