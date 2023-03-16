using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio, cantidad, resultado;
            
            Console.WriteLine("Ingrese numero: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            cantidad = int.Parse(Console.ReadLine());

            monto = producto(a, b);

            Console.WriteLine("El monto a pagar es: " + monto);
        }

        static int producto(int n1, int n2){
            int r;
            r = n1 * n2;
            return r;
        }   
    }

}
