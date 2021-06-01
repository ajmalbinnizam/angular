// import { Validators } from "@angular/forms";

import { AbstractControl, ValidationErrors, Validators } from "@angular/forms";
// import { promises, resolve } from "dns";
export class UsernameValidators{
 static cannotContainSpace(control:AbstractControl):Validators |null{
        if((control.value as string).indexOf(' ') >=0)
            return{cannotContainSpace:true};
            return null;  }


    // static shouldBeUnique(control:AbstractControl):ValidationErrors |null{
    //    setTimeout(() => {
    //     //    console.log('ok');
    //     if (control.value === 'aju')
    //         return {shouldBeUnique:true};
    //     return null; 
    //    }, 2000);
    //  return null;
    // }

    // ------------ASYNCHRONOUS FUNCTION-----------------
    // interface AsyncValidatorFn {(control: AbstractControl): 
    //     Promise<ValidationErrors | null> | Observable<ValidationErrors | null>
    static shouldBeUnique(control:AbstractControl):Promise<ValidationErrors | null>{
        return new Promise((resolve, reject) =>{
                // return (true)
            setTimeout(() => {
                if (control.value === 'ajmal')
                    resolve({shouldBeUnique:true}); 
                else 
                    resolve(null); 
            }, 2000); //2 sec timeout
    
        });
    }

}
