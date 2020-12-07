using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }

        public string QuizName { get; set; }

        [ForeignKey("QuizId")]
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }

        [ForeignKey("QuizId")]
        public virtual ICollection<UserScore> UserScore { get; set; }

        [ForeignKey("QuizId")]
        public virtual ICollection<UserAnswer> UserAnswer{ get; set; }
    }
}
