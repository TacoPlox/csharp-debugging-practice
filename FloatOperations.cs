using System;

namespace ProblemsAndExamples
{
    class FloatOperations
    {
        public static void Run() {
            decimal a = 1.345M;
            decimal b = 1.123M;

            //Debería dar 2.468 como resultado
            decimal c = a + b;
            System.Console.WriteLine("Sospechoso: c");
            System.Console.WriteLine(c);

            decimal d = c * 2M;
            System.Console.WriteLine("Sospechoso: d");
            System.Console.WriteLine(d);


            decimal e = d / 0.42M;

            System.Console.WriteLine(e);
        }
    }
}