using System;

namespace Upside_Down_Triangle_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 16;
            while (i >= 0)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine("");
                i--;
            }
        }
    }
}
