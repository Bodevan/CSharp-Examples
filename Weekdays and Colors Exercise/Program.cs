using System;

namespace Weekdays_and_Colors_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            String weekday;
            Console.WriteLine("Hey, can you tell me what day it is?");
            weekday = Console.ReadLine().ToLower().Trim();

            // o objetivo desse exercicio era usar switxch
            switch (weekday) 
            {
                case "sunday":
                    Console.WriteLine($"Oh so today is {weekday}? thank you");   
                    break;
                case "monday":
                    Console.WriteLine($"Oh so today is {weekday}? thank you"); 
                    break;
                case "tuesday":
                    Console.WriteLine($"Oh so today is {weekday}? thank you"); 
                    break;
                case "wednesday":
                    Console.WriteLine($"Oh so today is {weekday}? thank you"); 
                    break;
                case "thursday":
                    Console.WriteLine($"Oh so today is {weekday}? thank you"); 
                    break;
                case "friday":
                    Console.WriteLine($"Oh so today is {weekday}? thank you"); 
                    break;
                case "saturday":
                    Console.WriteLine($"Oh so today is {weekday}? thank you"); 
                    break;
                default: 
                    Console.WriteLine($"Stop being a smartass and tell me the day already"); 
                    break;
            }
        }
    }
}
