using System;
using System.Collections.Generic;

namespace InterMediate
{
    class Program
    {
        static void Main(string[] args)
        {








            static void Indexers()
            {

            }

            static void UseOut()
            {
                //properties getters and setters - to follow the pricipale of encapsulation
                People people = new People(new DateTime(1997, 5, 27));
                Console.WriteLine(people.Age);

                Customers customers = new Customers(1, "AJU");
                customers.orders.Add(new Orders());
                customers.orders.Add(new Orders());
                customers.Promote();
                Console.WriteLine(customers.orders.Count);

                var result = int.TryParse("123", out int num);
                if (result)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine(string.Empty, "empyt value");
                }
            }
            static void UseParams()
            {
                var cal = new Calculator();
                cal.Add(1, 3, 4, 6, 34);
                cal.Add(new int[] { 1, 3, 3, 3 });
            }
            static void UsePoint()
            {
                try
                {
                    var point = new Point(10, 20);
                    point.Move(new Point(40, 50));
                    point.Move(null);
                    Console.WriteLine("point is at ({0}, {1})", point.x, point.y);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                //var cons = new constructors();
                //var consId = new constructors(3);
                //var consIdName = new constructors(3, "ajmal");
                //var order = new Order();
                //cons.orders.Add(order);

                //------without static modifier
                //var per = new Person();
                //var p = per.Parse("aju");
                //per.Introduce("mosh");

                //var p = Person.Parse("aju");
                //p.Introduce("mosh");
            }

        }
    }
}
