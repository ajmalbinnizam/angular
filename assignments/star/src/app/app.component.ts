import { Component, VERSION } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  tweet = {
    body: '...',
    likesCount:365,
    isLiked:true,
  }
  title = 'Assignments';
  imgUrl = 'https://angular.io/assets/images/logos/angularjs/AngularJS-Shield.svg'
  name="Angular v"+VERSION.major;
  currentRate = 0;
  inp:string;
  reload() {
    window.location.reload();
   }

  

}
