
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce el número de calificaciones: ");
        int numberos = int.Parse(Console.ReadLine());

        int total = 0;
        for (int i = 0; i < numberos; i++)
        {
            Console.WriteLine("Introduce la calificación " + (i + 1) + ": ");
            int grado = int.Parse(Console.ReadLine());
            total += grado;
        }

        int pp = total / numberos;

        if (pp >= 90)
        {
            Console.WriteLine("El literal correspondiente es A");
        }
        else if (pp >= 80)
        {
            Console.WriteLine("El literal correspondiente es B");
        }
        else if (pp >= 70)
        {
            Console.WriteLine("El literal correspondiente es C");
        }
        else if (pp >= 60)
        {
            Console.WriteLine("El literal correspondiente es D");
        }
        else
        {
            Console.WriteLine("El literal correspondiente es F");
        }

        Console.ReadLine();
    }
}
