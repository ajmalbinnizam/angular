using System;
using System.Collections.Generic;
using System.Text;

namespace brocode
{
    class hackerrank
    {
        //int n = Convert.ToInt32(Console.ReadLine().Trim());
        //string[] arr = new string[n];
        //for (int i = 0; i<n; i++)
        //{
        //    String arrNum = Console.ReadLine().Trim();
        //arr[i] = arrNum;

        //}
        //for (int j = n - 1; j >= 0; j--)
        //{
        //    Console.Write(arr[j] + " ");
        //}
        ///day 7 dictionary
        //var dict = new Dictionary<string, string>();
        //int n = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    var name = Console.ReadLine().Trim().Split(' ');
        //    dict.Add(name[0],name[1]);
        //}
        ////for (int i = 0; i < n; i++)
        ////{
        ////    var name2 = Console.ReadLine();
        ////    if (dict.ContainsKey(name2))
        ////    {
        ////        Console.WriteLine(name2 + "=" + dict[name2]);
        ////    }
        ////    else
        ////    {
        ////        Console.WriteLine("Not Found");
        ////    }
        ////}

        //String name2;
        //while ((name2 = Console.ReadLine()) != null)
        //{
        //    try
        //    {
        //        Console.WriteLine($"{name2}={dict[name2]}");
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Not found");
        //    }
        //}


        //foreach (var item in dict)
        //{
        //    Console.WriteLine($"{ item.Key}, {item.Value}");
        //}

        //day8 recursion

        //public static int expo(int n)
        //{
        //    if (n <= 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return n + expo(n - 1);
        //    }
        ///day 10 binary    
        //find the consecutive 11 of binary number ==> base10= 2 == 10; 439 ==110110111 : consecutive 1s will be 3  
        //        int n = Convert.ToInt32(Console.ReadLine().Trim());
        //        int rem;
        //        var remList = new List<int>();
        //        int binCon = 0;
        //        int binMax = 0;
        //            while (n>0)
        //            {
        //                remList.Add(rem = n % 2);
        //                n = n / 2;
        //            }
        //    remList.Reverse();
        //            foreach (var item   in remList)
        //            {
        //                if (item ==1)
        //                {
        //                    binCon++;
        //                    if (binCon > binMax)
        //                    {
        //                        binMax = binCon;
        //                    }
        //                }
        //                else
        //{
        //    binCon = 0;

        //}
        //            }
        //            Console.WriteLine(binMax);
        ///day11: 2d array
        //   List<List<int>> arr = new List<List<int>>();
        //        for (int i = 0; i< 6; i++)
        //        {
        //            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        //        }
        //int result = -9 * 7;
        //int rowCount = arr.Count;
        //int columnCount = arr[0].Count;

        //        for (int r = 0; r<columnCount - 2; r++)
        //        {
        //            for (int c = 0; c<rowCount - 2; c++)
        //            {
        //                int firstRowSum = arr[r][c] + arr[r][c + 1] + arr[r][c + 2];
        //int secondRowSum = arr[r + 1][c + 1];
        //int thirdRowSum = arr[r + 2][c] + arr[r + 2][c + 1] + arr[r + 2][c + 2];
        //int totalHourGlass = firstRowSum + secondRowSum + thirdRowSum;

        //                if (totalHourGlass>result)
        //                {
        //                    result = totalHourGlass;
        //                }
        //            }
        //        }
        //        Console.WriteLine(result);
        ///day12 inheritance
        //class Person
        //	{
        //		protected string firstName;
        //		protected string lastName;
        //		protected int id;

        //		public Person() { }
        //		public Person(string firstName, string lastName, int identification)
        //		{
        //			this.firstName = firstName;
        //			this.lastName = lastName;
        //			this.id = identification;
        //		}
        //		public void printPerson()
        //		{
        //			Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        //		}
        //	}

        //	class Student : Person
        //	{

        //		private int[] testScores;
        //		public Student(string firstName, string lastName, int identification, int[] scores)
        //		{
        //			this.firstName = firstName;
        //			this.lastName = lastName;
        //			this.id = identification;
        //			this.testScores = scores;
        //		}

        //        public string grade { get; private set; }

        //        public string Calculate()
        //        {
        //			int totalScores = 0;
        //            for (int i = 0; i < testScores.Length; i++)
        //            {
        //                totalScores += testScores[i];
        //            }
        //            switch (totalScores)
        //            {
        //				case int n when(n>=90 || n<=100):
        //                    grade = "O";
        //                    break;
        //				case int n when (n >= 80 || n <= 90):
        //					grade = "A";
        //					break;
        //				case int n when (n >= 70 || n <= 80):
        //					grade = "B";
        //					break;
        //				case int n when (n >= 60 || n <= 70):
        //					grade = "C";
        //					break;
        //            }
        //			return grade;
        //        }

        //	}

        //	class Solution
        //	{
        //		static void Main()
        //		{
        //			string[] inputs = Console.ReadLine().Split();
        //			string firstName = inputs[0];
        //			string lastName = inputs[1];
        //			int id = Convert.ToInt32(inputs[2]);
        //			//2
        //			int numScores = Convert.ToInt32(Console.ReadLine());
        //			//100 80
        //			inputs = Console.ReadLine().Split();
        //			int[] scores = new int[numScores];
        //			for (int i = 0; i < numScores; i++)
        //			{
        //				scores[i] = Convert.ToInt32(inputs[i]);
        //			}

        //			//Student s = new Student(firstName, lastName, id, scores);
        //			//s.printPerson();
        //			//Console.WriteLine("Grade: " + s.Calculate() + "\n");
        //		}
        //	}
        //}
        ///day13 abstract
        //        String title = Console.ReadLine();
        //        String author = Console.ReadLine();
        //        int price = Int32.Parse(Console.ReadLine());
        //        Book new_novel = new MyBook(title, author, price);
        //        new_novel.display();
        //        }
        //}
        //abstract class Book
        //{
        //    protected String title;
        //    protected String author;
        //    public Book(String t, String a)
        //    {
        //        title = t;
        //        author = a;
        //    }
        //    public abstract void display();
        //}
        //class MyBook : Book
        //{

        //    public int price;
        //    public MyBook(string author, string title, int price) : base(title, author)
        //    {
        //        this.price = price;
        //    }
        //    public override void display()
        //    {
        //        Console.WriteLine("Title : {0} \nAuthor : {1} \nPrice : {2}", title, author, price);
        //    }
        ///day13 scope arrayMinMax
        //        Convert.ToInt32(Console.ReadLine());
        //            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        //        Difference d = new Difference(a);
        //        d.computeDifference();
        //            Console.Write(d.maximumDifference);
        //        }
        //}

        //class Difference
        //{
        //    private int[] elements;
        //    public int maximumDifference;
        //    public Difference(int[] a)
        //    {
        //        elements = a;
        //    }
        //    public void computeDifference()
        //    {
        //        //maximumDifference = elements.Max() - elements.Min();
        //        //bigOnotation
        //        //int min = 100;
        //        //int max = 1;
        //        //for (int i = 0; i < n; ++i)
        //        //{
        //        //    if (elements[i] < min) { min = elements[i]; }
        //        //    if (elements[i] > max) { max = elements[i]; }
        //        //}
        //        //old fashioned way
        //        int n = elements.Length;
        //        int initMin = elements[0];
        //        int initMax = elements[0];

        //        for (int i = 0; i < n; i++)
        //        {
        //            if (elements[i] > initMax)
        //            {
        //                initMax = elements[i];
        //            }
        //        }
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (elements[j] < initMin)
        //            {
        //                initMin = elements[j];
        //            }
        //        }
        //        maximumDifference = initMax - initMin;
        //    }

    }
}



