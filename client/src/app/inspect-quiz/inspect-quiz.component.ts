import { Component, OnInit,  Input  } from '@angular/core';
import { Quiz } from '../quiz';
import { QuizService } from '../shared/quiz.service';
import { UserQuiz } from '../userQuiz';

@Component({
  selector: 'app-inspect-quiz',
  templateUrl: './inspect-quiz.component.html',
  styleUrls: ['./inspect-quiz.component.css']
})
export class InspectQuizComponent implements OnInit {

  @Input() quizId: number
  @Input() userId: string
  quiz:Quiz;
  quizTakenDetails: UserQuiz[];
  columnNames = ['Firstname', 'Lastname', 'Quesiton', 'Selected Answer'];

  constructor(private quizService: QuizService) { }

  ngOnInit(): void {
    this.getTakenQuizDetails();
  }

   getTakenQuizDetails() {
    this.quizService.getTakenQuizDetails(this.userId, this.quizId).subscribe((quizzes: any) => 
    {
      this.quizTakenDetails = quizzes;
    });
    }
}
