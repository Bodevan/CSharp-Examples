using System;

namespace Random_Numbers_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = 0;

            x = rand.Next(1,11);
            Console.WriteLine($"Decadice random number is: " + x) ;

             
        }
    }
}
