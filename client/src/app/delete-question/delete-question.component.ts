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

  constructor(private service: QuestionService,
    private route: ActivatedRoute) { }
  questions: Question;
  quizId: number

  ngOnInit(): void {
    this.service.getQuestions().subscribe((question) => 
    {this.questions= question;})
  }

  deleteQuestionInQuiz(questionId)
  {
    this.quizId = +this.route.snapshot.paramMap.get('quizId');
    this.service.deleteQuestionFromQuiz(questionId, this.quizId).subscribe();
  }

  

}
