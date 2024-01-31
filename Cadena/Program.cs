using System;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplos de prueba
        string cadena1 = "anita lava la tina";
        string cadena2 = "reconocer";
        string cadena3 = "hola";

        Console.WriteLine($"¿{cadena1} es un palíndromo? {EsPalindromo(cadena1)}");
        Console.WriteLine($"¿{cadena2} es un palíndromo? {EsPalindromo(cadena2)}");
        Console.WriteLine($"¿{cadena3} es un palíndromo? {EsPalindromo(cadena3)}");

        // Solicitar al usuario que presione una tecla para salir
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static bool EsPalindromo(string cadena)
    {
        // Eliminar espacios y convertir todo a minúsculas
        cadena = cadena.Replace(" ", "").ToLower();

        // Verificar si la cadena es igual a su inversa
        for (int i = 0; i < cadena.Length / 2; i++)
        {
            if (cadena[i] != cadena[cadena.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
