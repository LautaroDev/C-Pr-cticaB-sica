using System;

class Program
{
    static void Main()
    {
        int numero;
        Console.WriteLine("Ingrese un numero entero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero != 0)
        {
            if (numero > 0)
            {
                Console.WriteLine("El numero es Positivo");
            } else
            {
                Console.WriteLine("El numero es Negativo");
                
            }
        } else
        {
                Console.WriteLine("El numero es CERO");
            
        }



    }
}