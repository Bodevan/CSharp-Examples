using System;

namespace Time_Machine_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            
            Console.WriteLine("Enter the day");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Month");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Year");
            year = int.Parse(Console.ReadLine());

            DateTime myDate = new DateTime(year, month, day);

            Console.WriteLine($"This day should be {myDate.DayOfWeek}");
            
        }
    }
}
