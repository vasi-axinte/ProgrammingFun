import { Component, OnInit } from '@angular/core';
import { QuizService } from '../shared/quiz.service';
import { Quiz } from '../quiz';
import { ActivatedRoute } from '@angular/router';
import { Question } from '../question';
import { QuestionService } from '../shared/question.service';
import { UserAnswerDetails } from '../userAnswer';
import { UserService } from '../shared/user.service';
import { UserDetails } from '../userDetails';
import { QuizTaken } from '../quizTaken';
import { QuizSentConfirmationComponent } from '../quiz-sent-confirmation/quiz-sent-confirmation.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {

  quiz: Quiz;
  quizId: number;
  answersDetails: UserAnswerDetails[] = [];
  userId : string;
  user : UserDetails;
  quizTaken: QuizTaken[] = [];
  score : number;
  currentDialog = null;

  constructor(private questionService: QuestionService,
    private quizService: QuizService,
    private userService: UserService,
    private route: ActivatedRoute,
    public modalService: NgbModal) { }
    
  ngOnInit(): void {
    this.getQuiz();
    this.getUserDetails()
  }

  getUserDetails()
  {
    var payLoad = JSON.parse(window.atob(localStorage.getItem('token').split('.')[1]));
    this.userId = payLoad.UserID;
    this.userService.getUserDetails(this.userId).subscribe((user) => 
    {
      this.user = user;
    });
  }

  getQuiz() {
    this.quizId = +this.route.snapshot.paramMap.get('quizId');
    this.quizService.getQuiz(this.quizId).subscribe((quiz) => {
      this.quiz = quiz;
    })
  }

  combineDetails()
  {
    let fullQuiz = {
      userId: this.userId,
      quizId: this.quiz.quizId,
      score: this.score,
    }
    this.quizTaken.push(fullQuiz);
    this.sendQuiz(this.quizTaken);
  }

  sendQuiz(quizTaken)
  {
    this.quizService.sendQuiz(this.quizTaken).subscribe();
  }

  onRadioChange(event, questionId) {
    let  AnswerDetailsIndex = this.answersDetails.findIndex(q => q.questionId === questionId);
    
    if( AnswerDetailsIndex != -1) {
       this.answersDetails[ AnswerDetailsIndex].selectedAnswer = +event.target.value;
    } else {
      let AnswerDetails = {
        selectedAnswer: +event.target.value,
        questionId: questionId,
        quizId: this.quizId,
        userId: this.userId
      }
      this.answersDetails.push(AnswerDetails);
    }
  }

  onSubmit() {
    this.questionService.sendAnswers(this.answersDetails).subscribe((data : any) => {
     this.score = data;
     this.combineDetails();
    });
  }

  openDialog() {
    this.currentDialog = this.modalService.open(QuizSentConfirmationComponent);
  }
}

