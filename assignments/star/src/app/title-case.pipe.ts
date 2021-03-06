import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'titleCase'
})
export class TitleCasePipe implements PipeTransform {

  transform(value: string): any {
    if (!value) return null;

    // let preposition = [ 
    //     'of', 'the','in'
    // ];
    let words = value.split(' ');
    for(var i = 0; i<words.length; i++){
      let word = words[i];
      if(i>0 && this.isPreposition(word))
      words[i] = words[i].toLowerCase();
      else{
        words[i] = this.toTitleCase(word);
      }
    }
    return words.join(' ');
  }

private isPreposition (word:string):boolean{
  let preposition = [ 
    'of', 'the','is', 'a','in', 'at'];
return preposition.includes(word.toLowerCase())
}
private toTitleCase(word: string): string {
  return word.substr(0, 1).toUpperCase() + word.substr(1).toLowerCase();
}

}


// import { Pipe, PipeTransform } from '@angular/core';

// @Pipe({
//   name: 'titleCase'
// })
// export class TitleCasePipe implements PipeTransform {


//   transform(value: string): any {
//     if (!value) return null;

//     let preposition = ['of', 'the','is', 'a','in', 'at'];
//     let words = value.split(' ');
//     for(var i = 0; i<words.length; i++){
//       if( preposition.includes(words[i].toLowerCase()))
//       words[i] = words[i].toLowerCase()
//       else{
//         words[i] = words[i].substr(0,1).toUpperCase() + words[i].substr(1).toLowerCase()
//       }
//     }
//     return words.join(' ');

//   }




// }
