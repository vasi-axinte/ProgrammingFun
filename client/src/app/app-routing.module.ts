import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { AuthGuard } from './auth/auth.guard';
import { DeleteQuestionComponent } from './delete-question/delete-question.component';
import { HomeComponent } from './home/home.component';
import { InsertQuestionsComponent } from './insert-questions/insert-questions.component';
import { LoginComponent } from './login/login.component';
import { QuestionCreatorComponent } from './question-creator/question-creator.component';
import { QuizCreatorComponent } from './quiz-creator/quiz-creator.component';
import { QuizEditorComponent } from './quiz-editor/quiz-editor.component';
import { QuizComponent } from './quiz/quiz.component';
import { QuizzesComponent } from './quizzes/quizzes.component';
import { QuizSentConfirmationComponent } from './quiz-sent-confirmation/quiz-sent-confirmation.component'
import { SignUpComponent} from './sign-up/sign-up.component';
import { WelcomepageComponent} from './welcomepage/welcomepage.component';
import { QuizzesTakenComponent } from './quizzes-taken/quizzes-taken.component';


const routes: Routes = [
  { path: '', redirectTo:'welcome', pathMatch:'full'},
  { path: 'welcome', component: WelcomepageComponent, canActivate:[AuthGuard]},
  { path: 'sign-up', component: SignUpComponent},
  { path: 'login', component: LoginComponent},
  { path: 'home', component: HomeComponent, canActivate:[AuthGuard]},
  { path: 'admin', component: AdminPanelComponent, canActivate:[AuthGuard], data: {permittedRoles:['Admin']}},
  { path: 'quiz/:quizId', component: QuizComponent, canActivate:[AuthGuard]},
  { path: 'quiz', component: QuizzesComponent, canActivate:[AuthGuard], data :{permittedRoles:['Admin']}},
  { path: 'questionCreator', component:QuestionCreatorComponent, canActivate:[AuthGuard], data:{permittedRoles:['Admin']}},
  { path: 'quizCreator', component:QuizCreatorComponent, canActivate:[AuthGuard], data: {permittedRoles:['Admin']}},
  { path: 'insertQuestion/:quizId', component:InsertQuestionsComponent, canActivate:[AuthGuard], data: {permittedRoles:['Admin']}},
  { path: 'editQuiz/:quizId', component:QuizEditorComponent, canActivate:[AuthGuard], data: {permittedRoles:['Admin']}},
  { path: 'deleteQuestion/:quizId', component:DeleteQuestionComponent, canActivate:[AuthGuard], data: {permittedRoles:['Admin']}},
  { path: 'quizConfirmation', component: QuizSentConfirmationComponent, canActivate:[AuthGuard]},
  { path: 'quizzesTaken', component: QuizzesTakenComponent, canActivate:[AuthGuard], data: {permittedRoles:['Admin']}}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
