import { EventEmitter } from "@angular/core";
import { Ingredient } from "../shared/ingredient.model";

export class ShoppingListService {
    addIngredientEmit = new EventEmitter<Ingredient[]>();
    private  ingredients: Ingredient[] = [
        new Ingredient("chiken", 1),
        new Ingredient("rice", 1),
    ]

    addIngredient(ing: Ingredient){
        this.ingredients.push(ing);
        this.addIngredientEmit.emit(this.ingredients.slice())
    }
    getIngredient() {
        return this.ingredients.slice()
    }
    addIngredientFromRecipe(ingredient :Ingredient[]){
        // for(let ing of ingredient){
        //     this.addIngredient(ing) }
        this.ingredients.push(...ingredient)
        this.addIngredientEmit.emit(this.ingredients.slice())
    }
}