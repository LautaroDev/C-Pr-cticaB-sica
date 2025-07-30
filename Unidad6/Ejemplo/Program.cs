namespace Ejemplo;

class Program
{
    static void Main(string[] args)
    {
        
        int n, prom;

        Console.WriteLine("Ingrese 1 para comenzar a procesar o 0 para terminar: ");
        n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
            int acum = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese la edad : ");
                n = int.Parse(Console.ReadLine());
                acum += n;
            }
            prom = acum / 20;
            Console.WriteLine("El promedio es: " + prom);
            
        Console.WriteLine("Ingrese 1 para comenzar a procesar o 0 para terminar: ");
        n = int.Parse(Console.ReadLine());
        }
        
    }
}
