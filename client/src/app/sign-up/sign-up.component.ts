import { Component, OnInit } from '@angular/core';
import { UserService } from '../shared/user.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  constructor(public service: UserService,
    private toastr: ToastrService) {}

  ngOnInit(): void {
    this.service.formModel.reset();
  }

  onSubmit(){
    this.service.register().subscribe(
      (res:any) => {
        if (res.succeeded) {
        this.service.formModel.reset();
        this.toastr.success('Registration successful!');
      }
      else {
        res.errors.forEach(element => {
          switch (element.code) {
              case 'DuplicateUserName':
                this.toastr.error('Username is already taken');
                break;

              case  'InvalidEmail':
                this.toastr.error('This email is already used');
                break;
              
              default:
                this.toastr.error(element.description, 'Registration failed');
                break;
          }
        });
      }
    },
    err => {
      console.log(err);
    });
  }
}
