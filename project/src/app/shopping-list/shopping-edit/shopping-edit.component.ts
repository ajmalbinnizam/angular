import { ShoppingListService } from '../shopping-list.service';
import { Ingredient } from '../../shared/ingredient.model';
import { Component, OnInit, ViewChild, ElementRef, Output, EventEmitter,  } from '@angular/core';

@Component({
  selector: 'app-shopping-edit',
  templateUrl: './shopping-edit.component.html',
  styleUrls: ['./shopping-edit.component.css']
})
export class ShoppingEditComponent implements OnInit {

  @ViewChild('amountInput', {static:false}) amountInput: ElementRef;
  
  constructor(private slService: ShoppingListService) { }

  onAdd(name:HTMLInputElement){
    const getName = name.value;
    const getAmount = this.amountInput.nativeElement.value;
    const passedIngredient = new Ingredient(getName, getAmount);
    this.slService.addIngredient(passedIngredient)

  } 
  
  ngOnInit() {
  }

}
