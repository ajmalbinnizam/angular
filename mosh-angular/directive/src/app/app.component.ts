import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  // title = 'directive';
product =["watch"];
// courses = [1];
courses;
 viewMode ='map';

//  courses = [{obj:property},{obj:property}]
courzes = [
  {id:1, name:'data science'},
  {id:2, name:'mean'},
  {id:3, name:'lamp'},]

  onAdd(){
    this.courzes.push({id:4, name:'dm'});}

  onRemove(course){
    let index = this.courzes.indexOf(course)
    this.courzes.splice(index, 3) //array.splice(index, howmany, item1, ....., itemX)
    // console.log(splice,index)
  }
  //ngFor trackby
  load(){
    this.courses=[
      {id:1, name:'data science'},
      {id:2, name:'mean'},
      {id:3, name:'lamp'},
    ]
  }
  trackCourse(index,course){
    return course ? course.id :undefined;
  }
  canSave = true;
  task = {
    assignee:{ name:{last:'ajmal'}},
    // assignee:{ name:{}}
    position: 'analyst'
  }
}
