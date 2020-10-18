import { Component, OnInit } from '@angular/core';
import { QuestionService} from '../shared/question.service';
import { Question } from '../question';
@Component({
  selector: 'app-insert-questions',
  templateUrl: './insert-questions.component.html',
  styleUrls: ['./insert-questions.component.css']
})
export class InsertQuestionsComponent implements OnInit {

  constructor(private service: QuestionService) { }

  ngOnInit(): void {
    this.getQuestions();
  }
  questions: Question;
 
  getQuestions()
  {
    this.service.getQuestions().subscribe((question) => 
    { this.questions= question;})
  }
}
