namespace Practica4;

class Program
{
    static void Main(string[] args)
    {
        //variables
        int numeroArt, max = 0, cantVend = 0, pos = 0;

        int[] VArticulos = new int[15];

        //Ingresar el numero del articulo (0 para terminar)
        Console.WriteLine("Ingresar numero de articulo (de 1 a 15) 0 para terminar : ");
        numeroArt = int.Parse(Console.ReadLine());
           if (numeroArt < 0 || numeroArt > 15)
            {
                Console.WriteLine("Numero de articulo invalido. Debe ser de 1 a 15. ");
            }
        while (numeroArt != 0)
        { 
             numeroArt = numeroArt - 1  ;
            //Ingresar la cantidad vendida
            Console.WriteLine("Ingresar la cantidad que se vendio: ");
            cantVend = int.Parse(Console.ReadLine());
            //Que acumule la cantidad vendida
            VArticulos[numeroArt] += cantVend;


          
            //Ingresar el numero del articulo (0 para terminar)
            Console.WriteLine("Ingresar numero de articulo: ");
            numeroArt = int.Parse(Console.ReadLine());
        }



        //a) El número de artículo que más se vendió en total.
        max = VArticulos[0];
        for (int i = 0; i < 15; i++)
        {
            if (VArticulos[i] > max)
            {
                max = VArticulos[i];
                pos = i;
            }
        }
        Console.WriteLine("El articulo que más ventas tiene registrada es el articulo: " + (pos + 1)  + " Y tiene registrada: " + max + " de ventas");
        //b) Los números de artículos que no registraron ventas.
        Console.WriteLine("Los articulos que no tienen ventas registradas son: ");
        for (int i = 0; i < 15; i++)
        {
            if (VArticulos[i] == 0)
            {
                Console.WriteLine("Articulo: " + (i+1));
            }
        }
        //c) Cuantas unidades se vendieron del número de artículo 10.
        Console.WriteLine("El articulo  10 tiene registrada: : " + VArticulos[9] + " ventas ");



            
        
    }
}
