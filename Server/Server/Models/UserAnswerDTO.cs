using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class UserAnswerDTO
    {
        public string UserId { get; set; }

        public int QuizId { get; set; }

        public int QuestionId { get; set; }

        public int SelectedAnswer { get; set; }

    }
}
