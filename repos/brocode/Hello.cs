using System;
using System.Collections.Generic;
using System.Text;

namespace brocode
{
    static class hello
    {
        public static void Hi()
        {
            Console.WriteLine("hello");
        }

        // Console.WriteLine("Hi welcome to kfc!");

        //    Kfc user = new Kfc("LJ");
        //    Kfc.Menu();
        //    user.juice();

        //}
        //class Kfc
        //{
        //    String drinks;

        //    public Kfc(String drinks)
        //    {
        //        this.drinks = drinks;
        //    }
        //    public void juice()
        //    {
        //        Console.WriteLine("drinks are:"+ drinks);
        //    }
        //    public static void Menu()//Kfc.Menu() only for static
        //    {
        //        Console.WriteLine("the menu chicken biriyani, fry rice");
        //    }

        //}
        //    Laptop aju = new Laptop("dell", 2020);
        //    aju.Show();

        //    }
        //class Laptop
        //{
        //    String model; int year;
        //    public Laptop(String model, int year)
        //    {
        //        this.model = model;
        //        this.year = year;
        //    }
        //    public void Show()
        //    {
        //        Console.WriteLine($"you have a {model} {year}");
        //    }
        //}


        //    Laptop aju = new Laptop("dell", 2020);
        //    aju.Show();

        //}
        //class Laptop
        //{
        //    String model; int year;
        //    public Laptop(String model, int year)
        //    {
        //        this.model = model;
        //        this.year = year;
        //    }
        //    public void Show()
        //    {
        //        Console.WriteLine($"you have a {model} {year}");
        //    }
        //}

        //     // static = modifier to declare a staic member,which belong to the class rather than object

        //    Car car1 = new Car("maruthi");
        //    Car car2 = new Car("suzuki");
        //    //Console.WriteLine(car1.numOfCars);
        //    Console.WriteLine(Car.numOfCars);

        //}
        //class Car
        //{
        //    public static int numOfCars;
        //    String model;
        //    public Car(String model)
        //    {
        //        this.model = model;
        //        numOfCars++;
        //    }
        //}


        //     Parent parent = new Parent();
        //        Child child = new Child();
        //        child.inher();

        //    }

        //}

        //class Parent 
        //{
        //    public void inher()
        //    {
        //        Console.WriteLine("im helping");
        //    }
        //}
        //class Child : Parent
        //{
        //    public int needHelp = 3;
        //}

        //        int highest_marks = maximum(marks);

        //        Console.WriteLine("The highest score is " + highest_marks); 
        //        }
        //}

        //// method to find maximum
        //public static int maximum(int[] numbers)
        //{
        //    int maxSoFar = numbers[0];

        //    // for each loop 
        //    foreach (int num in numbers)
        //    {
        //        if (num > maxSoFar)
        //        {
        //            maxSoFar = num;
        //        }
        //    }
        //    return maxSoFar;
        //} 
        ///base constructor

//        AreaOfTank T = new AreaOfTank("red", 2, 3);
//        T.displayColor();
//            T.DisplayDimension();
//            Console.WriteLine($"area of tank is {T.Area()}");
        
//        }
//}

//class Tank
//{
//    int _radius;
//    int _height;
//    public Tank(int r, int h)
//    {
//        Radius = r;
//        height = h;
//    }
//    public int Radius
//    {
//        get
//        {
//            return _radius;
//        }
//        set
//        {
//            _radius = value < 0 ? -value : value;
//        }
//    }
//    public int height
//    {
//        get
//        {
//            return _height;
//        }
//        set
//        {
//            _height = value > 0 ? value : -value;
//        }
//    }
//    public void DisplayDimension()
//    {
//        Console.WriteLine($" the tank radius is {Radius} , height is {height}");
//    }
//}

//class AreaOfTank : Tank
//{
//    string color;
//    public AreaOfTank(string c, int r, int h) : base(r, h)
//    {
//        //Radius = r; height = h; color = c;
//        color = c;
//    }
//    public double Area()
//    {
//        return Radius * height;
//    }
//    public void displayColor()
//    {
//        Console.WriteLine($"The color of tank is {color}");
//    }
//}



    }
}
