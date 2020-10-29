using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private ApplicationDbContext _dbContext;

        public QuestionController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public void PostQuestion(Question question)
        {
            var questionSent =  new Question()
            {
                Text = question.Text,
                Option1 = question.Option1,
                Option2 = question.Option2,
                Option3 = question.Option3,
                Option4 = question.Option4,
                CorrectAnswer = question.CorrectAnswer,
            };
            _dbContext.Questions.Add(questionSent);
            _dbContext.SaveChanges();
        }

        [HttpGet]
        public async Task<List<Question>> GetQuestions()
        {
            var questions = _dbContext.Questions
                .Select(q => new Question
                {
                    QuestionId = q.QuestionId,
                    Text = q.Text,
                    Option1 = q.Option1,
                    Option2 = q.Option2,
                    Option3 = q.Option3,
                    Option4 = q.Option4,
                });
            return await questions.ToListAsync();
        }

        [HttpPost]
        [Route("Check")]
        public int CheckSelectedAnswers(List<AnswersCheckDTO> questionAndAnswers)
        {
            // List<AnswersCheckDTO> answers = new List<AnswersCheckDTO>();
            // answers.Add(questionAndAnswers);
            int scoreTest = 0;
            foreach (var answer in questionAndAnswers)
            {
               if (_dbContext.Questions.Any(q => (q.Text == answer.Text) && (q.CorrectAnswer == answer.SelectedAnswer)))
                   {
                     scoreTest = scoreTest++;
                   }
            }
            return scoreTest;
        }

    }
}
