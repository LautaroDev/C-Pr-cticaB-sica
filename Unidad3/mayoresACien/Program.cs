using System;

class Program
{
    static void Main()
    {
        int n1, n2, n3, n4, acum = 0;

        //n1
        Console.WriteLine("Ingrese un numero");
        n1 = int.Parse(Console.ReadLine());
         
        //n2
        Console.WriteLine("Ingrese otro numero");
        n2 = int.Parse(Console.ReadLine());
         

        //n3
        Console.WriteLine("Ingrese otro numero");
        n3 = int.Parse(Console.ReadLine());
         

        //n4
        Console.WriteLine("Ingrese otro numero");
        n4 = int.Parse(Console.ReadLine());
         



        //Condicionales, mostrar mayores a 100 
        if (n1 > 100)
        {
            acum+=n1 ;
            Console.WriteLine("el numero: " + n1 + " Es mayor a cien" + acum);
        }
        if (n2 > 100)
        {
            acum+=n2 ;
            Console.WriteLine("el numero: " + n2 + " Es mayor a cien" + acum);
        }
        if (n3 > 100)
        {
            acum+=n3 ;
            Console.WriteLine("el numero: " + n3 + " Es mayor a cien" + acum);
        }
        if (n4 > 100)
        {
            acum+=n4 ;
            Console.WriteLine("el numero: " + n4 + " Es mayor a cien" + acum);
        }
        

    }
}