import { Injectable, Testability } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { User } from './user.model';
import { UserLoginCredentials } from './user-login-credentials.model';
import { NgIf } from '@angular/common';
import { Observable } from 'rxjs';

@Injectable()
export class UserService {
  readonly rootUrl = 'https://localhost:57094/api';
  constructor(private http: HttpClient) { }

  registerUser(user : User) {
    const body: User = {
      UserId: user.UserId,
      FirstName: user.FirstName,
      LastName: user.LastName,
      Email: user.Email,
      Password: user.Password,
    }
    return this.http.post(this.rootUrl + '/Users', body);
  }

  loginUser(userLogin : UserLoginCredentials)
  {
    const body: UserLoginCredentials = {
      Email: userLogin.Email,
      Password: userLogin.Password,
    }
   return this.http.post(this.rootUrl + '/api/User/Login', body)
  }
}