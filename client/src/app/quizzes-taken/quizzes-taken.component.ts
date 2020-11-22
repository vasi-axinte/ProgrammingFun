import { Component, OnInit } from '@angular/core';
import { QuizTaken } from '../quizTaken';
import { QuizService } from '../shared/quiz.service';
import { UserQuiz } from '../userQuiz';

@Component({
  selector: 'app-quizzes-taken',
  templateUrl: './quizzes-taken.component.html',
  styleUrls: ['./quizzes-taken.component.css']
})
export class QuizzesTakenComponent implements OnInit {

  columnNames = ['Firstname', 'Lastname', 'Quizname', 'Score'];
  quizzesTaken: UserQuiz[];

  constructor(private quizService : QuizService) { }

  ngOnInit(): void {
     this.getQuizzesTaken();
  }

  getQuizzesTaken()
  {
    this.quizService.QuizzesTaken().subscribe((quizzes: any) => 
    {
      this.quizzesTaken = quizzes;
    });
  }
}
