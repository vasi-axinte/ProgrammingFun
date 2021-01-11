import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Quiz } from '../quiz';
import { QuizService } from '../shared/quiz.service';
import { ToastrService } from 'ngx-toastr';
import { QuestionService } from '../shared/question.service';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { InsertQuestionsComponent } from '../insert-questions/insert-questions.component';



@Component({
  selector: 'app-quiz-editor',
  templateUrl: './quiz-editor.component.html',
  styleUrls: ['./quiz-editor.component.css']
})

export class QuizEditorComponent implements OnInit {
  
  quiz:Quiz;
  questions = {};
  currentDialog = null;
  quizNull : boolean;

  @Input() quizId: number

  constructor(
    private quizService: QuizService,
    private toastr: ToastrService,
    private questionService: QuestionService,
    public modalService: NgbModal,
    public activeModal: NgbActiveModal) { }
 
  ngOnInit(): void {
    this.getQuiz(this.quizId);
  }

  getQuiz(quizId) {
    this.quizService.getQuiz(this.quizId).subscribe((quiz) => {
    this.quiz = quiz;
    if(quiz.questions.length == 0)
    {
      this.quizNull = true;
    }
    })
  }

  deleteQuestionInQuiz(questionId)
  {
    this.questionService.deleteQuestionFromQuiz(questionId, this.quizId).subscribe(
      (res: any) => {
        this.toastr.success('Question deleted!');
      },
      err=> { 
        this.toastr.error('Something went wrong, question could not be deleted :(');
      }
      );
  }

  openAddQuestionDialog(quizId)
  {
    this.currentDialog = this.modalService.open(InsertQuestionsComponent);
    this.currentDialog.componentInstance.quizId = quizId;
  }

  closeModal()
  {
    this.activeModal.close();
  }
}