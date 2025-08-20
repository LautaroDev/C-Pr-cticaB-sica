namespace test3Vectores;

class Program
{
    static void Main(string[] args)
    {

        //Asistencias
        bool[] asistenciasQuincena = new bool[15];
        int dia;
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("Ingrese el día: ");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("En el dia " + dia + " Asistio a clases: si o no ");
            asistenciasQuincena[dia] = bool.Parse(Console.ReadLine());
        }
            

    }
}
