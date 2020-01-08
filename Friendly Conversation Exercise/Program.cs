using System;

namespace Friendly_Conversation_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            string age;
            DateTime myDate = DateTime.Now; 

            Console.WriteLine("What is your Name?");
            name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {name}, my name is C#. How old are you?");
            age = Console.ReadLine();
            
            if (int.TryParse(age, out int number))
            {
                Console.WriteLine($"{age}, good. As for me i was born in 2002 which makes me: { myDate.Year - 2002} years old");
            }
            else
                Console.WriteLine($"that's not your age dumbdumb. Come on try it again OwO");
                


           

        }
    }
}