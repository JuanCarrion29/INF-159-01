using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("factorial:");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = CalculateFactorial(number);
            Console.WriteLine("el factorial de " + number + " es: " + factorial);
            Console.ReadKey();
        }

        static int CalculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactorial(number - 1);
            }
        }
    }
}
