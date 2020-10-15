import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { AuthGuard } from './auth/auth.guard';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { QuestionCreatorComponent } from './question-creator/question-creator.component';
import { QuizCreatorComponent } from './quiz-creator/quiz-creator.component';
import { QuizComponent } from './quiz/quiz.component';
import { QuizzesComponent } from './quizzes/quizzes.component';
import { SignUpComponent} from './sign-up/sign-up.component';
import { WelcomepageComponent} from './welcomepage/welcomepage.component';


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
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
