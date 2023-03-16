using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int articulo, cantidad, max = 0, artMax = 0;
            int[] registro = new int[15];

            Console.WriteLine("Ingrese articulo: ");
            articulo = int.Parse(Console.ReadLine());

            while (articulo != 0){
                
                Console.WriteLine("Ingrese cantidad: ");
                cantidad = int.Parse(Console.ReadLine());

                registro[articulo - 1] =+ cantidad;

                Console.WriteLine("Ingrese articulo: ");
                articulo = int.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < 15; i++)
            {
                if(registro[i] > max){
                    max = registro[i];
                    artMax = i + 1;
                }
            }
            Console.WriteLine("El numero de articulos mas vendidos es: " + artMax);
            
            for (int i = 0; i < 15; i++){
                if(registro[i] == 0)
                    Console.WriteLine("El articulo " + (i + 1) + " no registra ventas");
            }
            
    
            Console.WriteLine("El articulo 10 registro " + registro[9] + " Ventas");
            
        }
    }
}
