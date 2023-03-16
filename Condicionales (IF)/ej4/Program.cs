using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, numeroMenor;

            Console.WriteLine("Ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero: ");
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2)
                numeroMenor = n1;
            else
                numeroMenor = n2;
            
            if(n3 < numeroMenor)
                numeroMenor = n3;
            
            if(n4 < numeroMenor)
                numeroMenor = n4;
            

            Console.WriteLine(numeroMenor + " es el numero menor");
        }
    }
}
