import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthGuard } from 'src/app/auth/auth.guard';
import { UserService } from '../../user.service';



@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  permittedRole = 'Admin';
  public userRole;
  constructor(public router:Router,
    public service: UserService) { }

  
  ngOnInit(): void {
    this.userRole = this.service.checkIfAdmin(this.permittedRole);
  }
  
  onLogout()
  {
    localStorage.removeItem('token');
    this.router.navigate(['/login']);
  }


}
