using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0, numeroPar;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                numeroPar = par(n);

                if (numeroPar == 1)
                    con++;
            }

            Console.WriteLine("Se ingresaron " + con + " numeros pares.");
        }
        
        static int par(int a){
                
            int resultado;

            if (a % 2 == 0)
                resultado = 1;
            else
                resultado = 0;
                
            return resultado;
                
        }
        
    }
}
