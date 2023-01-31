import { EventEmitter, Injectable } from "@angular/core"

// @Injectable()
export class Count{
    constructor(){}
    num: number = 0
    count = new EventEmitter<number>()
    counter(){
        this.num++
        this.count.emit(this.num)
    }
}