import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'fav',
  templateUrl: './fav.component.html',
  styleUrls: ['./fav.component.css']
})
export class FavComponent implements OnInit {
  @Input('likesCount') likesCount:number;
  @Input('isActive') isActive: boolean;
onClickHeart(){
  this.likesCount += (!this.isActive) ? -1: 1;
  this.isActive = !this.isActive; //is active

}

  isFav:boolean;
  constructor() { }

  ngOnInit(){
  }
  onClick(){
    this.isFav= !this.isFav;
  }

}
