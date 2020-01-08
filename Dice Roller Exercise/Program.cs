using System;

namespace Dice_Roller_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string response;

            do
            {
                Console.WriteLine("Roll Dice? (yes, no)");
                response = Console.ReadLine().ToLower();
                

                if (response == "yes")
                    Console.WriteLine($"The dice rolled {rand.Next(1, 7)}");
                else if (response != "no")
                    Console.WriteLine("please write yes or no, not this gibberish");

            } while (response != "no");

            Console.WriteLine("Alright, see you next time.");
        }
    }
}
