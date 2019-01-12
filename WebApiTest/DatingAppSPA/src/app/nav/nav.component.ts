import { Component } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
/** nav component*/
export class NavComponent {
  model: any = {};

  /** nav ctor */
  constructor() {

  }

  login() {
    console.log(this.model);
  }
}
