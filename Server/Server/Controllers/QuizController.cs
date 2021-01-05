using System;
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
                        QuestionId = q.QuestionId,
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
                    QuestionId = qq.QuestionId,
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
        public int PostQuiz(QuizDTO quiz)
        {
            var quizSent = new Quiz
            {
                QuizName = quiz.QuizName,
            };

            _dbContext.Quiz.Add(quizSent);
            _dbContext.SaveChanges();
            return quizSent.QuizId;
        }

        [HttpPost]
        [Route("InsertQuestion")]
        public void PostQuestionId(QuizQuestionDTO newQuizQuestion)
        {
            var questionToInsert = new QuizQuestion
            {
                QuizId = newQuizQuestion.QuizId,
                QuestionId = newQuizQuestion.QuestionId,
            };

            _dbContext.QuizQuestions.Add(questionToInsert);
            _dbContext.SaveChanges();
        }

        [HttpPost]
        [Route("DeleteQuestion")]
        public void DeleteQuestionFromQuiz(QuizQuestionDTO questionSent)
        {
            var questionToDelete = new QuizQuestion
            {
                QuizId = questionSent.QuizId,
                QuestionId = questionSent.QuestionId,
            };

            _dbContext.QuizQuestions.Remove(questionToDelete);
            _dbContext.SaveChanges();
        }

        [HttpGet]
        [Route("QuizScores")]
        public async Task<List<UserScoreDTO>> GetQuizScores()
        {
            var user = _dbContext.ApplicationUsers.Include(ap => ap.UserScore)
                .ThenInclude(us => us.Quiz)
                .Select(x => new UserScoreDTO
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    UserId = x.Id,
                    QuizDetails = x.UserScore.Select(q => new QuizDetailsDTO
                    {
                        Score = q.Score,
                        QuizName = q.Quiz.QuizName,
                        QuizId = q.Quiz.QuizId,
                    }).ToList()
                }); 
            return await user.ToListAsync();
        }

        [HttpPost]
        [Route("QuizTaken")]
        public void InsertTakenQuiz(TakenQuizDTO[] quizTakenSent)
        {
            foreach (var detail in quizTakenSent)
            {
                var quizTakenByUser = new UserScore
                {
                    QuizId = detail.QuizId,
                    UserId = detail.UserId,
                    Score = detail.Score,
                };
                _dbContext.UserScores.Add(quizTakenByUser);
                _dbContext.SaveChanges();
            }
        }

        [HttpGet("QuizTakenDetails/{selectedQuiz}")]
        public  UserAnswerDTO GetQuizTakenDetails([FromRoute] UserQuizDetailsDTO selectedQuiz)
        {
            var user = _dbContext.ApplicationUsers.Include(ap => ap.UserAnswer)
                .ThenInclude(ua => ua.QuizQuestion).First(u => u.Id == selectedQuiz.UserId);


           var quizTakenDetails = new UserAnswerDTO
           {
               FirstName = user.FirstName,
               LastName = user.LastName,
               UserId = user.Id,
               UserAnswerDetails = user.UserAnswer.Select(ua => new UserAnswerDetailsDTO
               {
                   SelectedAnswer = ua.SelectedAnswer,
                   Question = ua.QuizQuestion.Question.Text,
               }).ToList()
           }; 
            return quizTakenDetails;
        }
       
    }
}