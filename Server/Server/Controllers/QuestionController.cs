using Microsoft.AspNetCore.Mvc;
using Server.Models;
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

    }
}
