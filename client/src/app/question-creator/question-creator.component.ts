import { ThrowStmt } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { QuestionService } from '../shared/question.service';


@Component({
  selector: 'app-question-creator',
  templateUrl: './question-creator.component.html',
  styleUrls: ['./question-creator.component.css']
})
export class QuestionCreatorComponent implements OnInit {

  constructor(public service: QuestionService,
    public toastr: ToastrService) { }

  ngOnInit(): void {
    this.service.questionForm.reset();
  }
  
  onSubmit(){
    this.service.postQuestion().subscribe(
      (res:any) => 
      { 
        this.service.questionForm.reset();
        this.toastr.success('Question was created!');
      });
  }

}
