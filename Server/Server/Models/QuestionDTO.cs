using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class QuestionDTO
    {
        public int QuestionId { get; set; }

        public string Text { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }

        public int SelectedAnswer { get; set; }
    }
}
