using System;

namespace String_Manipulation_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShow = "Game of Thrones    ";
            string seasonOne = " - Season 1";
            string newName = "";

            tvShow = tvShow.Trim();
            newName = tvShow.Insert(tvShow.Length, seasonOne);
            Console.WriteLine(newName);
            // Add " - Season 1"
            // without you determining the start index.

        }
    }
}
