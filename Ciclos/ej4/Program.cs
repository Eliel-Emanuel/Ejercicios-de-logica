using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;

            Console.WriteLine("Ingrese su numero: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){
                if(n % i == 0){
                    con ++;
                }
            }
            
            if(con == 2)
                Console.WriteLine(n + " es primo");
            else
                Console.WriteLine(n + " no es primo");
        }
    }
}
