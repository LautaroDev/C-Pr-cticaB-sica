using System;

class Program
{
    static void Main()
    {
        int numero;
        Console.WriteLine("Ingrese un numero entero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero > 10)
            Console.WriteLine("El numero " + numero + " Es mayor a diez");
        else if (numero < 10)
        {
            Console.WriteLine("El numero " + numero + " Es MENOR a diez");            
        }else
        {
            Console.WriteLine("El numero " + numero + " Es Igual a diez");
        }


    }
}