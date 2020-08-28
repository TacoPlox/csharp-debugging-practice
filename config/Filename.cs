using System;

namespace Errors
{
    class Filename
    {
        public static void Run() {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("fizz");
                } else if (i % 3 == 0) {
                    System.Console.WriteLine("buzz");
                } else if (i % 5 == 0) {
                    System.Console.WriteLine("fizzbuzz");
                } else {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}