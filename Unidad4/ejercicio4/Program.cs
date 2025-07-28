/* using System;

class Program
{
    static void Main()
    {
        int a, b, c, mayor;

        Console.WriteLine("ingrese un nro: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese un nro: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese un nro: ");
        c = int.Parse(Console.ReadLine());

        mayor = a + b;

        if (mayor < (b * c))
        {
            mayor = b * c;
        }
        else if (mayor == (b * c))
        {
            Console.WriteLine("SON IGUALES  ");
        }

        Console.WriteLine(mayor);
        


    }
} */


using System;

class Program
{
    static void Main()
    {
        int a, b, c;

        Console.Write("Ingrese el primer número: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        c = int.Parse(Console.ReadLine());

        int suma = a + b;
        int producto = b * c;

        if (suma > producto)
        {
            Console.WriteLine("La suma de los dos primeros números es MAYOR que el producto del segundo con el tercero.");
        }
        else
        {
            Console.WriteLine("La suma de los dos primeros números NO es mayor que el producto del segundo con el tercero.");
        }
    }
}
