using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while(n > 0){

                int con = 0;
                
                while(n != 0){
                    con++;
                    Console.WriteLine("Ingrese otro numero: ");
                    n = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Se ingresaron " + con + " numeros.");

                Console.WriteLine("Ingrese otro numero: ");
                n = int.Parse(Console.ReadLine());


            }
        }
    }
}
