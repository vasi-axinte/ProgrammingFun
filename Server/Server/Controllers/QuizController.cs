using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private ApplicationDbContext _dbContext;
        public QuizController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<QuestionDTO>> GetQuestions()
        {
            //var questions = from question in _dbContext.Questions
            //               select new QuestionDTO()
            //                {
            //                    Text = question.Text,
            //                    Option1 = question.Option1,
            //                    Option2 = question.Option2,
            //                    Option3 = question.Option3,
            //                    Option4 = question.Option4,
            //                };

            var questions = _dbContext.Questions
                .Select(q => new QuestionDTO
                {
                    Text = q.Text,
                    Option1 = q.Option1,
                    Option2 = q.Option2,
                    Option3 = q.Option3,
                    Option4 = q.Option4,
                });
            
            return await questions.ToListAsync();
        }

        [HttpPost]
        public async Task PostScore()
        {

        }

        
    }
}
