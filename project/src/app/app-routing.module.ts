import { RecipeDetailComponent } from './recipes/recipe-detail/recipe-detail.component';
import { RecipeStartComponent } from './recipes/recipe-start/recipe-start.component';
import { RecipesComponent } from './recipes/recipes.component';
import { NgModule } from "@angular/core";
import { ShoppingListComponent } from './shopping-list/shopping-list.component';
import { RouterModule, Routes } from '@angular/router';
const appRoutes:Routes = [
    { path: '', redirectTo: '/recipes', pathMatch: 'full'}, // 
    { path: 'recipes', component: RecipesComponent, children:[
        {path: '', component: RecipeStartComponent},
        {path: ':id', component:RecipeDetailComponent}
    ] },
    { path: 'shopping-list', component: ShoppingListComponent },
];
@NgModule({
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule]
})
export class AppRoutingModule {

}