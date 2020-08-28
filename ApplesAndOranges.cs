using System;

namespace ProblemsAndExamples{class ApplesAndOranges{public static void Run()
{
            //John tiene 35 frutas en su casa.
            //5 manzanas en cada mesa
            //30 naranjas en un saco
            //La mitad de las naranjas del saco están echadas a perder
            //Hay 4 mesas en total

            //John está aprendiendo a programar, pero
            // el cálculo no es correcto
            
            //John te ha pedido ayuda para encontrar el error
            // en este archivo
            // y también dijo que apenas está aprendiendo, así que
            // se disculpó en adelantado

            int apples = 
            0;

            int oranges = 
            0;

            int totalFruits = 
            0;

            apples += 5;

            oranges = 
            oranges + 30;

            oranges /= 2;

            apples *= 4;

            totalFruits += 
            (
                apples 
            + 7
                    ) + 
                    oranges;

            System.Console.WriteLine("Total Fruits: " + totalFruits);
            
            if (
                        totalFruits != 35
                )
            {System.Console.WriteLine("John todavía necesita tu ayuda");}}}}