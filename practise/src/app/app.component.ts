import { Component, OnChanges, OnInit } from '@angular/core';
import { Count } from './count.service';
import { Users } from './user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [Users]
})
export class AppComponent implements OnInit{

  constructor(private user: Users,
              private count: Count){
               
  }
  active: string[]
  inactive: string[]
  action: number

  ngOnInit(): void {
    this.active = this.user.activeUsers
    this.inactive = this.user.inactiveUsers
    this.action = this.count.num
    this.count.count.subscribe(data => this.action = data)

  }

}
