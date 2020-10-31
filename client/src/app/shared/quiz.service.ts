import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Quiz } from '../quiz';
import { Observable } from 'rxjs';
import { FormBuilder, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class QuizService {

  readonly rootUrl = 'http://localhost:51301/api';

  quizForm = this.formBuilder.group({
    quizName : ['',Validators.required]
  });

  constructor(private http: HttpClient,
    private formBuilder : FormBuilder) { }
  
  postQuiz()
  {
    var quizName = { 
      quizName: this.quizForm.value.quizName 
    };
    return this.http.post(this.rootUrl + '/Quiz', quizName);
  }
 
  getQuiz(quizId : number): Observable<Quiz> { 
    return this.http.get<Quiz>(this.rootUrl + '/Quiz/' + quizId);
  }

  getQuizzes(): Observable<Quiz> {
    return this.http.get<Quiz>(this.rootUrl + '/Quiz');
  }
}