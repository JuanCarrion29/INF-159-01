using System;

class cuadrado
{
    private cuadrado lado;

    public cuadrado(double lado)
    {
        this.lado = lado;
    }

    public double Area()
    {
        return lado * lado;
    }
}

class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double Area()
    {
        return Math.PI * radio * radio;
    }
}

class Triangulo
{
    private double baseTriangulo;
    private double altoTriangulo;

    public Triangulo(double baseTriangulo, double altoTriangulo)
    {
        this.baseTriangulo = baseTriangulo;
        this.altoTriangulo = altoTriangulo;
    }

    public double Area()
    {
        return 0.5 * baseTriangulo * altoTriangulo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Cuadrado");
        Console.WriteLine("2. Círculo");
        Console.WriteLine("3. Triángulo");
        Console.WriteLine("Seleccione la figura geométrica para calcular su área: ");
        int s = int.Parse(Console.ReadLine());

        switch (s)
        {
            case 1:
                Console.WriteLine("Ingrese el lado del cuadrado: ");
                double lado = double.Parse(Console.ReadLine());
                Square cuadrado = new Square(side);
                Console.WriteLine("El área del cuadrado es: " + cuadrado.Area());
                break;
            case 2:
                Console.WriteLine("Ingrese el radio del círculo: ");
                double radio = double.Par
