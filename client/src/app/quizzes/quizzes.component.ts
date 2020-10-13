import { Component, OnInit } from '@angular/core';
import { QuizService } from '../shared/quiz.service';
import { Quiz } from '../quiz';

@Component({
  selector: 'app-quizzes',
  templateUrl: './quizzes.component.html',
  styleUrls: ['./quizzes.component.css']
})
export class QuizzesComponent implements OnInit {

  constructor(private quizService: QuizService) { }
  quizzes: Quiz;
  ngOnInit(): void {
   this.getQuizzes()
  }
   
  
  getQuizzes(){
  this.quizService.getQuizzes().subscribe((quiz) => {
  this.quizzes = quiz;
  });
  }
}
