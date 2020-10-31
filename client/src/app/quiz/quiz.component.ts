import { Component, OnInit } from '@angular/core';
import { QuizService } from '../shared/quiz.service';
import { Quiz } from '../quiz';
import { ActivatedRoute } from '@angular/router';
import { Question } from '../question';
import { QuestionService } from '../shared/question.service';
import { UserAnswer } from '../userAnswer';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {

  quiz: Quiz;
  quizId: number;
  answers: UserAnswer[] = [];

  constructor(private questionService: QuestionService,
    private quizService: QuizService,
    private route: ActivatedRoute) { }
    
  ngOnInit(): void {
    this.getQuiz();
  }

  getQuiz() {
    this.quizId = +this.route.snapshot.paramMap.get('quizId');
    this.quizService.getQuiz(this.quizId).subscribe((quiz) => {
      this.quiz = quiz;
    })
  }

  onRadioChange(event, questionId) {
    let questionWithAnswerIndex = this.answers.findIndex(q => q.questionId === questionId);
    
    if(questionWithAnswerIndex != -1) {
       this.answers[questionWithAnswerIndex].selectedAnswer = +event.target.value;
    } else {
      let questionWithAnswer = {
        selectedAnswer: +event.target.value,
        questionId: questionId
      }
      this.answers.push(questionWithAnswer);
    }
  }

  onSubmit() {
    this.questionService.sendAnswers(this.answers).subscribe();
  }
}

