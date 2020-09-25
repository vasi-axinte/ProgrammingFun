import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { SignUpComponent} from './sign-up/sign-up.component';

const routes: Routes = [
  { path: '', redirectTo:'login', pathMatch:'full'},
  { path: 'sign-up', component: SignUpComponent },
  { path: 'login', component: LoginComponent},
  { path: 'home', component: HomeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
