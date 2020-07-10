using System;

namespace mayor_de_un_numero
{
	class Program
	{
		static void Main(string[] args)
		{
 
 
                {
                    int a, b, mayor;

                    Console.Write("Escriba un número: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Escriba otro: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    mayor = a > b ? a : b;

                    Console.WriteLine("El mayor de los números es {0}.", mayor);
                }
            }

        }
    }


