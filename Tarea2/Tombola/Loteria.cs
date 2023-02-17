using System;

public class Class1
{
	public Class1()
	{

        Random rnd = new Random();

        int[] raa = new int[50];

        int contador = 0;
        rnd.Next(0, 100);

        for (int i = 0; i < raa.Length; i++)
        {

            rnd = i; valor[i] = i;
            if (i == 1)
            {
                contador++;
            }
        }

        var numerosss = raa.Take(3);

        foreach (var valor in numerosss)
        {
            Console.WriteLine(valor);
        }

    }
}
