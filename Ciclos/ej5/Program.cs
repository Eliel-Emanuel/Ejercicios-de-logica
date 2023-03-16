using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0, min = 0;
            bool banPar = false, banImpar = false;

            for(int i = 0; i < 20; i++){
                Console.WriteLine("ingrese un numero");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){
                    if(banPar == false){
                        max = n;
                        banPar = true;
                    }
                    else if(n > max)
                        max = n;
                }else{
                    if(banImpar == false){
                        min = n;
                        banImpar = true;
                    }
                    else if(n < min)
                        min = n;
                }

                
            }

            Console.WriteLine("El mayor numero par ingresado es: " + max + " y el menor numero impar ingresado es: " + min);

        }
    }
}
