using System;

namespace primer_programa
{
    class Program
    {
        static void Main(String[] args)
        {
            int numero1, numero2, resultado;

            Console.WriteLine("Ingrese un numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            numero2 = int.Parse(Console.ReadLine());

            resultado = numero1 + numero2;

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
