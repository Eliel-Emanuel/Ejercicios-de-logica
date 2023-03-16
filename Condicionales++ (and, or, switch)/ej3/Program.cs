using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
          
          char op, or, od;
          int p = 0;

          Console.WriteLine("Ingrese la opcion del procesador de la A a la C");
          op = char.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese la opcion de memoria de la A a la C");
          or = char.Parse(Console.ReadLine());
          Console.WriteLine("Si desea agrgar un SSD de 1TB presione A, de lo contrario presine N");
          od = char.Parse(Console.ReadLine());

          switch(op){
            case 'a':
                switch(or){
                    case 'a':
                        p += 800;
                    break;

                    case 'b':
                        p += 900;
                    break;

                    case 'c':
                        p += 1000;
                    break;

                    default:
                        Console.WriteLine("No ingreso una opcion valida");
                    break;
                }
            break;

            case 'b':
                switch(or){
                    case 'a':
                        p += 900;
                    break;

                    case 'b':
                        p += 1000;
                    break;

                    case 'c':
                        p += 1400;
                    break;

                    default:
                       Console.WriteLine("No ingreso una opcion valida");
                    break;
                }
            break;

            case 'c':
                switch(or){
                    case 'a':
                        p += 1200;
                    break;

                    case 'b':
                        p += 1400;
                    break;

                    case 'c':
                        p += 2000;
                    break;

                    default:
                        Console.WriteLine("No ingreso una opcion valida");
                    break;
                }
            break;

          }

          if(od == 'a'){
            p += 300;}
         
          


          Console.WriteLine("Total a pagar: " + p);
          

            
        }
    }
}
