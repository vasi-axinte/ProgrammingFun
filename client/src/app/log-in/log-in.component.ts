import { Component, OnInit } from '@angular/core';
import { UserService} from '../shared/user.service';
import { NgForm } from '@angular/forms';
import { UserLoginCredentials } from '../shared/user-login-credentials.model';


@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {

  userLogin: UserLoginCredentials;
  emailPattern = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
  constructor(
   private userService : UserService, ) { }
 
    ngOnInit(): void {
      this.resetForm();
    }
  
    resetForm(form? : NgForm)
    {
      if(form != null)
      form.reset();
      this.userLogin = {
        Email: '',
        Password: ''
      }
    }

  LoginUser(form : NgForm) {
   this.userService.loginUser(form.value).subscribe((data : boolean) => {this.resetForm});
  }
}