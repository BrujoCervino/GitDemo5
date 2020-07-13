using System;

namespace GitDemo5
{
    class Program
    {
        static void Main()
        {
<<<<<<< HEAD
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello there!");
=======
            Console.WriteLine("Welcome to this Demo!");

            Console.WriteLine(Testing123());
>>>>>>> dev
        }

        static string Testing123() => "I wonder what we'll find here 🙂";
    }
}
