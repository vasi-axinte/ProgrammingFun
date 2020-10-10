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
    answerPicked: string[];

  ngOnInit(): void {
    this.getQuestions();
  }

  getQuestions() {
    this.quizService.getQuestions().subscribe((question) => {
      this.questions = question;
     });
  }
}
