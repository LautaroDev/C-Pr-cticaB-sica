﻿using System;

class Program
{
    static void Main()
    {
        //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. 
        //  Nota: un número es primo cuando es divisible únicamente por 1 y por sí mismo.


        int numero, contador= 0;
        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0 ) //acá a va a iterar por 1 y por su mismo numero, es decir que para ser primo el contador tiene que terminar en 2 
            {
                contador++;
            }
        }

        if (contador == 2 )
        {
            Console.WriteLine("El numero ingresado es primo");
        }else
        {
            Console.WriteLine("El numero ingresado NO es primo");
            
        }
    }
}


