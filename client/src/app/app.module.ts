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
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [UserService, QuizService, QuestionService],
  bootstrap: [AppComponent]
})
export class AppModule { }
