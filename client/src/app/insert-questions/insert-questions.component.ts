import { Component, Input, OnInit } from '@angular/core';
import { QuestionService} from '../shared/question.service';
import { Question } from '../question';
import { ToastrService } from 'ngx-toastr';
import { QuizService } from '../shared/quiz.service';
import { Quiz } from '../quiz';
import { NgIf } from '@angular/common';


@Component({
  selector: 'app-insert-questions',
  templateUrl: './insert-questions.component.html',
  styleUrls: ['./insert-questions.component.css']
})
export class InsertQuestionsComponent implements OnInit {

  questionsAvailable: Question[] =[];
  quiz: Quiz;
  questionExistsInQuiz: boolean;
  questionExists: boolean;
  quizQuestions: Question[] = [];
  existentQuestions: Question[];

  @Input() quizId: number

  constructor(private questionService: QuestionService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
   this.getQuizQuestions();
  }

  getQuizQuestions()
  {
    this.questionService.getQuizQuestions(this.quizId).subscribe((questions: any) =>  
    {
      this.quizQuestions = questions;
      this.questionService.getQuestions().subscribe((questions: any) => 
      {
        this.existentQuestions = questions;
        if(this.quizQuestions.length == 0)
        {
          this.existentQuestions.forEach(question => {
            this.questionsAvailable.push(question);
          });
        }
        else this.checkIfQuestionExistsInQuiz(  this.quizQuestions, this.existentQuestions)
      });
    });
  } 

  checkIfQuestionExistsInQuiz(quizQuestions, existentQuestions)
  {
    quizQuestions.forEach((quizQuestion : Question) => 
    {
      existentQuestions.forEach((question : Question) =>  {
        if(question.questionId === quizQuestion.questionId)
        {
          this.questionExistsInQuiz == true;
        }
        else 
        {
          this.questionsAvailable.push(question);
        }
      });
    });
  }

  insertQuestionInQuiz(questionId, quizId)
  {
    this.questionService.insertQuestionInQuiz(questionId, this.quizId).subscribe(
      (res: any) => 
      {
        this.toastr.success('Question added to quiz!');
      }
    );
  }
}