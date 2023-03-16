using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe, importeFinal, descuentoX10 = 0.90f, descuentoX18 = 0.82f;

            Console.WriteLine("Ingrese el importe: ");
            importe = float.Parse(Console.ReadLine());

            if(importe >= 5000){
                importeFinal = importe * descuentoX18;
                Console.WriteLine("Total a abonar: ARS" + importeFinal);
            }else if(importe >= 1000){
                importeFinal = importe * descuentoX10;
                Console.WriteLine("Total a abonar: ARS" + importeFinal);
            }else
                Console.WriteLine("No hay descuento");
            

            
        }
    }
}
