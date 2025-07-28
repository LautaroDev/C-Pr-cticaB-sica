

using System;

class Program
{
    static void Main()
    {
        int resultado, num1, num2;

        Console.WriteLine("Ingrese el primer numero");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            resultado = num1 - num2;
        }
        else if (num1 < num2)
        {
            resultado = num1 * num2;
        }
        else
        {
            resultado = num1 + num2;

        }
        Console.WriteLine("El resultado es: " + resultado);
        

    }
}