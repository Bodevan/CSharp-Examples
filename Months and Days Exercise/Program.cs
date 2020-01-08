using System;

namespace Months_and_Days_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            String[] Months = { "January - 31 Days",
                                "Febuary - 28 Days (29 in leap years)",
                                "March - 31 Days",
                                "April - 30 Days",
                                "May - 31 Days",
                                "June - 30 Days",
                                "July - 31 Days",
                                "August - 31 Days",
                                "September - 30 Days",
                                "October - 31 Days",
                                "November = 30 Days",
                                "December - 31 Days"
                               };
            for (int i = 0; i <=12; i++)
            {
                Console.WriteLine(Months[rand.Next(0, 12)]);

            }

        }
    }
}
