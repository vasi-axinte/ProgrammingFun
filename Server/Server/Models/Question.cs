using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
         
        public string Text { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }

        public int CorrectAnswer { get; set; }

        [ForeignKey("QuestionId")]
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
    }
}
