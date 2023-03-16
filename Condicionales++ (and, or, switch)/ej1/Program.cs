using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, r;

            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
                r = n1 - n2;
            else if(n1 < n2)
                r = n1 * n2;
            else
                r = n1 + n2;
            

            Console.WriteLine(r);
        }
    }
}
