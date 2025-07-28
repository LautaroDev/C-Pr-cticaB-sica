using System;

class Program
{
    static void Main()
    {
        int num1, num2, num3, num4, menor;

        //ingresar numero1 
        Console.WriteLine("Ingrese el primer numero: ");
        num1 = int.Parse(Console.ReadLine());
        //ingresar numero2 
        Console.WriteLine("Ingrese el segundo numero: ");
        num2 = int.Parse(Console.ReadLine());
        //ingresar numero3 
        Console.WriteLine("Ingrese el tercer numero: ");
        num3 = int.Parse(Console.ReadLine());
        //ingresar numero4
        Console.WriteLine("Ingrese el cuarto numero: ");
        num4 = int.Parse(Console.ReadLine());


        //Condicionales para mostrar el menor de todos;
        if (num1 < num2)
        {
            menor = num1;
            
        }
        else
        {
            menor = num2;

        } if (num3 < menor)
        {
            menor = num3;

        }
        if (num4 < menor)
        {
            menor = num4;

        }
            Console.WriteLine("El valor mas chico es: " + menor);


    }
}