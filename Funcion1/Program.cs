using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número de máximo 8 cifras: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero) && input.Length <= 8)
        {
            int resultado = SumaDigitos(numero);
            Console.WriteLine("El resultado de la suma de los dígitos es: " + resultado);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Asegúrese de ingresar un número de máximo 8 cifras.");
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static int SumaDigitos(int num)
    {
        int suma = 0;

        while (num != 0)
        {
            suma += num % 10; // Agrega el último dígito al total
            num /= 10; // Quita el último dígito del número
        }

        if (suma > 9)
        {
            return SumaDigitos(suma);
        }
        else
        {
            return suma;
        }
    }
}
