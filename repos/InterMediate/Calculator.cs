using System;

namespace InterMediate
{
    public class Calculator
    {
        public void Add(params int[] number)
        {
            var sum = 0;
            foreach (var item in number)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            //return sum;
        }
        public Calculator() { 
        
        }
    }
}
