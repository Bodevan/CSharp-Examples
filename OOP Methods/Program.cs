using System;

namespace OOP_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;
            
            a = 5;
            b = 3;
            addResult = PerformAddOperation(a, b);
            Console.WriteLine($"{a} + {b} = {addResult}");

            c = 15;
            d = 10;
            addResult = PerformAddOperation(c, d);
            Console.WriteLine($"{c} + {d} = {addResult}");
            DisplayMessage();
        }

        static int PerformAddOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            return addResult;
        }

        static void DisplayMessage()
        {
            Console.WriteLine("Process is done");
            Console.WriteLine("this process is run by Gustavo");
            Console.WriteLine("Finished on : " + DateTime.Now.ToShortTimeString());
        }
    }
}
