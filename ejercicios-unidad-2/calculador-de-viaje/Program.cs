// See https://aka.ms/new-console-template for more information

/* 
3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo.
 Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
 */

using System;
namespace primer_programa
{
    class Program
    {
        static void Main(String[] args)
        {
            //variables
            float kilometros, destino, velocidad;
            //entrada de datos
            Console.WriteLine("Ingrese cuantos kilometros tiene de viaje: ");
            kilometros = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la  velocidad a la que va : ");
            velocidad = int.Parse(Console.ReadLine());

            //calculo
            destino = kilometros / velocidad;

            Console.WriteLine("Su destino está a: " + destino.ToString("0.00") + " Horas");

            //destino.ToString("0.00") ajusta el dato destino a los decimales expresados.
        }
    }
}
