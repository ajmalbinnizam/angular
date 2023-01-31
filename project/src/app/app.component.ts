import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  // navigate:boolean = false;
  loadedFeature : string = 'recipe'
  onNavigate(feature:string){
    // feature == 'recipe' ? this.navigate = true : feature == 'shopping' ? this.navigate = true: this.navigate = false;
    this.loadedFeature = feature;
  }
}
