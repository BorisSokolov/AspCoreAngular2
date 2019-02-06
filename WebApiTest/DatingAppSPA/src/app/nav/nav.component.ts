import { Component } from '@angular/core';
import { AuthService } from "../_services/auth.service";
import { AlertifyService } from "../_services/alertify.service";

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
/** nav component*/
export class NavComponent {
  model: any = {};

  /** nav ctor */
  constructor(private authService: AuthService, private alertify: AlertifyService) {

  }

  login() {
    this.authService.login(this.model).subscribe(next => {
        this.alertify.success("Logged in succesfully");
    },
      error => {
        this.alertify.error(error);
      }
    );
  }

  loggedIn() {
    const token = localStorage.getItem('token');
    return !!token;
  }

  logout() {
    localStorage.removeItem('token');
    this.alertify.message('logged out');
  }
}
