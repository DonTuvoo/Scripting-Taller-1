using System;

class Program
{
    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Módulo");
            Console.WriteLine("3. División");
            Console.WriteLine("4. Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularCuadrado();
                    break;
                case 2:
                    CalcularModulo();
                    break;
                case 3:
                    CalcularDivision();
                    break;
                case 4:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    static void CalcularCuadrado()
    {
        Console.WriteLine("Ingrese un número para calcular su cuadrado:");
        double numero = double.Parse(Console.ReadLine());

        double cuadrado = Math.Pow(numero, 2);

        Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
        VolverAlInicio();
    }

    static void CalcularModulo()
    {
        Console.WriteLine("Ingrese el primer número:");
        double numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double numero2 = double.Parse(Console.ReadLine());

        double modulo = numero1 % numero2;

        Console.WriteLine($"El módulo de {numero1} entre {numero2} es: {modulo}");
        VolverAlInicio();
    }

    static void CalcularDivision()
    {
        Console.WriteLine("Ingrese el numerador:");
        double numerador = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el denominador (distinto de cero):");
        double denominador = double.Parse(Console.ReadLine());

        if (denominador != 0)
        {
            double division = numerador / denominador;
            Console.WriteLine($"La división de {numerador} entre {denominador} es: {division}");
        }
        else
        {
            Console.WriteLine("Error: El denominador no puede ser cero.");
        }

        VolverAlInicio();
    }

    static void VolverAlInicio()
    {
        Console.WriteLine("Presione Enter para volver al inicio...");
        Console.ReadLine();
        Console.Clear();
    }
}