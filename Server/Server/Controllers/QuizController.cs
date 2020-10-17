using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
        public async Task<List<QuizDTO>> Get()
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

            //var questions = _dbContext.Questions
            //    .Select(q => new QuestionDTO
            //    {
            //        Text = q.Text,
            //        Option1 = q.Option1,
            //        Option2 = q.Option2,
            //        Option3 = q.Option3,
            //        Option4 = q.Option4,
            //    });

            //return await questions.ToListAsync();

            //var quizzes = from quiz in _dbContext.QuizQuestions
            //              join question in _dbContext.Questions on quiz.QuestionId equals question.QuestionId
            //              select new Question
            //              {
            //                  Text = question.Text,
            //                  Option1 = question.Option1,
            //                  Option2 = question.Option2,
            //                  Option3 = question.Option3,
            //                  Option4 = question.Option4,
            //              };
            //return await quizzes.ToListAsync();

            var result = _dbContext.Quiz.Include(q => q.QuizQuestions)
                .ThenInclude(qq => qq.Question)
                .Select(x => new QuizDTO
                {
                    QuizId = x.QuizId,
                    QuizName = x.QuizName,
                    Questions = x.QuizQuestions.Select(qq => qq.Question).Select(q => new QuestionDTO 
                    {
                        Text = q.Text,
                        Option1 = q.Option1,
                        Option2 = q.Option2,
                        Option3 = q.Option3,
                        Option4 = q.Option4,
                    }).ToList()
                }); 

            return await result.ToListAsync();
        }

        [HttpGet("{quizId}")]
        public QuizDTO Get([FromRoute] int quizId)
        {
            var quiz = _dbContext.Quiz.Include(q => q.QuizQuestions)
                .ThenInclude(qq => qq.Question)
                .First(q => q.QuizId == quizId);

            var result = new QuizDTO
            {
                QuizId = quiz.QuizId,
                QuizName = quiz.QuizName,
                Questions = quiz.QuizQuestions.Select(qq => new QuestionDTO 
                {
                    Text = qq.Question.Text,
                    Option1 = qq.Question.Option1,
                    Option2 = qq.Question.Option2,
                    Option3 = qq.Question.Option3,
                    Option4 = qq.Question.Option4,
                }).ToList()
            };

            return result;
        }


        [HttpPost]
        public void PostQuiz(Quiz quiz)
        {
            var quizSent = new Quiz()
            {
                QuizName = quiz.QuizName,
              
            };
            _dbContext.Quiz.Add(quizSent);
            _dbContext.SaveChanges();
        }
    }
}
