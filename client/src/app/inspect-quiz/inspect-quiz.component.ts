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
  @Input() userId: string
  quiz:Quiz;
  columnNames = ['Firstname', 'Lastname', 'Quizname', 'Selected Answer'];

  constructor(private quizService: QuizService) { }

  ngOnInit(): void {
    //this.getTakenQuizDetails(this.quizId, this.userId);
  }

  // getTakenQuizDetails(quizId, userId) {
  //   this.quizService.getTakenQuiz(this.quizId, this.userId).subscribe((quiz) => {
  //   })
  // }
}
