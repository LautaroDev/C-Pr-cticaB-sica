
/* 
5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.
*/

using System;
namespace primer_programa
{
    class Program
    {
        static void Main(String[] args)
        {
            //variables
            int nota1, nota2, nota3, promedio;

            //ingresar notas
            Console.WriteLine("Ingrese la primer nota: ");
            nota1 = int.Parse(Console.ReadLine());
            //ingresar notas2
            Console.WriteLine("Ingrese la primer nota2: ");
            nota2 = int.Parse(Console.ReadLine());
            //ingresar notas
            Console.WriteLine("Ingrese la primer nota3: ");
            nota3 = int.Parse(Console.ReadLine());

            //operacion
            promedio = (nota1 + nota2 + nota3) / 3;

            //mostrar
            Console.WriteLine("El promedio es: " + promedio);


        }
    }
}
