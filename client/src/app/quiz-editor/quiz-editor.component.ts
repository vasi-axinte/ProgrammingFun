import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Question } from '../question';
import { Quiz } from '../quiz';
import { QuizService } from '../shared/quiz.service';
import { ToastrService } from 'ngx-toastr';
import { QuestionService } from '../shared/question.service';
import { positionService } from '@ng-bootstrap/ng-bootstrap/util/positioning';



@Component({
  selector: 'app-quiz-editor',
  templateUrl: './quiz-editor.component.html',
  styleUrls: ['./quiz-editor.component.css']
})

export class QuizEditorComponent implements OnInit {
  
  quiz:Quiz;
  questions = {};

  @Input() quizId: number

  constructor(private router:Router,
    private route: ActivatedRoute,
    private quizService: QuizService,
    private toastr: ToastrService,
    private questionService: QuestionService) { }
 
  ngOnInit(): void {
    this.getQuiz(this.quizId);
  }

  getQuiz(quizId) {
    this.quizService.getQuiz(this.quizId).subscribe((quiz) => {
    this.quiz = quiz;
    })
  }

  deleteQuestionInQuiz(questionId)
  {
    this.questionService.deleteQuestionFromQuiz(questionId, this.quizId).subscribe(
      (res: any) => {
        this.toastr.success('Question deleted!');
      }
      );
  }
}