using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //0: Declarar variables
                int n, resultado;

            //1: Pedir valores y guardarlos
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            //2: Procesar info
                resultado = n*n*n;

            //3: Mostrar en pantalla
            Console.WriteLine(n + " elevado al cubo es igual a " + resultado);
        }
    }
}
