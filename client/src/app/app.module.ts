import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { UserService } from './shared/user.service';
import {  HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { WelcomepageComponent } from './welcomepage/welcomepage.component';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { QuizComponent } from './quiz/quiz.component';
import { QuizService } from './shared/quiz.service';
import { NavbarComponent } from './shared/nav-bar/navbar/navbar.component';

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
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [UserService, QuizService],
  bootstrap: [AppComponent]
})
export class AppModule { }
