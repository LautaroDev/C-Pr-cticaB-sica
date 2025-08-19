namespace CadenaCaracteres;

class Program
{
    static void Main(string[] args)
    {
        //Cadena de caracteres
        /*         char[] nombre = new char[10];
                char letra;
                int indice = 0;

                Console.WriteLine("Ingrese su nombre letra por letra... (Terminar con un punto)");
                letra = char.Parse(Console.ReadLine());
                while (letra != '.' && indice < 10)
                {
                    nombre[indice] = letra;
                    letra = char.Parse(Console.ReadLine());
                    indice++;

                }
                nombre[indice] = '\0';

                Console.Write("Hola ");
                indice = 0;
                while (nombre[indice] != '\0')
                {
                    Console.Write(nombre[indice]);
                    indice++;

                }
         */

        string nombre;
        Console.WriteLine("Ingrese su nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Hola " + nombre);
        Console.WriteLine("Hola " + nombre[0]);



        

        /*         for (int i = 0; i <= letra[i]; i++)
                                        {
                                        Console.WriteLine(letra[i]);
                                        } */

        //cargar un nombre con char




        //string
        //cadena de caracteres
        //vector de char 
    }
}
