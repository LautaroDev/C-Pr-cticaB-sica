using System;

namespace TuProyecto
{
    class Program
    {
        static void Main(string[] args)
        {

        //2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.


            //variables:
            int numero;
            int resultado;

            Console.WriteLine("Ingrese un numero que quiera elevar al cubo: ");
            numero = int.Parse(Console.ReadLine());

            //operacion
            resultado = numero * numero * numero;
            //podría reasignar numero directamente para no tener la variable
            //numero = numero * numero * numero;
            //mostrar resultado
            Console.WriteLine(resultado);
        }
    }
}
