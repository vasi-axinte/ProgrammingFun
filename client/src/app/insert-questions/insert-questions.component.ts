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
  quizQuestions: Question[] = [];;
  questionExistsInQuiz: boolean;

  @Input() quizId: number

  constructor(private questionService: QuestionService,
    private toastr: ToastrService,
    private quizService: QuizService) { }

  ngOnInit(): void {
    this.getCurrentQuizAndQuestions();
    
  }

  getCurrentQuizAndQuestions()
  {
    this.quizService.getQuiz(this.quizId).subscribe((quiz) => {
      this.quiz = quiz;
    })

    this.questionService.getQuestions().subscribe((questionsThatExists: any) => 
    {
      if(questionsThatExists)
      {
        questionsThatExists.forEach((question: Question) => {
          this.checkIfQuestionExistsInQuiz(question);
          if(this.questionExistsInQuiz == false)
          {
            this.questionsAvailable.push(question);
          }
        });
      }
    })
  }

  checkIfQuestionExistsInQuiz(question)
  {
    this.quizQuestions.forEach(quizQuestion=> {
       if(quizQuestion.questionId == question.questionId)
       {
        this.questionExistsInQuiz = true;
       }
       else this.questionExistsInQuiz = false;
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