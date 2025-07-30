namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
        //  El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.


        int numero = 1, cont = 0;

        while (numero >= 0)
        {
            numero = int.Parse(Console.ReadLine());

            while (numero > 0)
            {
                cont++;
                numero = int.Parse(Console.ReadLine());

            }

        }

        Console.WriteLine("La cantidad de numeros es: " + cont);
    }
}
