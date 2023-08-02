using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num;

            //num = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine("Los numeros del 1 al 100 son: "+ i);
            //}

            //int contador;

            //contador = 1;

            //while (contador <= 100)
            //{
            //    Console.WriteLine("Los numeros son: " + contador);

            //    contador++;
            //}

            //do
            //{
            //    Console.WriteLine("Los numeros son " + contador);
            //    contador++;

            //} while (contador <= 100);

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i%7==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //while (contador <= 100)
            //{
            //    if (contador%2==0)
            //    {
            //        Console.WriteLine(contador);
            //    }

            //    contador++;
            //}

            int opcion;
            bool recorrer;
            opcion = 0;
            recorrer = true;

            while (recorrer)
            {

                Console.WriteLine();
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Producto");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Salir");
                Console.WriteLine();
                Console.Write("Ingrese una opción (1 - 5): ");
                opcion = Int32.Parse(Console.ReadLine());

                Console.Clear();
                Console.Beep();
                Console.WriteLine();
                
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Suma");
                    break;
                case 2:
                    Console.WriteLine("Resta");
                    break;
                case 3:
                    Console.WriteLine("Producto");
                    break;
                case 4:
                    Console.WriteLine("Division");
                    break;
                case 5:
                default:
                    recorrer = false;
                        Console.WriteLine("Hasta luego");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
