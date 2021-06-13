using System;
using System.Linq;


namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int ArrayAmount;
            ArrayAmount = int.Parse(Console.ReadLine());
            int[] marks = new int[ArrayAmount];

            int a = 0;

            Console.WriteLine("Enter ArrayAmount elements:");

            while (a < ArrayAmount)
            {
                if (int.TryParse(Console.ReadLine(), out marks[a]))
                    a++;
                else
                    Console.WriteLine("You didn't enter a number! Please enter again!");
            }

            //First sort method
            Array.Sort(marks);
            Console.Write("Array.Sort's Sort ");
            Console.Write(string.Join(",", marks));
            Console.WriteLine();
            //Second sort method
            Array.Sort<int>(marks, new Comparison<int>((i2, i1) => i2.CompareTo(i1)));
            Console.Write("CompareTo()'s Sort ");
            Console.Write(string.Join(",", marks));
            Console.WriteLine();
            //Third sort method
            Array.Sort<int>(marks, delegate (int m, int n){ return m - n; });
            Console.Write("Delegate's Sort ");
            Console.Write(string.Join(",", marks));
            Console.WriteLine();
            //Forth sort method
            marks = marks.OrderBy(c => c).ToArray();
            Console.Write("LinQ's Sort ");
            Console.Write(string.Join(",", marks));
            Console.WriteLine();
        }
    }
}
