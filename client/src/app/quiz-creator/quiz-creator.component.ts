import { Component, OnInit, Input } from '@angular/core';
import { QuizService } from '../shared/quiz.service';
import { ToastrService } from 'ngx-toastr';
import { AskForInsertComponent } from '../ask-for-insert/ask-for-insert.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-quiz-creator',
  templateUrl: './quiz-creator.component.html',
  styleUrls: ['./quiz-creator.component.css']
})
export class QuizCreatorComponent implements OnInit {

  currentDialog = null;
  lastQuizId : number;
  closeDialog: string;
  isOpen: number;

  constructor(public service: QuizService,
    private toastr: ToastrService,
    public modalService: NgbModal,
   ) { }

  ngOnInit(): void {
    this.service.quizForm.reset();
  }

  onSubmit(){
    this.service.postQuiz().subscribe(
      (quizId:any) => 
      { 
        this.service.quizForm.reset();
        this.toastr.success('Quiz was created');
        this.lastQuizId = quizId;
        this.openDialog()
      });

  }

  openDialog()
  {
    this.currentDialog = this.modalService.open(AskForInsertComponent);
    this.currentDialog.componentInstance.lastQuizId = this.lastQuizId;
  }

 
}
