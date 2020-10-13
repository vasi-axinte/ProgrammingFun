import { Component, OnInit } from '@angular/core';
import { QuizService } from '../shared/quiz.service';
import { Quiz } from '../quiz';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {

  constructor(private quizService: QuizService) { }
    quiz: Quiz;
    answerPicked: string[];

  ngOnInit(): void {
    this.getQuiz();
  }

  getQuiz() {
    //   this.quizService.getQuizzes().subscribe((quiz) => {
    //   this.quizzes = quiz;
    // });
    this.quizService.getQuiz(1).subscribe((quiz) => {
      this.quiz = quiz;
    })
  }
}

