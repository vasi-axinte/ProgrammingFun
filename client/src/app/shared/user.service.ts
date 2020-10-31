import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
 
@Injectable({
  providedIn: 'root'
})
export class UserService {

  readonly rootUrl = 'http://localhost:51301/api';

  formModel = this.formBuilder.group({
    UserName : ['',Validators.required],
    FirstName: ['',Validators.required],
    LastName: ['',Validators.required],
    Email: ['',Validators.email],
    Password: ['',Validators.required],
  });

  constructor(private formBuilder : FormBuilder,
    private http:HttpClient,
    public router:Router) { }
 
  register(){
    var body = {
      UserName: this.formModel.value.UserName,
      FirstName: this.formModel.value.FirstName,
      LastName: this.formModel.value.LastName,
      Email: this.formModel.value.Email,
      Password: this.formModel.value.Password,
    };
    return this.http.post(this.rootUrl + '/User/Register', body);
  }

  login(formData){
    return this.http.post(this.rootUrl + '/User/Login', formData);
  }

  roleMatch(allowedRoles): boolean {
    var isMatch = false;
    var payLoad = JSON.parse(window.atob(localStorage.getItem('token').split('.')[1]));
    var userRole = payLoad.role;
    allowedRoles.forEach(element => {
      if(userRole == element) {
        isMatch = true;
      }
      else isMatch = false;
    });
    return isMatch;
  }

  checkIfAdmin(allowedRole): boolean {
    var payLoad = JSON.parse(window.atob(localStorage.getItem('token').split('.')[1]));
    var userRole = payLoad.role;
    if(userRole == allowedRole)
    {
      return true;
    }
    return false;
  }
}