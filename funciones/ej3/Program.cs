using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, promedio, contador = 0, acumulador = 0;

            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());

            while (a != 0){

                if(primo(a)){
                   acumulador += a;
                   contador++; 
                }
                
                Console.WriteLine("Ingrese otro numero: ");
                a = int.Parse(Console.ReadLine());
                
            }

            promedio = acumulador / contador;

            Console.WriteLine("El promedio de los numero primos es: " + promedio);
        }

        static bool primo (int n){
            int con = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    con++;
            }

            if(con == 2)
                return true;
            else
                return false;        
        }
    }
}
