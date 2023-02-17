using System;

public class Class1
{

	

	public Class1()
	{
        static void Main(string[] args)
        {

            var rand = new Random();

            int[]listaRandom = new int[50]


               for (int i = 0; i < 50; i++)
               {

                listaRandom[i] = rand.Next(1,60);   


               }




            for (int i = 0; i < listaRandom.Length - 1; i++)
            {
                for (int j = 0; j < listaRandom.Length - i - 1; j++)
                {
                    if (listaRandom.Length[j] > listaRandom.Length[j + 1])
                    {
                        temp = listaRandom.Length[j];
                        listaRandom.Length[j] = listaRandom.Length[j + 1];
                        listaRandom.Length[j + 1] = temp;
                    }
                }
            }



            for (int i = 0; i < listaRandom.Length - 1; i++)
            {
                for (int j = 0; j < listaRandom.Length - i - 1; j++)
                {
                    if (listaRandom[j] < arr[j + 1])
                    {
                        temp = listaRandom [j];
                        listaRandom[j] = listaRandom[j + 1];
                        listaRandom[j + 1] = temp;
                    }
                }
            }



        }


    }
}
