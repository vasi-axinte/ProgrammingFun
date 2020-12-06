import { Component, OnInit } from '@angular/core';
import { QuizService } from '../shared/quiz.service';
import { Quiz } from '../quiz';
import { QuizEditorComponent } from '../quiz-editor/quiz-editor.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-quizzes',
  templateUrl: './quizzes.component.html',
  styleUrls: ['./quizzes.component.css']
})
export class QuizzesComponent implements OnInit {
  
  quizzes: Quiz;
  currentDialog = null;

  constructor(private quizService: QuizService,
    public modalService: NgbModal) {}

  ngOnInit(): void {
   this.getQuizzes()
  }
     
  getQuizzes(){
    this.quizService.getQuizzes().subscribe((quiz) => {
    this.quizzes=quiz;
  });
  }

  openDialog(quizId){
    this.currentDialog = this.modalService.open(QuizEditorComponent);
    this.currentDialog.componentInstance.quizId = quizId;
  }
}
