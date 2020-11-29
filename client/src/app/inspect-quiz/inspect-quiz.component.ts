import { Component, OnInit,  Input  } from '@angular/core';
import { Quiz } from '../quiz';
import { QuizService } from '../shared/quiz.service';

@Component({
  selector: 'app-inspect-quiz',
  templateUrl: './inspect-quiz.component.html',
  styleUrls: ['./inspect-quiz.component.css']
})
export class InspectQuizComponent implements OnInit {

  @Input() quizId: number
  quiz:Quiz;

  constructor(private quizService: QuizService) { }

  ngOnInit(): void {
    this.getTakenQuiz(this.quizId);
  }

  getTakenQuiz(quizId) {
    this.quizService.getQuiz(this.quizId).subscribe((quiz) => {
    this.quiz = quiz;
    })
  }
}
