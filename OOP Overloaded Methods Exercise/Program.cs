using System;

namespace OOP_Overloaded_Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            double x = 4, y = 5, z = 6;
            
            Console.WriteLine($"{a} + {b} = {Add(a,b)}");
            
            Console.WriteLine($"{a} + {b} + {c} = {Add(a, b, c)}");
            
            Console.WriteLine($"{x} + {y} = {Add(x, y)}");
            
            Console.WriteLine($"{x} + {y} + {z} = {Add(x, y, z)}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Add(double a, double b, double c)
        {
            return a + b + c;
        }
  
    }
}
