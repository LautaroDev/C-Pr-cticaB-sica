using System;

class Program
{
    static void Main()
    {
        //2. Hacer un programa que solicite el ingreso de 10 números y 
        // que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

        /*  int mayor = 0,numero;

         for (int i = 0; i < 10; i++)
         {
             Console.WriteLine("Ingrese un numero: ");
             numero = int.Parse(Console.ReadLine());

             if (numero >= mayor)
             {
                 mayor = numero;
             }
         }       

         Console.WriteLine("El numero mas grande ingresado es: "+ mayor); */


        int numero, cont= 0,max = 0;
/* 
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                max = numero;
            }
            else if (numero >= max)
            {
                max = numero;
            }

        }
        Console.WriteLine("El numero mas grande ingresado es: " + max);

 */
        //resolverlo con while
        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        while (numero != 0)
        {
            if (cont == 0)
            {
                max = numero;
                cont++;
            }
            else if (numero >= max)
            {
                max = numero;

            }
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("El numero mas grande ingresado es: " + max);


    }
}