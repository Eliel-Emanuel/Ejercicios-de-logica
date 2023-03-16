using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vNum = new int [10];

            for (int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                vNum[i] = n;
            }

            int max = 0, p = 0;

            for(int i = 0; i < 10; i++){
                if (vNum[i] > max){
                    max = vNum[i];
                    p = i + 1;
                }
            }

            Console.WriteLine("El valor maximo es " + max + ", y fue ingresado en la posicion " + p);
        }
    }
}
