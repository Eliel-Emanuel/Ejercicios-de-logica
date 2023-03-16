using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, promedio;

            Console.WriteLine("ingrese la primera nota: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la segunda nota: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la tercera nota: ");
            n3 = float.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            Console.WriteLine("El promedio es de: " + promedio);
        }
    }
}
