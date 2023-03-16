using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, porMax = 0, conGrupos = 0, v = 0;
            

            for(int i = 0; i < 5; i++){
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                int conI = 0, conT = 0, nMax = n, por = 0, conDec = 0;

                while(n != 0){
                    conT++;
                    if (n % 2 != 0)
                        conI++;
                    
                    if(n <= nMax)
                        nMax = n;
                    else
                        conDec++; //tambien podria haber sido un bool ya que solo necesito saber si esta en 0 o si paso alguna vez, o sea 1

                    Console.WriteLine("Ingrese un numero: ");
                    n = int.Parse(Console.ReadLine());
                }

                if(conDec == 0)
                    conGrupos++;
                
                por = (conI * 100) / conT;

                if(por > porMax){
                    porMax = por;
                    v = i + 1;
                }
            }

            Console.WriteLine("El grupo " + v + " es el que que tiene mayor porcentaje de numeros impares (" + porMax + "). En " + conGrupos + " se ingresaron numeros de manera decreciente.");
        }
    }
}
