import { Component, OnInit } from '@angular/core';
import { QuestionService} from '../shared/question.service';
import { Question } from '../question';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-insert-questions',
  templateUrl: './insert-questions.component.html',
  styleUrls: ['./insert-questions.component.css']
})
export class InsertQuestionsComponent implements OnInit {

  constructor(private service: QuestionService,
    private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.getQuestions();
  }
  questions: Question;
  questionId: number
  quizId: number
 
  getQuestions()
  {
    this.service.getQuestions().subscribe((question) => 
    {this.questions= question;})
  }

  insertQuestionInQuiz(questionId)
  {
    this.quizId = +this.route.snapshot.paramMap.get('quizId');
    this.questionId=questionId;
    this.service.insertQuestionInQuiz(this.questionId, this.quizId).subscribe();
  }
}