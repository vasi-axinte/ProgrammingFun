import { Component, OnInit } from '@angular/core';
import { QuizService } from '../shared/quiz.service';
import { Quiz } from '../quiz';
import { ActivatedRoute } from '@angular/router';
import { Question } from '../question';
import { QuestionService } from '../shared/question.service';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {

  constructor(private questionService: QuestionService,
        private quizService: QuizService,
    private route: ActivatedRoute) { }
    quiz: Quiz;
    quizId: number;
    selectedAnswer: number;
    questionText: string;

  ngOnInit(): void {
    this.getQuiz();
  }

  getQuiz() {
    this.quizId = +this.route.snapshot.paramMap.get('quizId');
    this.quizService.getQuiz(this.quizId).subscribe((quiz) => {
      this.quiz = quiz;
    })
  }

  onRadioChange(event, question) {
    this.selectedAnswer = event.target.value;
    this.questionText = question;
    this.questionService.sendAnswer(this.selectedAnswer, this.questionText).subscribe();
  }
}

