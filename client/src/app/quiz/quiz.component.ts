import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { QuizService } from '../shared/quiz.service';
import { Question } from '../question';


@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {

  constructor(public router:Router,
    public quizService: QuizService) { }
    questions: Question[];

  ngOnInit(): void {
    this.getQuestions();
  }

  getQuestions() {
    this.quizService.getQuestions().subscribe((questions) => {
      this.questions = questions;
     });
  }

  onLogout()
  {
    localStorage.removeItem('token');
    this.router.navigate(['/login']);
  }

}
