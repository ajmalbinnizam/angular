import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Users } from '../user.service';

@Component({
  selector: 'app-active-users',
  templateUrl: './active-users.component.html',
  styleUrls: ['./active-users.component.css']
})
export class ActiveUsersComponent {
  @Input() users: string[];
   constructor(private user: Users){}

  onSetToInactive(id: number) {
    this.user.setToInactive(id)
  }
}
