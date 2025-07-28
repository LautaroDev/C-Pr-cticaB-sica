using System;

namespace TuProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bloque If: Condicionales.
            //>, <, >=, <=, ==, !=
            //valor OP Valor
            //n1 > 10 ✅ solo lo que es mayor a 10 va a ser verdadero, es decir de 11 en adelante. 
            //n1 >0 10 ✅  10 va a estar incluido, es decir 10 va a ser verdadero. 
            //10 > 5 ❌. No podemos tener literales en ambos lados de la  condicion.

            int edad = 35;
            /* 
                        if (edad >=  21){ //A esté if no puedo sacarle las llaves por todo el bloque que contiene.
                            if (edad > 30)
                                Console.WriteLine("30 OFF");

                            else
                            Console.WriteLine("21 OFF");

                        }else
                            Console.WriteLine("10 OFF");   */

            if (edad > 30)
            
                Console.WriteLine("30 OFF");
            
            else if (edad > 20) 
                Console.WriteLine("21 OFF");
        
            else 
                Console.WriteLine("10 OFF");
        
            
                
        }
    }
}

