using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, vp, resultado;

                Console.WriteLine("ingrese los kilometros:");
                km = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese velocidad promedio:");
                vp = int.Parse(Console.ReadLine());

                    resultado = km/vp;

                        Console.WriteLine("El tiempo promedio que tardara es de " + resultado + " horas.");
        
        }
    }
}
