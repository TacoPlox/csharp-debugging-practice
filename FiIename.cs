using System;

namespace ProblemsAndExamples
{
    class FiIename
    {
        public static void Run(){
            //Fizzbuzz !
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("fizzbuzz");
                } else if (i % 3 == 0) {
                    System.Console.WriteLine("fizz");
                } else if (i % 5 == 0) {
                    System.Console.WriteLine("buzz");
                } else {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}