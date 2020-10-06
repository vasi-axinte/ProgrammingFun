import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class QuizService {

  questions: any[];
  
  constructor(private http: HttpClient) { }
  readonly rootUrl = 'http://localhost:51301/api';
  
  getQuestions() {
    return this.http.get(this.rootUrl + '/Quiz');
  }
}
