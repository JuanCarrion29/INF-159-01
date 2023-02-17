using System;

public class Class1
{
	public Class1()
	{
        string nombre;

        Console.WriteLine("Ingresar palabra");

        nombre = Console.ReadLine();

        char[] alreves = nombre.ToCharArray();
        Array.Reverse(alreves);

        string alrevesss = new string(alreves);

        Console.WriteLine(alrevesss);
        Console.Readline();


    }
}
