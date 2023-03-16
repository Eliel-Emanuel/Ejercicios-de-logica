using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, max = 0;

            for(int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if(i == 0)
                    max = n;
                else if(n > max)
                    max = n;
                
            }

            Console.WriteLine("El numero mayor es: " + max);
        }
    }
}
