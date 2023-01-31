import { ShoppingListService } from './shopping-list.service';
import { Ingredient } from '../shared/ingredient.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-shopping-list',
  templateUrl: './shopping-list.component.html',
  styleUrls: ['./shopping-list.component.css']
})
export class ShoppingListComponent implements OnInit {
  ingredients: Ingredient[]
  // =[new Ingredient("chiken", 1),
  //   new Ingredient("rice", 1),]

  constructor(private slServie: ShoppingListService) { }

  ngOnInit() {
    this.ingredients = this.slServie.getIngredient();
    // this.slServie.addIngredientEmit.subscribe((data)=> this.ingredients.push(data))
    this.slServie.addIngredientEmit.subscribe((ingredient: Ingredient[]) => this.ingredients = ingredient)

  }

}
