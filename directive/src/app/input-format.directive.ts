import { Directive,ElementRef,HostListener, Input } from '@angular/core';
//dom element listener -->HostListener 
@Directive({
  selector: '[appInputFormat]'
})

export class InputFormatDirective {
  @Input('format') format;
  //element reference object
  constructor(private el:ElementRef) { }

  @HostListener('blur')onBlur(){
    
    let value : string = this.el.nativeElement.value; //gives acces to the dom 
    if(this.format == 'lowercase')
    this.el.nativeElement.value = value.toLowerCase();
    else
    this.el.nativeElement.value = value.toUpperCase();

  }


}
