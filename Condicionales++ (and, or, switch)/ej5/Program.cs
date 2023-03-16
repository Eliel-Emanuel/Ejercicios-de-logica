using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Ingrese el primer num: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo num: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer num: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto num: ");
            d = int.Parse(Console.ReadLine());

            if(a > b && b > c && c > d){
                Console.WriteLine("Estan ordenados de manera decreciente");
            }else{
                Console.WriteLine("No estan ordenados de manera decreciente");
            }
        }
    }
}
