using System;

public class Class1
{
	public Class1()
	{
        static void Main(string[] args)
        {


            Console.WriteLine("Ingresar numero: ");
            int numero = Convert.Toint32(ConsoleReadLine());

            Console.WriteLine("Ingresar numero:");
            int doss = Convert.Toint32(ConsoleReadLine());

            if (numero > doss)
            {
                resultado = (numero * numero * numero) - (doss * doss * doss);
                operacion = "Diferencia de cubos";
            }
            else
            {
                resultado = (numero * numero * numero) + (doss * doss * doss);
                operacion = "Suma de cubos";
            }

            Console.WriteLine("La " + operacion + " de " + numero + " y " + doss + " es: " + resultado);

        }

    }
}
