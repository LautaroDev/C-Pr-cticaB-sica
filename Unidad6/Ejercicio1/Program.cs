namespace CorteDeControl;

class Program
{
    static void Main(string[] args)
    {
        /* 1. Hacer un programa para ingresar 10 números.
         El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos. */

        int contadorPrimos = 0;
        for (int i = 0; i < 10; i++)
        {
            int numero, contador = 0;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            for (int x = 1; x <= numero; x++)
            {
                if (numero % x == 0)
                {
                    contador++;
                }
            }
            if (contador == 2 )
            {
                contadorPrimos++;
            }
        }

        Console.WriteLine("La cantidad de numeros primos que hay son: " + contadorPrimos);
        

    }
}
