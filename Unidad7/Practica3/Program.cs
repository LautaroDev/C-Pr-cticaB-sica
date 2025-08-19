namespace Practica3;

class Program
{
    static void Main(string[] args)
    {
        //variables
        int CantLetras = 0;
        char l, letra1, letra2;
        //caracteres de la palabra
        Console.WriteLine("Ingrese cuantos caracteres tiene su palabra(Contando los espacios): ");
        CantLetras = int.Parse(Console.ReadLine());
        char[] palabra = new char[CantLetras];
        //ingresamos palabra
        for (int i = 0; i < CantLetras; i++)
        {
            Console.WriteLine("Ingrese la palabra caracter por caracter: ");
            l = char.Parse(Console.ReadLine());
            palabra[i] = l;
        }

        //letras que queremos cambiar de la palabra
        Console.WriteLine("Ingrese que letra quiere reemplazar: ");
        letra1 = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese por cual letra desea reemplazar la letra señalada: ");
        letra2 = char.Parse(Console.ReadLine());



        //validación
        for (int i = 0; i < CantLetras; i++)
        {
            if (palabra[i] == letra1)
            {
                palabra[i] = letra2;
            }
        }
        
        Console.WriteLine("La palabra cambiada es: ");
        for (int i = 0; i < CantLetras; i++)
        {
        Console.Write(palabra[i]);
        }
        


        


    }
}
