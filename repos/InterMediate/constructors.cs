using System;
using System.Collections.Generic;
using System.Text;


namespace InterMediate
{
    public class Order
    {
    }
    class constructors
    {
        int id; 
        string name;
        //we can store type object of orders
        public List<Order> orders;
        public constructors()
        {
            //a new list of object must be always initialized
            orders = new List<Order>();
        }
        public constructors(int idPara )
            // contructor with default parameterless constructor will be called
            :this()
        {
            id = idPara;
        }
        public constructors(int idPara, string name)
            :this(idPara)
        {
            this.name = name;
        }
    }
    //legacy way of constructors
    class Person
    {
        public string names;
        public void Introduce(string namePara)
        {
            Console.WriteLine("hi {0}, my name is {1}", namePara, names);
        }
        public static Person Parse(string str)
        {
            var per = new Person();
            per.names = str;
            return per;

        }
    }
        
}
