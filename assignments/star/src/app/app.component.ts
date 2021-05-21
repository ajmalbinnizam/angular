import { Component, VERSION } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'star assignment';
  imgUrl = 'https://angular.io/assets/images/logos/angularjs/AngularJS-Shield.svg'
  name="Angular v"+VERSION.major;
  currentRate = 0;
}
