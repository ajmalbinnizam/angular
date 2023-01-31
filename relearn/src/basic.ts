let age:number = 21;
let nam:string ="ajmal";

let hobbies: string[];
hobbies = ["guitar", "coding"];

let person: {
    name:string,
    age:number
};
function level():number{
    return 1+2;
}
person = {
    name:"aju",
    age:21
}
let people:{
    name: string;
    age:number
}[];

//function and parameters
//type inference- expilicitly assigning values
let boool = true;

//working with union types

type Person = {
    name:string,
    age:number
}
let per:Person;

per = {
    name:"aju",
    age:22
}
// generic
//when a type of function returns any number we have to implicitly convert the value to the returned , so we use <T> before the para
// offering type safety and flexibility: T type of any identifier of your choice

function insertBegining<T>(array:T[], value:T){
    return [value, ...array];  //spread array
};
const myArray = [1,2,3];
const updatedArray = insertBegining(myArray, 3);
const stringArray = insertBegining(['a', 'b'], 'a')

class Student{
    // firstName: string;
    // lastName: string;
    // private courses: string[];
   
    // constructor(first?: string, courses?:string[]) {
    //     this.firstName = first;
    //     this.courses = courses;
    // }
    constructor(
        public firstName: string, public courses: string[]
    ) { }

    enroll(course:string){
        this.courses.push(course);    
    }
    
    listCourses(){
        return this.courses.slice();
    }
}
const student = new Student('aju', ['ml', 'ds']);
// const student1 = new Student();
// student.courses
student.enroll("angular")
student.listCourses();  //=> ml,ds,angular


// interface can be implemented in classes force class to follow a specific structure

interface Programmer{
    lang: string;
    experience:number;
    level: () => void
}
class candidate implements Programmer{
    lang: string = 'typescript';
    experience: number =1;
    level(){
    return 1+2;
    }
}

