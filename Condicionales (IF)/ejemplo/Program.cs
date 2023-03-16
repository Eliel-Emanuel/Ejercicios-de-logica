using System;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            if(n > 10)
                Console.WriteLine(n + " es mayor a 10");
            else
                Console.WriteLine(n + " no es mayor a 10");
            
        }
    }
}
