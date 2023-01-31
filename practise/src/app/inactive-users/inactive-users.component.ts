import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Users } from '../user.service';

@Component({
  selector: 'app-inactive-users',
  templateUrl: './inactive-users.component.html',
  styleUrls: ['./inactive-users.component.css']
})
export class InactiveUsersComponent {
  @Input() users: string[];
  constructor(private user: Users){}
 
  onSetToActive(id: number) {
    this.user.setToActive(id)
  }
}
