using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digitar los numeros: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int primeraentrada = 0;
            int segundaentrada = 1;
            int tolavaina;

            Console.WriteLine("Fibonacci: ");

            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                    tolavaina = i;
                else
                {
                    tolavaina = primeraentrada + segundaentrada;
                    primeraentrada = segundaentrada;
                    segundaentrada = tolavaina;
                }

                Console.WriteLine(tolavaina);
            }

            Console.ReadLine();
        }
    }
}


    



