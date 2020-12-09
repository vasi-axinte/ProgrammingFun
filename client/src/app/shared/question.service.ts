import { Injectable } from '@angular/core';
import { Question } from '../question';
import { FormBuilder, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserAnswerDetails } from '../userAnswer';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {

  readonly rootUrl = 'http://localhost:51301/api';

  questionForm = this.formBuilder.group({
    text : ['',Validators.required],
    option1: ['',Validators.required],
    option2: ['',Validators.required],
    option3: ['',Validators.required],
    option4: ['',Validators.required],
    correctAnswer: ['',Validators.required],
  });

  constructor(private http: HttpClient,
    private formBuilder : FormBuilder) { }

  postQuestion(){
    var questionBody = {
      text: this.questionForm.value.text,
      option1: this.questionForm.value.option1,
      option2: this.questionForm.value.option2,
      option3: this.questionForm.value.option3,
      option4: this.questionForm.value.option4,
      correctAnswer: this.questionForm.value.correctAnswer
    };
    return this.http.post(this.rootUrl + '/question', questionBody);
  }

  getQuestions(): Observable<Question>{
    {
      return this.http.get<Question>(this.rootUrl + '/Question');
    }
  }

  insertQuestionInQuiz(questionId, quizId){
    var quizQuestion = {
      quizId: quizId,
      questionId: questionId
    }
    return this.http.post(this.rootUrl + '/Quiz/InsertQuestion', quizQuestion);
  }

  deleteQuestionFromQuiz(questionId, quizId){
    var quizQuestion = {
      quizId: quizId,
      questionId: questionId
    }
    return this.http.post(this.rootUrl + '/Quiz/DeleteQuestion', quizQuestion);
  }

  sendAnswers(answers) { 
    return this.http.post(this.rootUrl + '/Question/Check', answers);
  } 
}
