using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Ingrese el numero: ");
            n = int.Parse(Console.ReadLine());

            if(n == 0)
                Console.WriteLine("El numero es " + n);
            else if(n > 0)
                Console.WriteLine(n + " es positivo");
            else
                Console.WriteLine(n + " es negativo");
            
        }
    }
}
