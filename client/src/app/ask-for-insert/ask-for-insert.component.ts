import { Component, OnInit, Input, Output } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { EventEmitter } from 'events';
import { NumberLiteralType } from 'typescript';
import { InsertQuestionsComponent } from '../insert-questions/insert-questions.component';
import { Quiz } from '../quiz';
import { QuizService } from '../shared/quiz.service';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

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
    public modalService: NgbModal,
    public activeModal: NgbActiveModal) { }
  
  @Input() lastQuizId: number;
  @Output() closeCurrentModal: EventEmitter = new EventEmitter();

  ngOnInit(): void {
  }
  
  getLastQuiz()
  {
    this.quizService.getQuiz(this.lastQuizId).subscribe((quiz) =>  {
      this.lastQuiz = quiz
    });
    this.openAddQuestionDialog();
  }

  openAddQuestionDialog()
  {
    this.currentDialog = this.modalService.open(InsertQuestionsComponent);
    this.currentDialog.componentInstance.quizId = this.lastQuizId;
  }0

  closeModal()
  {
    this.activeModal.close();
  }
}
