using System;

class Program
{
    static void Main()
    {
        


        
        float compra, resultado, descuento;
                    Console.WriteLine("Ingrese el monto de la compra");
                    compra = float.Parse(Console.ReadLine());
                    if (compra >= 5000)
                    {
                        descuento = compra * 0.18F;
                        resultado = compra - descuento;
                        Console.WriteLine("La compra de " + compra + "$ tiene un descuento del: 18%. El total a pagar es: " + resultado  );
                    }
                    else if (compra >= 1000)
                    {
                        descuento = compra * 0.10F;
                        resultado = compra - descuento;
                        Console.WriteLine("La compra de " + compra + "$ tiene un descuento del: 10%. El total a pagar es: " + resultado  );

                    }else{
                        Console.WriteLine("La compra de " + compra + "$ No tiene descuento." );
                    } 


    }
}