import { Component, OnInit } from '@angular/core';
import { QuizService } from '../shared/quiz.service';
import { Quiz } from '../quiz';
import { ActivatedRoute } from '@angular/router';
import { Question } from '../question';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {

  constructor(private quizService: QuizService,
    private route: ActivatedRoute) { }
    quiz: Quiz;
    quizId: number;
    questions: Question;
    question: Question;
    option:number;


  ngOnInit(): void {
    this.getQuiz();
  }

  getQuiz() {
    this.quizId = +this.route.snapshot.paramMap.get('quizId');
    this.quizService.getQuiz(this.quizId).subscribe((quiz) => {
      this.quiz = quiz;
    })
  }

  onSelect(question, option) {
    this.question = question;
    this.option = option;
  }
}

