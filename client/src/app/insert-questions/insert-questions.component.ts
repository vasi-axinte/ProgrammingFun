import { Component, OnInit } from '@angular/core';
import { QuestionService} from '../shared/question.service';
import { Question } from '../question';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-insert-questions',
  templateUrl: './insert-questions.component.html',
  styleUrls: ['./insert-questions.component.css']
})
export class InsertQuestionsComponent implements OnInit {

  questions: Question;
  quizId: number
 
  constructor(private service: QuestionService,
    private route: ActivatedRoute,
    private toastr: ToastrService) { }

  ngOnInit(): void {
    this.getQuestions();
  }

  getQuestions()
  {
    this.service.getQuestions().subscribe((question) => 
    {this.questions= question;})
  }

  insertQuestionInQuiz(questionId)
  {
    this.quizId = +this.route.snapshot.paramMap.get('quizId');
    this.service.insertQuestionInQuiz(questionId, this.quizId).subscribe(
      (res: any) => 
      {
        this.toastr.success('Question added to quiz!');
      }
    );
  }

  goPervious()
  {
    window.history.back();
  }
}