import { ShoppingListService } from '../shopping-list/shopping-list.service';
import { EventEmitter, Injectable } from "@angular/core";
import { Recipe } from "./recipe.model";
import { Ingredient } from '../shared/ingredient.model';
@Injectable()
export class RecipeService {

    recipeSelected = new EventEmitter<Recipe>();
    private recipes: Recipe[] = [
        new Recipe(
            'biriyani',
            'with 1 egg and 1 piece of meat',
            'https://recipes.timesofindia.com/thumb/msid-53096628,width-1600,height-900/53096628.jpg',
            [new Ingredient("rice", 1),
            new Ingredient("chicken", 2)]),
        new Recipe(
            'Fry Rice',
            'with 1 egg ',
            'https://holycowvegan.net/wp-content/uploads/2020/03/vegetable-fried-rice-5-500x500.jpg',
            [new Ingredient("rice", 1)])
    ];
    constructor(private slService: ShoppingListService){
    }

    getRecipes() {
        return this.recipes.slice();
    }

    getRecipesId(index: number){
         return this.recipes[index];
    }
    addIngredientToShoppingList(passedIngredient: Ingredient[]){
        this.slService.addIngredientFromRecipe(passedIngredient)
    }
}