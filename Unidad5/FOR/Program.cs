using System;
namespace Unidad5
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //MOSTRAR 5 VECES "HOLA MUNDO" CON UN FOR 
            //Console.WriteLine("Hola Mundo!");

            int nota = 0, promedio, suma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la nota: ");
                nota = int.Parse(Console.ReadLine());
                suma += +nota;
            }
            promedio = suma / 5;
            Console.WriteLine("Promedio: " + promedio);

            

           // for(int i = ; ; )


        }
    }
}