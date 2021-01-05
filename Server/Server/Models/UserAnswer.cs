using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class UserAnswer
    {
        public string UserId { get; set; }

        public int QuizId { get; set; }

        public int QuestionId { get; set; }

        public int SelectedAnswer { get; set; }

        public QuizQuestion QuizQuestion { get; set; }

        public ApplicationUser ApplicationUser { get; set; }


    }
}
