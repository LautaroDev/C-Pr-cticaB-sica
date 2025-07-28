using System;

class Program
{
    static void Main()
    {
        //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.           

        int edad, acum = 0, cont = 0, prom;

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad > 18)
            {
                acum += edad;
                cont++;
            }

        }
        prom = acum / cont;
        Console.WriteLine("El promedio de las personas que son mayores a 18 años es: " + prom);


    }
}


