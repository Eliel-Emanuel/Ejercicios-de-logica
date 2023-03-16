using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int acu = 0, con = 0, edad;
            float promedio;

            for(int i = 0; i < 20; i++){
                Console.WriteLine("Ingrese una edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18){
                    acu += edad;
                    con++;
                }
                
            }

            promedio = acu / con;

            Console.WriteLine("El promedio de edad de las personas mayores a 18 es de: " + promedio);
        }
    }
}
