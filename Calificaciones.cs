using System;

namespace ProblemsAndExamples
{
    class Calificaciones
    {
        public static void Run(){
            //Revisar qué alumnos están reprobados
            //Usamos decimal para cuidar la precisión

            bool alumnoReprobado = false;
            
            //Esteban
            System.Console.WriteLine("Esteban");
            alumnoReprobado = EstaReprobado(5.0M);
            System.Console.WriteLine("Reprobó? " + alumnoReprobado);
            System.Console.WriteLine("\n--------------\n\n");

            //Fabiola
            System.Console.WriteLine("Fabiola");
            alumnoReprobado = EstaReprobado(5.9M);
            System.Console.WriteLine("Reprobó? " + alumnoReprobado);
            System.Console.WriteLine("\n--------------\n\n");

            //Juan
            System.Console.WriteLine("Juan");
            alumnoReprobado = EstaReprobado(5.999999M);
            System.Console.WriteLine("Reprobó? " + alumnoReprobado);
            System.Console.WriteLine("\n--------------\n\n");

            //Beatriz
            System.Console.WriteLine("Beatriz");
            alumnoReprobado = EstaReprobado(8.0M);
            System.Console.WriteLine("Reprobó? " + alumnoReprobado);
            System.Console.WriteLine("\n--------------\n\n");

            //Arturo
            System.Console.WriteLine("Arturo");
            alumnoReprobado = EstaReprobado(10.0M);
            System.Console.WriteLine("Reprobó? " + alumnoReprobado);
            System.Console.WriteLine("\n--------------\n\n");
        }

        public static bool EstaReprobado(decimal calificacion) {
            System.Console.WriteLine("\nRevisando calificación...");

            System.Console.WriteLine("Si la calificación es menor a 6, el alumno está reprobado.");
            if (calificacion < 6M)
                System.Console.WriteLine("Alumno reprobado!");
                return true;

            System.Console.WriteLine("El alumno ha aprobado la materia!");
            return false;
        }
    }
}