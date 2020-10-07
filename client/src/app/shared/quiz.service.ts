import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Question } from '../question';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class QuizService {

  constructor(private http: HttpClient) { }
  readonly rootUrl = 'http://localhost:51301/api';
  
  getQuestions():Observable<Question[]> {
    return this.http.get<Question[]>(this.rootUrl + '/Quiz');
  }
}
