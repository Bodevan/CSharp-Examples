using System;

namespace Even_or_Odd_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int? number;
            Console.WriteLine("Hey, can i have your number?");

            do
                number = int.Parse(Console.ReadLine());
            while (number == null);

            if (number % 2 == 0)
                Console.WriteLine("That is a even number");
            else
                Console.WriteLine("That is a odd number");
        }
    }
}
