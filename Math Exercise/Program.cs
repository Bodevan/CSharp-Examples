using System;

namespace Math_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 1.5;
            double y = 2.5;
            double z = 9;
            double a = 3;
            double b = 2;
            
            Console.WriteLine($"The Ceiling of {x} is {Math.Ceiling(x)}");
            Console.WriteLine($"The Floor of {x} is {Math.Floor(x)}");
            Console.WriteLine($"The downward rounded form of {1.5} is {Math.Round(x, MidpointRounding.ToZero)}");
            Console.WriteLine($"The upward rounded form of {1.5} is {Math.Round(x, MidpointRounding.AwayFromZero)}");            
            Console.WriteLine($"The Truncate form of {x} is {Math.Truncate(x)}");
            
            Console.WriteLine($"The Higher value between {x}  and {y} is {Math.Max(x, y)}");
            Console.WriteLine($"The Lower value between {x}  and {y} is {Math.Min(x, y)}");
            
            Console.WriteLine($"The square root of {z} is {Math.Sqrt(z)}");
            
            Console.WriteLine($"{a} raised to the power of {b} is {Math.Pow(a, b)}");
        }
    }
}
