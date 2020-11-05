import { Component, OnInit } from '@angular/core';
import { QuizService } from '../shared/quiz.service';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-quiz-creator',
  templateUrl: './quiz-creator.component.html',
  styleUrls: ['./quiz-creator.component.css']
})
export class QuizCreatorComponent implements OnInit {

  constructor(public service: QuizService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
    this.service.quizForm.reset();
  }

  onSubmit(){
    this.service.postQuiz().subscribe(
      (res:any) => 
      { 
        this.service.quizForm.reset();
        this.toastr.success('Quiz was created');
      });
  }
}
