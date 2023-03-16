using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con, p = 0;

            for(int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                con = 0;

                for(int x = 1; x <= n; x++){
                    if (n % x == 0)
                        con++;                    
                }

                if(con == 2)
                    p++;                
            }

            Console.WriteLine("Se ingresaron " + p + " numeros primos.");
        }
    }
}
