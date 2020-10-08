import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { QuizService } from '../shared/quiz.service';
import { Question } from '../question';
import { NgIf } from '@angular/common';


@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {

  constructor(public router:Router,
    public quizService: QuizService) { }
    questions: Question[];
    correctAnswers: string[];
    answerPicked: string[];
    correctAnswer: string;

  ngOnInit(): void {
    this.getQuestions();
  }

  getQuestions() {
    this.quizService.getQuestions().subscribe((questions) => {
      this.questions = questions;
      this.getAnswers();
     });
  }

  getAnswers() {
    this.questions.forEach(question => 
      this.correctAnswer = question.correctAnswer
    )
  }


  onLogout()
  {
    localStorage.removeItem('token');
    this.router.navigate(['/login']);
  }

}
