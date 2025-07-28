using System;

namespace WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Código aquí
            int sueldo, contador = 0;

            Console.WriteLine("Ingrese un numero: ");
            sueldo = int.Parse(Console.ReadLine());
            while (sueldo != 0)
            {
                Console.WriteLine("Ingrese un numero: ");
                sueldo = int.Parse(Console.ReadLine());
                contador++;
            }
                Console.WriteLine("Ingresaste " +contador +" numeros");
        }
    }
}