using System;

public class Class1
{
	public Class1()
	{
        static void Main(string[] args)
        {

            string nombre;

            Console.WriteLine("Ingresar palabra");

            nombre = Console.ReadLine();

            char[] alreves = nombre.ToCharArray();
            Array.Reverse(alreves);

            string alrevesss = new string(alreves);

            if (nombre == alrevesss)
            {
                Console.WriteLine("Es un palindromo");
            }
            else
            {
                Console.WriteLine("No es un palindromo");
            }
            Console.Read();
        }

    }
}
