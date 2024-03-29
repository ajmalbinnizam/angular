import { Directive, ElementRef, HostBinding, HostListener, OnInit } from '@angular/core';

@Directive({
    selector: '[appDropDown]'
})
export class AppDropDown {
    constructor(private elRef: ElementRef) {}

    @HostBinding('class.open') isOpen = false;

    @HostListener('document:click', ['$event']) toggleOpen(event: Event) {
      this.isOpen = this.elRef.nativeElement.contains(event.target) ? !this.isOpen : false;
    }
}