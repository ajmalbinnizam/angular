using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace brocode
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                /*string*/
                //String fullName = "ajmal N";
                //fullName = fullName.ToUpper(); Console.WriteLine(fullName);
                //String phoneNumber = "+91-81299";
                //phoneNumber = phoneNumber.Replace("-", " ");
                //String username = fullName.Insert(0, "mr. "); Console.WriteLine(fullName.Length);
                //String firstName = fullName.Substring(0, 5); Console.WriteLine(firstName);

                /*if*/
                //Console.WriteLine("enter your age");
                //int age = Convert.ToInt32(Console.ReadLine());
                //if (age <= 18)
                //{
                //    Console.WriteLine("your are prohibited");
                //}
                //else if(age > 100)
                //{
                //    Console.WriteLine("great to see you here");
                //}
                //else
                //{
                //    Console.WriteLine("you can continue");
                //}

                //Console.WriteLine("enter your name");
                //String name = Console.ReadLine();
                ////if (name == "")
                //if (name != "")
                //{
                //    Console.WriteLine("hello " + name);
                //}
                //else
                //{
                //    Console.WriteLine("you did not enter");
                //}
                //Console.WriteLine("which day of today");
                //String day = Console.ReadLine();
                //switch (day)
                //{
                //    case "friday":
                //        Console.WriteLine("its weekend");
                //        break;
                //    default:
                //        Console.WriteLine("work day");
                //        break;
                //}

                //Console.WriteLine("enter the temperature:(c)");
                //double temp = Convert.ToDouble(Console.ReadLine());
                //if (temp >= 10 && temp <= 30)
                //{
                //    Console.WriteLine("its warm outside");
                //}
                //else if (temp <= -1 || temp >= 30)
                //{
                //    Console.WriteLine("don't go outside");
                //}
                //string name = "";
                //while (name == "")
                //{
                //    Console.Write("whats your name:");
                //    name = Console.ReadLine();
                //}
                //Console.WriteLine("hi" + name);

                //Console.Write("how many rows: ");
                //int rows = Convert.ToInt32(Console.ReadLine());
                //Console.Write("how many columns: ");
                //int cols = Convert.ToInt32(Console.ReadLine());
                //Console.Write("preferred symbol: ");
                //String symbol = Console.ReadLine();

                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < cols; j++)
                //    {
                //        Console.Write(symbol);
                //    }
                //    Console.WriteLine();
                //}

                //String[] cars = new string[3];
                //String[] cars = { "audi", "bena", "bmw" };
                //for (int i = 0; i < cars.Length; i++)
                //{
                //    Console.WriteLine(cars[i]);
                //}
                //String[] cars = { "bmw", "maruthi" };
                //foreach (var item in cars)
                //{
                //    Console.WriteLine(item);
                //}

                //static void happyBirthday(String name)
                //{
                //    Console.WriteLine($"Happy birthday dear {name}");
                //}

                //static double Multiply(double x, double y)
                //{
                //    double a = x * y;
                //    return a;
                //}
                //double total = Checkout(3.5, 4.6, 5.6); Console.WriteLine(total);
                // params that takes a variable number of arguments eg : carts
                //static double Checkout(params double[] prize)
                //{
                //    double total = 0;
                //    foreach (var prise in prize)
                //    {
                //        total += prise;
                //    }
                //    return total;
                // name + parameter = signature :: method should have a unique parameters //}

                //try { }
                //catch (Exception ex) { }
                //finally { }
                // (conditional) ? x : y;
                //message = (temperature <= 15) ? "its warm" : "its cold";
                //multi dimensional array
                //String[,] parkingLot = { { "tata", "nano" }, { "maruthi", "suzuki" } };
                //foreach (String car in parkingLot)
                //{
                //    Console.WriteLine(car);
                //}
                //Kfc user = new Kfc();
                //user.order = Console.ReadLine();
                //user.Order();
                //public void Order()
                //{
                //    Console.WriteLine("your order is: " + order);
                //}

                //    // static = modifier to declare a static member,which belong to the class rather than object
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

                //    //overloaded constructors = multiple parameters with multiple constructors
                //    Bamco res = new Bamco("porotta");
                //}
                //class Bamco
                //{
                //    String main; String kari;
                //    public Bamco(String order)
                //    {
                //        this.main = order;
                //    }
                //    public Bamco(String order, String kari) 
                //    {
                //        this.main = order; this.kari = kari;
                //    } 
                //---abstract class(cannot edit the class) =modifier that indicates missing component or incomplete implementation 

                {


                    //Car car = new Car();
                    //Vehicle veh = new Vehicle();


                    //abstract class Vehicle
                    //    {
                    //        public int speed = 10;
                    //        public void go()
                    //        {
                    //            Console.WriteLine("it working");
                    //        }
                    //    }
                    //    class Car : Vehicle
                    //    {
                    //        public int wheel = 4;
                    //        int maxSpeed = 220;

                    //    }
                    //object argument passing

                    //----------------
                    //                Car car1 = new Car("tata", "white");
                    //                Car car2 = Copy(car1);

                    //                changeColor(car1, "red");
                    //                Console.WriteLine($"the color {car1.color} & brand is {car1.model}");
                    //                Console.WriteLine($"the color {car2.color} & brand is {car2.model}");


                    //            }
                    //            public static Car Copy(Car car)
                    //            {
                    //                return new Car(car.model, car.color);
                    //            }
                    //            public static void changeColor(Car car, String colour)
                    //            {
                    //                car.color = colour;
                    //            }
                    //        }
                    //class Car
                    //    {
                    //        public String model;
                    //        public String color;
                    //        public Car(String model, String color)
                    //        {
                    //            this.model = model;
                    //            this.color = color;
                    //        }
                    //    }
                    //        //method overiding = provides a  new version of a method inherited from the parent class,
                    //                               //the parent class must be a abstract,virtual, ToString
                    //        Dog dog = new Dog();
                    //        dog.speak();

                    //    }
                    //}
                    //class Animal
                    //{
                    //    public virtual void speak()
                    //    {
                    //        Console.WriteLine("its speaking");
                    //    }
                    //}
                    //class Dog : Animal
                    //{
                    //    public override void speak()
                    //    {
                    //        Console.WriteLine("it goes woof");
                    //    }
                    //}
                    //ToString() overriding gives a object the field to be included
                    //        Car car = new Car("tata", 1970);

                    //        Console.WriteLine(car);
                    //    }
                    //}
                    //class Car
                    //{
                    //    String model; int year;
                    //    public Car(String brand, int year)
                    //    {
                    //        this.model = brand;
                    //        this.year = year;
                    //    }
                    //    public override string ToString()
                    //    {
                    //        String message = $"{model} was built in {year}";
                    //        String message1 = "{model},{year}";
                    //        return $"{message}->{message1}";
                    //    }
                    //polymorphism = objects have many types  
                    //interface declares what a class should have, inheriting declares how it should do it
                    //    interface Iprey
                    //{
                    //    void flee();
                    //}
                    //        Car car = new Car(); Bike bike = new Bike();
                    //        Vehicle[] vehicles = { car, bike };
                    //        foreach (Vehicle vehicle in vehicles)
                    //        {
                    //            vehicle.go();
                    //        }

                    //    }
                    //}

                    //class Vehicle
                    //{
                    //   public virtual void go()
                    //    {

                    //    }
                    //}
                    //class Car : Vehicle
                    //{
                    //    public override void go()
                    //    {
                    //        Console.WriteLine("the car is moving");
                    //    }
                    //}
                    //class Bike : Vehicle
                    //{
                    //    public override void go()
                    //    {
                    //        Console.WriteLine("the bike is moving");
                    //    }
                    //// list is a data structure that represents a list of  objects  dynamically increase or decrease in size
                    //List<String> food = new List<string>();
                    //food.Add("biriyani");
                    //food.Add("dosha");
                    //food.Sort(); food.Reverse();
                    //String[] foodArray = food.ToArray();

                    ////String[] car = new String[0];

                    ////car[0] = "tata"; car[1] = "ford";
                    //foreach (var item in food)
                    //{
                    //    Console.WriteLine(item);
                    //    Console.WriteLine(food.Count);
                    //}
                    // list of objects
                    {
                        //        List<Player> players = new List<Player>();
                        //        Player player1 = new Player("Vk");
                        //        players.Add(player1);
                        //        players.Add(new Player("messi"));
                        //        foreach (var player in players)
                        //        {
                        //            Console.WriteLine(player);
                        //        }

                        //    }
                        //}
                        //class Player {
                        //   public String name;
                        //    public Player(String name)
                        //    {
                        //        this.name = name;
                        //    }
                        //    public override string ToString()
                        //    {
                        //        return name;
                        //    }
                        //}
                    }
                    //enum is a class of name = integer constants
                    //        //int radius = (int)Planet.venus;
                    //        double volume = Volume(PlanetRadius.athena);
                    //        Console.WriteLine($"athena's total num is {volume}");
                    //    }
                    //    public static double Volume(PlanetRadius num)
                    //    {
                    //        double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)num, 3);
                    //        return volume;
                    //    }
                    //}
                    //enum Planet
                    //{
                    //    athena, venus, marvel
                    //}
                    //enum PlanetRadius
                    //{
                    //    athena = 13,venus = 12,marvel = 20
                    //}
                }
                //Car car = new Car(400);
                //Console.WriteLine(car.Zpeed);
                //class Car
                //{
                //    private int speed;
                //    public Car(int speed)
                //    {
                //        Zpeed = speed;
                //    }
                //    public int Zpeed
                //    {
                //        get { return speed; } //2nd readable
                //        set                   //1st writable
                //        {
                //            if (value > 100)
                //            {
                //                speed = 90;
                //            }
                //            else
                //            {
                //                speed = value;
                //            }
                //    //generic ="not specific to a particular data type
                //    //add<T> to classes methods, fields etc for accepting different types of datatypes
                //    int[] intArr = { 1, 2, 3 };
                //    String[] stringArr = { "1", "2", "3" };
                //    displayElements(intArr);
                //    displayElements(stringArr);

                //}
                //public static void displayElements<arrayGeneric>(arrayGeneric[] arr)
                //{
                //    foreach (arrayGeneric array in arr)
                //    {
                //        Console.WriteLine(array);
                //    }
                //    Console.WriteLine();

                //thread = execution time of program
                //    Thread mainThread = Thread.CurrentThread;//local variable
                //    mainThread.Name = " starting thread"; //changing name property 
                //    Thread thread1 = new Thread(()=> CountDown("timer#1")); //lambda expression
                //    Console.WriteLine(mainThread.Name+" is completed ");
                //    thread1.Start();
                //}
                //public static void CountDown(String timer)
                //{
                //    for (int i = 10; i >=0 ; i--)
                //    {
                //        Console.WriteLine( timer +i+ "seconds");
                //        Thread.Sleep(1000);
                //    }
                //    Console.WriteLine("timer #1 is complete");
                //}

                //        //lambda expressions are used like anonymous function
                //        // input => expression, input => {statement}
                //        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
                //        var square = numbers.FindAll(x => (x % 2) == 0);
                //        //Select(x => x * x)
                //        Console.WriteLine("square numbers: ");
                //        foreach (var item in square)
                //        {
                //            Console.Write($"{item} ");
                //        }

                //        List<student> studentsName = new List<student>()
                //    {
                //        new student{roll = 1, name = "aju"},
                //        new student{roll = 2, name = "jech"},
                //        new student{roll = 3, name = "hazr"}
                //    };
                //        var order = studentsName.OrderBy(x => x.name);
                //        foreach (var item in order)
                //        {
                //            Console.Write(item.roll + " : " + item.name);
                //        }

                //    }
                //}
                //class student
                //{
                //    public int roll { get; set; }
                //    public string name { get; set; }
                //}

            }


        }
    }
}