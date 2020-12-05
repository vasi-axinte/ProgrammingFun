import { Component, OnInit, Input } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { InsertQuestionsComponent } from '../insert-questions/insert-questions.component';
import { Quiz } from '../quiz';
import { QuizService } from '../shared/quiz.service';

@Component({
  selector: 'app-ask-for-insert',
  templateUrl: './ask-for-insert.component.html',
  styleUrls: ['./ask-for-insert.component.css']
})
export class AskForInsertComponent implements OnInit {

  quizzes : Quiz;
  lastQuiz : Quiz;
  currentDialog = null;
  constructor(private quizService: QuizService,
    public modalService: NgbModal) { }
  
  @Input() lastQuizId: number;

  ngOnInit(): void {
  }
  
  getLastQuiz(){
    this.quizService.getQuiz(this.lastQuizId).subscribe();
    this.openAddQuestionDialog();
  }

  openAddQuestionDialog()
  {
    this.currentDialog = this.modalService.open(InsertQuestionsComponent);
    this.currentDialog.componentInstance.quizId = this.lastQuizId;
  }
}
