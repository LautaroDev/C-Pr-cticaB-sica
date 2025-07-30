namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
        //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.



        int n, contNumeros, contImpares, grupoImparMax= 0,minimo,contadorOrdenados=0;
        double porcentajeImpares, porcentajeMax = -1;
        bool banderaOrdenados;



        for (int i = 0; i < 5; i++)
        {
            contNumeros = 0;
            contImpares = 0;
            banderaOrdenados = true;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            minimo = n;
            while (n != 0)
            {
                //contar  cuantos numeros tengo.
                contNumeros++;
                if (n % 2 != 0)
                {
                    // contar cuantos impares tengo
                    contImpares++;
                }
                if (n <= minimo)
                {
                    //buscar minimo
                    minimo = n;
                }
                else
                {
                    banderaOrdenados = false;
                }
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }//fin del While
            porcentajeImpares = contImpares * 100 / contNumeros;

            if (porcentajeImpares > porcentajeMax)
            {
                porcentajeMax = porcentajeImpares;
                grupoImparMax = i + 1;
            }
            
            if (banderaOrdenados) 
            {
                contadorOrdenados++;
            }
        }//fin del For

        Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparMax +" , con el porcentaje: " + porcentajeMax);
        Console.WriteLine("La cantidad de grupos con numeros ordeandos es: " +contadorOrdenados );
    }
}
