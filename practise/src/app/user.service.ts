import { Injectable } from "@angular/core";
import { Count } from "./count.service";

@Injectable()
export class Users{
    constructor(private count: Count){}
    activeUsers = ['Max', 'Anna'];
    inactiveUsers = ['Chris', 'Manu'];

    setToActive(id: number){
        this.activeUsers.push(this.inactiveUsers[id]);
        this.inactiveUsers.splice(id,1);
        this.count.counter()
    }
    setToInactive(id: number){
        this.inactiveUsers.push(this.activeUsers[id]);
        this.activeUsers.splice(id,1);
        this.count.counter()
    }

}