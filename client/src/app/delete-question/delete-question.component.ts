import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Question } from '../question';
import { QuestionService } from '../shared/question.service';

@Component({
  selector: 'app-delete-question',
  templateUrl: './delete-question.component.html',
  styleUrls: ['./delete-question.component.css']
})
export class DeleteQuestionComponent implements OnInit {
  
  questions: Question;
  quizId: number

  constructor(private service: QuestionService,
    private route: ActivatedRoute) { }
 
  ngOnInit(): void {
    this.service.getQuestions().subscribe((question) => 
    {this.questions= question;})
  }

  deleteQuestionInQuiz(questionId)
  {
    this.quizId = +this.route.snapshot.paramMap.get('quizId');
    this.service.deleteQuestionFromQuiz(questionId, this.quizId).subscribe();
  }

  goPervious()
  {
    window.history.back();
  }

}
