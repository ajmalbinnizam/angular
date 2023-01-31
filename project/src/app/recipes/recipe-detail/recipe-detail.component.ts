import { RecipeService } from '../recipes.service';
import { Recipe } from '../recipe.model';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-recipe-detail',
  templateUrl: './recipe-detail.component.html',
  styleUrls: ['./recipe-detail.component.css']
})
export class RecipeDetailComponent implements OnInit {
 recipeDetail:Recipe
 id:number
  constructor(private recipeService: RecipeService,
              private route: ActivatedRoute) { }

  ngOnInit() {
    // const id = this.route.snapshot.params['id']
    this.route.params.subscribe((params:Params)=>{
      this.id = +params['id'] //+ cast to a number 
      this.recipeDetail = this.recipeService.getRecipesId(this.id)
    })
  }
  addShoppingList(){
    this.recipeService.addIngredientToShoppingList(this.recipeDetail.ingredient)

  }

}
