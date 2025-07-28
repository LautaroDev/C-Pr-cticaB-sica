

using System;

class Program
{
    static void Main()
    {
        float litros, descuento, precioFinal, precioLitro, resultado;
        //cantidad de litros
        Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
        litros = float.Parse(Console.ReadLine());
        //precio x  litro
        Console.WriteLine("Ingrese el precio del litro: ");
        precioLitro = float.Parse(Console.ReadLine());
        //Precio de litro por litros
        precioFinal = litros * precioLitro;

        //calcular descuento
        if (litros <= 100)
        {
            descuento = precioFinal * 0;
        }
        else if (litros >= 101 && litros <= 300)
        {
            descuento = precioFinal * 0.10F;
        }
        else if (litros >= 301 && litros <= 500)
        {
            descuento = precioFinal * 0.15F;

        }
        else
        {
            descuento = precioFinal * 0.25F;

        }

        resultado = precioFinal - descuento;
        Console.WriteLine("El precio es de: " + precioFinal + " debido a está cantidad de litros tiene: " + descuento + "$ de descuento, El monto final de la compra es de: " + resultado);
        
        
        


    }
}