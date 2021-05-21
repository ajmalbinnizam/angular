import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'fav',
  templateUrl: './fav.component.html',
  styleUrls: ['./fav.component.css']
})
export class FavComponent implements OnInit {
  isFav:boolean;
  constructor() { }

  ngOnInit(){
  }
  onClick(){
    this.isFav= !this.isFav;
  }

}
