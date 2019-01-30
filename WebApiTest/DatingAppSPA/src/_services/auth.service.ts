import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable()
export class AuthService {

  baseUrl = 'http://localhost:56433/api/auth/';

  //baseUrl = 'https://localhost:5001/api/auth/';

  constructor(private http: HttpClient) {

  }

  login(model: any) {
    return this.http.post(this.baseUrl + 'login', model)
      .pipe(
      map((response: any) => {
        const user = response;
        if (user) {
          localStorage.setItem('token', user.token);
        }
      }));
  }
}
