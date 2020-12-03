import { Component, Input, OnInit } from '@angular/core';
import { QuestionService} from '../shared/question.service';
import { Question } from '../question';
import { ToastrService } from 'ngx-toastr';
import { QuizService } from '../shared/quiz.service';
import { Quiz } from '../quiz';


@Component({
  selector: 'app-insert-questions',
  templateUrl: './insert-questions.component.html',
  styleUrls: ['./insert-questions.component.css']
})
export class InsertQuestionsComponent implements OnInit {

  questions: Question[] =[];
  quiz: Quiz;
  quizQuestions: Question;
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
    this.questionService.getQuestions().subscribe((question: any) => 
    {
        question.forEach(questionThatExists => {
        this.checkIfQuestionExistsInQuiz(questionThatExists);
        if(this.questionExistsInQuiz == false)
        {
          this.questions.push(questionThatExists);
        }
      });
    })
  }

  checkIfQuestionExistsInQuiz(question)
  {
    this.questionExistsInQuiz = this.quiz.questions.some(q => q.questionId == question.questionId);
  }

  insertQuestionInQuiz(questionId, quizId)
  {
    this.questionService.insertQuestionInQuiz(questionId, quizId).subscribe(
      (res: any) => 
      {
        this.toastr.success('Question added to quiz!');
      }
    );
  }
}