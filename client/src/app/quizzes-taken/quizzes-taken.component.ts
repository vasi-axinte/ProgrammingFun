import { Component, OnInit} from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { InspectQuizComponent } from '../inspect-quiz/inspect-quiz.component';
import { QuizTaken } from '../quizTaken';
import { QuizService } from '../shared/quiz.service';
import { UserQuiz } from '../userQuiz';

@Component({
  selector: 'app-quizzes-taken',
  templateUrl: './quizzes-taken.component.html',
  styleUrls: ['./quizzes-taken.component.css']
})
export class QuizzesTakenComponent implements OnInit {

  columnNames = ['Firstname', 'Lastname', 'Quizname', 'Score'];
  quizzesTaken: UserQuiz[];
  currentDialog = null;

  constructor(private quizService : QuizService,
    public matDialog: MatDialog,
    public modalService: NgbModal) { }

  ngOnInit(): void {
     this.getQuizzesTaken();
  }

  getQuizzesTaken()
  {
    this.quizService.QuizzesTaken().subscribe((quizzes: any) => 
    {
      this.quizzesTaken = quizzes;
    });
  }

  openDialog(userId, quizId)
  {
    this.currentDialog = this.modalService.open(InspectQuizComponent);
    this.currentDialog.componentInstance.quizId = quizId
    this.currentDialog.componentInstance.userId = userId;
  }
}
