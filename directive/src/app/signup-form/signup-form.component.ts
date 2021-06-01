import { AuthorService } from './../../../../hello/src/app/author.service';
import { UsernameValidators } from './username.validators';
import { Component } from '@angular/core';
import{FormGroup, FormControl, Validators} from '@angular/forms'; //create
@Component({
  selector: 'signup-form',
  templateUrl: './signup-form.component.html',
  styleUrls: ['./signup-form.component.css']
})
export class SignupFormComponent {
  //key value should be an instance of a class that derives from AbstractControl.
  form = new FormGroup({
    username: new FormControl('',[
      Validators.required,
      Validators.minLength(5),
      Validators.maxLength(8),
      // UsernameValidators.shouldBeUnique,
      UsernameValidators.cannotContainSpace,
    ],
      UsernameValidators.shouldBeUnique,
    ),

    // username: new FormControl('',
    //   Validators.required,
    //   UsernameValidators.shouldBeUnique),
    password: new FormControl('', Validators.required)
  });


  // login(){
  //   let isValid = authService.login(this.form.value);
  //   if(!isValid){
  //     this.form.setErrors({
  //       invalidLogin:true  })}
  // ----------username or passwrd invalid -
  login(){
    this.form.setErrors({
      invalidLogin:true
    });
  }
//  --nested group




  get username(){
    return this.form.get('username');
  }

}
