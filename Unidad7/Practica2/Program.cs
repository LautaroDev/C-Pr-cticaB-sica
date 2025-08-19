namespace Practica2;

class Program
{
    static void Main(string[] args)
    {
        //variables
        int prom, n, acum = 0, cont = 0;
        //vector
        int[] Vnumero = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            Vnumero[i] = n;
            acum += Vnumero[i];
            cont++;
        }

        prom = acum / cont;
        Console.WriteLine("El Promedio es de : " + prom);
        Console.Write("Numeros mas grandes que el promedio: ");

        //cuales numeros son mas grandes que el promedio
        for (int i = 0; i < 10; i++)
        {
            if (Vnumero[i] > prom)
            {

                //Console.WriteLine("El Promedio es de : " + prom);
                //Console.WriteLine("El numero: " + Vnumero[i] + " Es mas grande que el promedio");
                Console.Write(  " "+Vnumero[i]+"  ");
            }
        }


    }
}
