using System.Collections.Generic;
using System;

namespace InterMediate
{
    public class Customers
    {
        public int id;
        public string name;
        public readonly List<Orders> orders = new List<Orders>(); //fields cannot be assigned to accept values

        public Customers()
        {
            orders = new List<Orders>();
        }
        public Customers(int id, string name)
            :this()
        {
            this.id = id;
            this.name = name;
        }
        public void Promote()
        {
            //orders = new List<Orders>();
        }

    }
    public class Orders
    {

    }
}
