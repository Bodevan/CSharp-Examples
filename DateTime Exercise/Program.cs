using System;
using System.Globalization;

namespace DateTime_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = new DateTime(2017, 09, 30, 09, 09, 59);
            var culture = new CultureInfo("en-US");

            //First Format
            //30-09-2017 09:09:59
            Console.WriteLine(myDate.ToString("dd-MM-yyyy HH:mm:ss"));

            //Second Format 
            //Saturday of month September year 2017
            Console.WriteLine($"{myDate.DayOfWeek} of month {myDate.ToString("MMMM", culture)}" +
                $" year {myDate.Year}");

            //Third Format 
            //    Day Saturday
            //    Month September
            //    Year 2017
            Console.WriteLine($"Day {myDate.DayOfWeek}");
            Console.WriteLine($"Month {myDate.ToString("MMMM", culture)}");
            Console.WriteLine($"Year {myDate.Year}");
        }
    }
}
