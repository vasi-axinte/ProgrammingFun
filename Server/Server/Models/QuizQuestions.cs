using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class QuizQuestions
    {
        [Key]
        public int Id {get; set;}

        public int QuizId { get; set; }

        public int QuestionId { get; set; }

        public Quiz Quiz { get; set; }

        public Question Question { get; set; }
    }
}
