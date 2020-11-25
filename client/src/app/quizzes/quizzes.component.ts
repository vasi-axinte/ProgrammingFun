import { Component, OnInit } from '@angular/core';
import { QuizService } from '../shared/quiz.service';
import { Quiz } from '../quiz';
import { ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { QuizEditorComponent } from '../quiz-editor/quiz-editor.component';
import { VariableAst } from '@angular/compiler';
@Component({
  selector: 'app-quizzes',
  templateUrl: './quizzes.component.html',
  styleUrls: ['./quizzes.component.css']
})
export class QuizzesComponent implements OnInit {
  
  quizzes: Quiz;
  currentDialog = null;

  constructor(private quizService: QuizService,
    private route: ActivatedRoute,
    public matDialog: MatDialog) {}

  ngOnInit(): void {
   this.getQuizzes()
  }
     
  getQuizzes(){
  this.quizService.getQuizzes().subscribe((quiz) => {
  this.quizzes = quiz;
  });
  }

  openDialog(quizId){
    var dialogConfig = new MatDialogConfig();
    dialogConfig.height = "350px";
    dialogConfig.width = "600px";
    dialogConfig.data = quizId
    this.currentDialog = this.matDialog.open(QuizEditorComponent, dialogConfig);
  }
}
