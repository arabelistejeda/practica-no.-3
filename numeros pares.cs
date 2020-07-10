using System;
using System.Threading.Tasks.Dataflow;

namespace numeros_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("digite el valor del numero");
            numero = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }

                numero = numero - 1;
            } while (numero > 7 && numero < 23);
            Console.WriteLine("teclle cualquier letra para cerrar el program");
            Console.ReadKey();
        }
    }
        

}
