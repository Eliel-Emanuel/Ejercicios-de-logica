using System;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 0, promedio;

            for(int i = 0; i < 5; i++){
                Console.WriteLine("Ingrese una nota");
                n = int.Parse(Console.ReadLine());
                n += n;
            }

            promedio = n / 5;

            Console.WriteLine(promedio);
        }
    }
}

