using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class QuizDTO
    {
        public int QuizId { get; set;}

        public string QuizName { get; set; }
        
        public List<QuestionDTO> Questions { get; set; }
    }
}
