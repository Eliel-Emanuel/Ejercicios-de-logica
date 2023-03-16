using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paso 0: declarar variable
                //Para declarar una var hay que especificar el tipo de dato: int(enteros), float(con coma), char(letras), bool(verdadero o falso)
            int n1, n2, resultado;
            
            //paso 1: pedir valores
                //Emitir un cartel para pedir num
                Console.WriteLine("Ingrese un numero: ");
                //Leer el num colocado
                n1 = int.Parse(Console.ReadLine());

                //Repetir para pedir el segundo num
                Console.WriteLine("Ingrese otro numero: ");
                n2 = int.Parse(Console.ReadLine());

            //paso 2: realizar calculo
                resultado = n1 + n2;

            //paso 3: imprimir resultado
                Console.WriteLine(n1 + " + " + n2 + " es igual a " + resultado);
        }
    }
}
