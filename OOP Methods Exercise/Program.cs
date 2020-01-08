using System;

namespace OOP_Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! can you tell me your name?");
            welcome(GetUsername());

        }
        static string GetUsername()
        {
            string user;
            user = Console.ReadLine();
            return user;
        }
        static void welcome(string user) {
            Console.WriteLine($"Welcome {user}! Nice to meet you!");
        }
    }
}
