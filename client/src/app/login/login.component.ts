import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from '../shared/user.service';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  
  formModel ={
    UserName: '',
    Password: '',
  }
  
  constructor(private service:UserService,
    private router: Router,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm)
  {
    this.service.login(form.value).subscribe((res:any) => {localStorage.setItem('token', res.token);
    this.router.navigateByUrl('/home');
  },
    err=> { 
      this.toastr.error('Incorrect user or email!');
      this.service.getUserProfile(this.formModel.UserName).subscribe();
    }
  );
  }
}
