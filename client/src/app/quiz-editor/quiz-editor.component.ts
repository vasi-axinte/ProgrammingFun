import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Quiz } from '../quiz';
import { QuizService } from '../shared/quiz.service';

@Component({
  selector: 'app-quiz-editor',
  templateUrl: './quiz-editor.component.html',
  styleUrls: ['./quiz-editor.component.css']
})
export class QuizEditorComponent implements OnInit {

  constructor(private router:Router,
    private route: ActivatedRoute,
    private quizService: QuizService) { }
    quizId: number;
    quiz:Quiz;

  ngOnInit(): void {
    this.getQuiz();
  }

  getQuiz() {
    this.quizId = +this.route.snapshot.paramMap.get('quizId');
    this.quizService.getQuiz(this.quizId).subscribe((quiz) => {
      this.quiz = quiz;
    })
  }

}
