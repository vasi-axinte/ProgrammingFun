import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { UserService } from './shared/user.service';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { WelcomepageComponent } from './welcomepage/welcomepage.component';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { QuizComponent } from './quiz/quiz.component';
import { QuizService } from './shared/quiz.service';
import { NavbarComponent } from './shared/nav-bar/navbar/navbar.component';
import { QuizzesComponent } from './quizzes/quizzes.component';
import { QuestionCreatorComponent } from './question-creator/question-creator.component';
import { QuestionService } from './shared/question.service';
import { QuizCreatorComponent } from './quiz-creator/quiz-creator.component';
import { InsertQuestionsComponent } from './insert-questions/insert-questions.component';
import { QuizEditorComponent } from './quiz-editor/quiz-editor.component';
import { DeleteQuestionComponent } from './delete-question/delete-question.component';
import { QuizSentConfirmationComponent } from './quiz-sent-confirmation/quiz-sent-confirmation.component';
import { QuizzesTakenComponent } from './quizzes-taken/quizzes-taken.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { InspectQuizComponent } from './inspect-quiz/inspect-quiz.component';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
  declarations: [
    AppComponent,
    SignUpComponent,
    LoginComponent,
    HomeComponent,
    WelcomepageComponent,
    AdminPanelComponent,
    QuizComponent,
    NavbarComponent,
    QuizzesComponent,
    QuestionCreatorComponent,
    QuizCreatorComponent,
    InsertQuestionsComponent,
    QuizEditorComponent,
    DeleteQuestionComponent,
    QuizSentConfirmationComponent,
    QuizzesTakenComponent,
    InspectQuizComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    MatButtonModule,
    MatDialogModule,
    NgbModule
  ],
  providers: [UserService, QuizService, QuestionService],
  bootstrap: [AppComponent],
  entryComponents: [QuizEditorComponent]
})
export class AppModule { }
