import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from './auth/auth.guard';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { SignUpComponent} from './sign-up/sign-up.component';
import { WelcomepageComponent} from './welcomepage/welcomepage.component';


const routes: Routes = [
  { path: '', redirectTo:'welcome', pathMatch:'full'},
  { path: 'welcome', component: WelcomepageComponent},
  { path: 'sign-up', component: SignUpComponent },
  { path: 'login', component: LoginComponent},
  { path: 'home', component: HomeComponent, canActivate:[AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
