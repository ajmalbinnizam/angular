import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';//import pipes
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FavComponent } from './fav/fav.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TitleCasePipe } from './title-case.pipe';

@NgModule({
  declarations: [
    AppComponent,
    FavComponent,
    TitleCasePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
