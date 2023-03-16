using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vNum = new int[10];

            for(int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                vNum[i] = n;
            }

            int acu = 0;
            double prom;

            for (int i = 0; i < 10; i++){
                acu += vNum[i];
            }

            prom = acu / 10;

            Console.WriteLine("El promedio es: " + prom);

            for (int i = 0; i < 10; i++){
                if(vNum[i] > prom)
                    Console.WriteLine(vNum[i] + " es mayor al promedio");
            }

            Console.WriteLine("Fin del programa");
        }
    }
}
