import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'new-course-form',
  templateUrl: './new-course-form.component.html',
  styleUrls: ['./new-course-form.component.css']
})
export class NewCourseFormComponent implements OnInit {
 categories = [
   { id:1, name:'directives'},
   { id:1, name:'animations'},
   { id:1, name:'https calls'},
 ]
submit(course){
  console.log(course)
}

  constructor() { }

  ngOnInit(): void {
  }

}
