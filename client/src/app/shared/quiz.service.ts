import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Quiz } from '../quiz';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class QuizService {

  constructor(private http: HttpClient) { }
  readonly rootUrl = 'http://localhost:51301/api';
  
  // getQuizzes():Observable<Quiz[]> {
  //   return this.http.get<Quiz[]>(this.rootUrl + '/Quiz');
  // }
  getQuiz(quizId : number): Observable<Quiz> { 
    return this.http.get<Quiz>(this.rootUrl + '/Quiz/' + quizId);
  }
}