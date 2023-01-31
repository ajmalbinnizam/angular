import { RecipeService } from '../recipes.service';
import { Recipe } from '../recipe.model';
import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent implements OnInit {

  // recipes: Recipe[] = [
  //   new Recipe('biriyani','with 1 egg and 1 piece of meat', 'https://recipes.timesofindia.com/thumb/msid-53096628,width-1600,height-900/53096628.jpg' ),
  //   new Recipe('Fry Rice','with 1 egg ', 'https://holycowvegan.net/wp-content/uploads/2020/03/vegetable-fried-rice-5-500x500.jpg' )
  // ];
  recipes: Recipe[]
  

  constructor(private recipeService: RecipeService ) { }
  ngOnInit() {
    this.recipes = this.recipeService.getRecipes();
  }
  
 




 

}
