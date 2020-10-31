import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-quizzes-taken',
  templateUrl: './quizzes-taken.component.html',
  styleUrls: ['./quizzes-taken.component.css']
})
export class QuizzesTakenComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  goPervious()
  {
    window.history.back();
  }

}
