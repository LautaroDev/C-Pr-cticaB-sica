namespace Practica1;

class Program
{
    static void Main(string[] args)
    {
        int max = 0, n, posicion = 0;
        int[] numero = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            numero[i] = n;
        }

        max = numero[0];
        posicion = 1;
        for (int i = 0; i < 10; i++)
        {
            if (numero[i] > max)
            {
                max = numero[i];
                posicion = i + 1;

            }
        }

        Console.WriteLine("El numero mas grande es: " + max + " Y se encuentra en la posición: " + posicion);
    }
}
