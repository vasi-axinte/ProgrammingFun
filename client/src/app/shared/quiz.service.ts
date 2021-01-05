import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Quiz } from '../quiz';
import { Observable } from 'rxjs';
import { FormBuilder, Validators } from '@angular/forms';
import { QuizTaken } from '../quizTaken';
import { UserQuiz } from '../userQuiz';
import { QuizTakenDetails } from '../quizTakenDetails';
import { SelectedQuiz } from '../selectedQuiz'

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

  QuizzesTaken(): Observable<UserQuiz>{
    return this.http.get<UserQuiz>(this.rootUrl + '/Quiz/QuizScores');
  }

  sendQuiz(quizTaken){
    return this.http.post<QuizTaken>(this.rootUrl + '/Quiz/QuizTaken', quizTaken);
  }

  getTakenQuizDetails(quizId, userId): Observable<QuizTakenDetails>{
   var selectedQuiz = {
      QuizId: quizId, 
      UserId: userId
    }
    return this.http.get<QuizTakenDetails>(this.rootUrl + '/Quiz/QuizTakenDetails/' + selectedQuiz)
  }
}
