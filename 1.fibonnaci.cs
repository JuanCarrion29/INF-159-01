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

            Console.WriteLine("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int firstTerm = 0;
            int secondTerm = 1;
            int nextTerm;

            Console.WriteLine("Fibonacci series: ");

            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                    nextTerm = i;
                else
                {
                    nextTerm = firstTerm + secondTerm;
                    firstTerm = secondTerm;
                    secondTerm = nextTerm;
                }

                Console.WriteLine(nextTerm);
            }

            Console.ReadLine();
        }
    }
}


    



