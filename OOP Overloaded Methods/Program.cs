using System;

namespace OOP_Overloaded_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string guestName = "";
            Console.WriteLine("Hello, stranger, what's your name?");
            guestName = Console.ReadLine();

            if (guestName == string.Empty)
                WelcomeGuest();
            else
                WelcomeGuest(guestName);

        }

        static void WelcomeGuest()
        {
            Console.WriteLine("Thank you stranger, enjoy your trip");
        }
        
        static void WelcomeGuest(string name)
        {
            Console.WriteLine($"Thank you {name}, we hope you enjoy staying at our hotel");
        }
    }
}
