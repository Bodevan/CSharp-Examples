using System;

namespace Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Just forcing myself to type so i don't forget things for lack of practice. 
             int h = 1;
             int i = 1;
             int j = 1;
             while (h <= 10) {
                 Console.WriteLine("In a while loop");
                 h++;
             }
             for (i = 1; i <= 10; i++)
             {
                 Console.WriteLine("In a for loop");
             }
             do
             {
                 Console.WriteLine("In a while loop");
                 j++;
             } while (j <= 10);
             */

            int j = 1;

            while (j <= 10) 
            { 
                for (int i = 1; i <= j; i++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine("");
                j++;
            }
            

        }
    }
}
