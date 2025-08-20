namespace Practica4;

class Program
{
    static void Main(string[] args)
    {
        //variables
        int numeroArt, max = 0, cantVend = 0;

        int[] VArticulos = new int[15];

        //Ingresar el numero del articulo (0 para terminar)
        Console.WriteLine("Ingresar numero de articulo (de 1 a 15) 0 para terminar : ");
        numeroArt = int.Parse(Console.ReadLine());
        while (numeroArt != 0)
        {
            numeroArt = numeroArt - 1; 
            if (numeroArt < 0 || numeroArt > 15)
            {
                Console.WriteLine("Numero de articulo invalido. Debe ser de 1 a 15. ");
            }
            else
            {
                //Ingresar la cantidad vendida
                Console.WriteLine("Ingresar la cantidad que se vendio: ");
                cantVend = int.Parse(Console.ReadLine());
                //si el vector tiene un 0, que acumule la cantidad vendida
                if (VArticulos[numeroArt ] == 0) // 
                {
                    VArticulos[numeroArt ] = cantVend;
                }
                else
                {
                    VArticulos[numeroArt ] = VArticulos[numeroArt ] + cantVend;
                }

                //VArticulos[numeroArt-1] ;
            }
            //Ingresar el numero del articulo (0 para terminar)
            Console.WriteLine("Ingresar numero de articulo: ");
            numeroArt = int.Parse(Console.ReadLine());
            //Ingresar la cantidad vendida
            /*  Console.WriteLine("Ingresar la cantidad que se vendio: ");
                cantVend = int.Parse(Console.ReadLine()); */


        }
        

        Console.WriteLine(VArticulos[0]);
        Console.WriteLine(VArticulos[1]);
        Console.WriteLine(VArticulos[2]);
            
        
    }
}
