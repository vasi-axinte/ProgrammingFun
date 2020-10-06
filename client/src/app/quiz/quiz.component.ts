import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { QuizService } from '../shared/quiz.service';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {

  constructor(private router:Router,
    private quizService: QuizService) { }

  ngOnInit(): void {
    this.quizService.getQuestions().subscribe((data:any) => {
      this.quizService.questions = data;
      console.log(this.quizService.questions);
    });
  }

  onLogout()
  {
    localStorage.removeItem('token');
    this.router.navigate(['/login']);
  }

}
