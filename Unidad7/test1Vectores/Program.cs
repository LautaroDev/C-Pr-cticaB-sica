namespace test1Vectores;

class Program
{
    static void Main(string[] args)
    {
        int n,acu=0;
        //vectores (array o arreglo) 
        int[] numeros = new int[10];

        //cargar 10 numeros
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingresar un numero:");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // mostrar los valores que agregamos 
        for (int i = 0; i < 10; i++) //como el ciclo for anterior ya termino, puedo volver a usar la variable i
        {
            Console.WriteLine("Los numeros que tiene el vector son: " + numeros[i]);
        }
        //sumar todos los valores que ingresamo
        for (int i = 0; i < 10; i++)
        {
            acu += numeros[i];
        }
            Console.WriteLine("La suma de todos los numeros es : " + acu);
        

        
    }
}
