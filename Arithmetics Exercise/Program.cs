using System;

namespace Arithmetics_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            float number_1 = 0, number_2 = 0;

            Console.WriteLine("Hey can i have your number?");
            number_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Thanks! Now give me another one:");
            number_2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number_1} + {number_2} = {number_1 + number_2}");
            Console.WriteLine($"{number_1} - {number_2} = {number_1 - number_2}");
            Console.WriteLine($"{number_1} * {number_2} = {number_1 * number_2}");
            Console.WriteLine($"{number_1} / {number_2} = {number_1 / number_2}");
            Console.WriteLine($"{number_1} % {number_2} = {number_1 % number_2}");

            
        }
    }
}
