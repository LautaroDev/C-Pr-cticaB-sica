
/* 
4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000
 más una comisión del 5% sobre el total facturado por cada empleado.
 Hacer un programa para ingresar el total facturado por un empleado y 
 que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.


*/

using System;
namespace primer_programa
{
    class Program
    {
        static void Main(String[] args)
        {
            //variables
            float TotalFacturado,sueldoFinal,comision;
            const float porcenajeComision = 0.05F; //variable constante
            const float sueldoFijo = 15000;

            //calcular la comision que se le da por lo facturado
            Console.WriteLine("Ingrese la facturación del mes del empleado: ");
            TotalFacturado = float.Parse(Console.ReadLine());
            comision = TotalFacturado * porcenajeComision;

            //calcular el total
            sueldoFinal = sueldoFijo + comision;

            //mostrar total
            Console.WriteLine("El sueldo del  empleado es de : " + sueldoFinal + " $");

        }
    }
}
