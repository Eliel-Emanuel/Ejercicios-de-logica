using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Ingrese el primer num: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo num: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer num: ");
            c = int.Parse(Console.ReadLine());

            if((a + b) > (b * c)){
                Console.WriteLine("La suma del primer numero con el segundo es mayor al producto del segundo por el tercero");
            }else{
                Console.WriteLine("La suma del primer numero con el segundo no es mayor al producto del segundo por el tercero");

            }
        }
    }
}
