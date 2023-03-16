using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalFacturado, sueldoTotal, comision = 0.05f;
            
            Console.WriteLine("Ingrese el monto total facturado: ");
            totalFacturado = float.Parse(Console.ReadLine());

            sueldoTotal = totalFacturado * comision + 15000;

            Console.WriteLine("Tu sueldo total es de " + sueldoTotal);
        }
    }
}
