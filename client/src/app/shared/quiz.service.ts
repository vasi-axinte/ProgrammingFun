import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Quiz } from '../quiz';
import { Observable } from 'rxjs';
import { FormBuilder, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class QuizService {

  constructor(private http: HttpClient,
    private formBuilder : FormBuilder) { }
  readonly rootUrl = 'http://localhost:51301/api';
  
  quizForm = this.formBuilder.group({
    quizName : ['',Validators.required]
  });

  postQuiz()
  {
    var quizName = { 
      quizName: this.quizForm.value.quizName 
    };
    return this.http.post(this.rootUrl + '/Quiz', quizName);
  }
  // getQuizzes():Observable<Quiz[]> {
  //   return this.http.get<Quiz[]>(this.rootUrl + '/Quiz');
  // }
  getQuiz(quizId : number): Observable<Quiz> { 
    return this.http.get<Quiz>(this.rootUrl + '/Quiz/' + quizId);
  }

  getQuizzes(): Observable<Quiz> {
    return this.http.get<Quiz>(this.rootUrl + '/Quiz');
  }

  SendAnswer(selectedAnswer, questionText) {
    var questionAndAnswer = {
      selectedAnswer: selectedAnswer,
      questionText: questionText
    }
    return this.http.post(this.rootUrl + '/Quiz/SentAnswers', questionAndAnswer);
  } 
}