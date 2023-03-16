using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
           float litros, importeFinal;

           Console.WriteLine("ingrese el importe de la venta: ");
           importeFinal = float.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
           litros = float.Parse(Console.ReadLine());

           if(litros > 500)
            importeFinal *= 0.75f;
           else if(litros > 300 && litros <= 500)
            importeFinal *= 0.85f;
           else if(litros > 100 && litros <= 300)
            importeFinal *= 0.90f;
           

           Console.WriteLine("Total a pagar: $" + importeFinal);

        }
    }
}
