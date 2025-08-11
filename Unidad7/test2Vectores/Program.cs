namespace test2Vectores;

class Program
{
    static void Main(string[] args)
    {
        //vectores con diferentes tipos de datos.               ____________________________________________________
        double[] muestraMatutina = new double[31]; //mañana     |Estos vectores guardan dos datos,                  |
        double[] muestraVespertina = new double[31];//tarde     |el índice guarda el día,                           |
        double[] muestraNocturna = new double[31];//noche       |y el numero que se ingresa guarda la temperatura   |
                                                  //            |___________________________________________________|
                                                  //cruce registro matutino
        Console.WriteLine("Cargue el  registro matutino: ");
        int dia;
        double temperatura, prom;
        for (int i = 0; i < 31; i++)
        {
            Console.WriteLine("Ingrese el día : ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura registrada: ");
            temperatura = double.Parse(Console.ReadLine());

            muestraMatutina[dia - 1] = temperatura;
        }
        //cruce vespertino
        Console.WriteLine("Cargue el  registro vespertino: ");
        for (int i = 0; i < 31; i++)
        {
            Console.WriteLine("Ingrese el día : ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura registrada: ");
            temperatura = double.Parse(Console.ReadLine());

            muestraVespertina[dia - 1] = temperatura;
        }
        //cruce nocturno
        Console.WriteLine("Cargue el  registro nocturno: ");
        for (int i = 0; i < 31; i++)
        {
            Console.WriteLine("Ingrese el día : ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura registrada: ");
            temperatura = double.Parse(Console.ReadLine());

            muestraNocturna[dia - 1] = temperatura;
        }

        // Calcular promedios
        double sumaMatutina = 0, sumaVespertina = 0, sumaNocturna = 0;
        for (int i = 0; i < 31; i++)
        {
            sumaMatutina += muestraMatutina[i];
            sumaVespertina += muestraVespertina[i];
            sumaNocturna += muestraNocturna[i];
        }
        double promMatutina = sumaMatutina / 31;
        double promVespertina = sumaVespertina / 31;
        double promNocturna = sumaNocturna / 31;

        Console.WriteLine("Promedio matutino: "  + promMatutina );
        Console.WriteLine("Promedio vespertino: "  + promVespertina );
        Console.WriteLine("Promedio nocturno: "  + promNocturna );
    }
}
